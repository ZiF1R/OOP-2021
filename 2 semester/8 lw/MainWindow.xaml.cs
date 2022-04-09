using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _8_lw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string connectionString;
        private DataTable Accounts;
        private DataTable AccountsOwners;
        public string AccountOwnerImage;

        public MainWindow()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();
                connection.Close();
            }
            catch (Exception ex)
            {
                CreateDBAndTables(connection);
                MessageBox.Show(ex.Message);
            }

            LoadAccounts();
            LoadAccountsOwners();
        }

        private void CreateDBAndTables(SqlConnection connection)
        {
            SqlCommand myCommand1 = new SqlCommand("use master create database Bank", connection);
            myCommand1.ExecuteNonQuery();

            SqlCommand myCommand2 = new SqlCommand(
                "CREATE TABLE ACCOUNT_OWNER (" +
                "    OWNER_ID int IDENTITY(1, 1) PRIMARY KEY," +
                "    PASSPORT_NUMBER int UNIQUE," +
                "    BIRTH_DATE date NOT NULL," +
                "    SURNAME varchar(30) NOT NULL," +
                "    NAME varchar(30) NOT NULL," +
                "    PATRONIMIC varchar(30) NOT NULL" +
                ");", connection);
            myCommand2.ExecuteNonQuery();

            SqlCommand myCommand3 = new SqlCommand(
                "CREATE TABLE ACCOUNT(" +
                "    NUMBER int PRIMARY KEY," +
                "    ACCOUNT_OWNER int CONSTRAINT OWNER_FK FOREIGN KEY REFERENCES ACCOUNT_OWNER(OWNER_ID)," +
                "    DEPOSIT_TYPE varchar(30)," +
                "    BALANCE money CHECK(BALANCE >= 0) default(0) NOT NULL," +
                "    OPENING_DATE date default(GETDATE()) NOT NULL," +
                "    NOTIFICATIONS varchar(3) CHECK(NOTIFICATIONS IN('on', 'off')) default('off')," +
	            "    INTERNET_BANKING varchar(3) CHECK(INTERNET_BANKING IN('on', 'off')) default('off')," +
	            "    CLIENT_IMAGE varbinary(max)); ", connection);
            myCommand3.ExecuteNonQuery();
        }

        private void LoadAccounts()
        {
            this.Accounts = new DataTable();
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM ACCOUNT";

            connection.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(this.Accounts);
                AccountsGrid.ItemsSource = this.Accounts.DefaultView;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }

        private void LoadAccountsOwners()
        {
            this.AccountsOwners = new DataTable();
            SqlConnection connection = new SqlConnection(this.connectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText =
                "SELECT * " +
                "FROM ACCOUNT_OWNER";

            connection.Open();
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(this.AccountsOwners);
                AccountsOwnersGrid.ItemsSource = this.AccountsOwners.DefaultView;

                command.CommandText =
                    "SELECT OWNER_ID " +
                    "FROM ACCOUNT_OWNER";
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    int[] ownersId = new int[] { };
                    while (reader.Read())
                    {
                        ownersId = ownersId.Append(Convert.ToInt32(reader.GetValue(0))).ToArray();
                    }

                    AccountOwnerId.Items.Clear();

                    ownersId = ownersId.OrderBy(x => x).ToArray();
                    foreach (int id in ownersId)
                    {
                        AccountOwnerId.Items.Add(id);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountNumber.Text = AccountNumber.Text.Trim();
            AccountOwnerId.Text = AccountOwnerId.Text.Trim();
            AccountBalancy.Text = AccountBalancy.Text.Trim();

            if (
                AccountNumber.Text.Length != 6 ||
                AccountOwnerId.Text.Length == 0 ||
                DepositType.Text.Length == 0 ||
                AccountBalancy.Text.Length == 0 ||
                OpeningDate.Text.Length == 0 ||
                AccountOwnerImage == null ||
                !Int32.TryParse(AccountBalancy.Text, out int balance) ||
                !Int32.TryParse(AccountNumber.Text, out int accNumber)
            )
            {
                MessageBox.Show("Не все поля заполнены или имеют неверный формат!");
                return;
            }

            SqlConnection connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                string notifications = Notifications.IsChecked == true ? "on" : "off";
                string internetBanking = InternetBanking.IsChecked == true ? "on" : "off";

                var addAccountCommand = string.Format(
                    $"INSERT INTO ACCOUNT VALUES(@accNumber, @owner, @deposit, @balance, @opening, @notifications, @internetBanking, @img)");

                using (SqlCommand command = new SqlCommand(addAccountCommand, connection))
                {
                    command.Transaction = transaction;

                    command.Parameters.AddWithValue("@accNumber", accNumber);
                    command.Parameters.AddWithValue("@owner", AccountOwnerId.Text);
                    command.Parameters.AddWithValue("@deposit", DepositType.Text);
                    command.Parameters.AddWithValue("@balance", balance);
                    command.Parameters.AddWithValue("@opening", OpeningDate.SelectedDate);
                    command.Parameters.AddWithValue("@notifications", notifications);
                    command.Parameters.AddWithValue("@internetBanking", internetBanking);

                    byte[] imageData;
                    string shortFileName = this.AccountOwnerImage.Substring(AccountOwnerImage.LastIndexOf('\\') + 1);
                    using (System.IO.FileStream fs = new System.IO.FileStream(AccountOwnerImage, FileMode.Open))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, imageData.Length);
                    }
                    command.Parameters.AddWithValue("@img", imageData);

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }

                LoadAccounts();
                ClearAccountInputs();

                string sqlExpression = "sp_GetUsers";
                SqlCommand command1 = new SqlCommand(sqlExpression, connection);
                command1.CommandType = System.Data.CommandType.StoredProcedure;

                var result = command1.ExecuteScalar();
                TotalOwnersCount.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(ex.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }

        private void AddAccountOwner_Click(object sender, RoutedEventArgs e)
        {
            PassportNumber.Text = PassportNumber.Text.Trim();
            SurnameInput.Text = SurnameInput.Text.Trim();
            NameInput.Text = NameInput.Text.Trim();
            PatronimicInput.Text = PatronimicInput.Text.Trim();

            if (
                PassportNumber.Text == "" ||
                SurnameInput.Text == "" ||
                NameInput.Text == "" ||
                PatronimicInput.Text == "" ||
                BirthDate.Text == "" ||
                !Int32.TryParse(PassportNumber.Text, out int passport)
            )
            {
                MessageBox.Show("Не все поля заполнены или имеют неверный формат!");
                return;
            }

            SqlConnection connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                var addAccountOwnerCommand = string.Format(
                    $"INSERT INTO ACCOUNT_OWNER VALUES(@PassNum, @Birth, @Surname, @Name, @Patronimic)");

                using (SqlCommand command = new SqlCommand(addAccountOwnerCommand, connection))
                {
                    command.Transaction = transaction;
                    
                    command.Parameters.AddWithValue("@PassNum", passport);
                    command.Parameters.AddWithValue("@Birth", BirthDate.SelectedDate);
                    command.Parameters.AddWithValue("@Surname", SurnameInput.Text);
                    command.Parameters.AddWithValue("@Name", NameInput.Text);
                    command.Parameters.AddWithValue("@Patronimic", PatronimicInput.Text);

                    command.ExecuteNonQuery();
                    transaction.Commit();

                    command.CommandText =
                        "SELECT OWNER_ID " +
                        "FROM ACCOUNT_OWNER";
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int[] ownersId = new int[] { };
                        while (reader.Read())
                        {
                            ownersId = ownersId.Append(Convert.ToInt32(reader.GetValue(0))).ToArray();
                        }

                        AccountOwnerId.Items.Clear();

                        ownersId = ownersId.OrderBy(x => x).ToArray();
                        foreach (int id in ownersId)
                        {
                            AccountOwnerId.Items.Add(id);
                        }
                    }
                }

                LoadAccountsOwners();
                ClearAccountOwnerInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ClearAccountInputs()
        {
            AccountNumber.Text = "";
            AccountOwnerId.Text = "";
            DepositType.SelectedIndex = 0;
            AccountBalancy.Text = "";
            Notifications.IsChecked = false;
            InternetBanking.IsChecked = false;
        }

        private void ClearAccountOwnerInputs()
        {
            PassportNumber.Text = "";
            SurnameInput.Text = "";
            NameInput.Text = "";
            PatronimicInput.Text = "";
        }

        private void EditAccount_Click(object sender, RoutedEventArgs e)
        {
            if (AccountOwnerId.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поле с ID владельца!");
                return;
            }

            if (
                AccountNumber.Text.Length != 6 &&
                DepositType.Text.Length == 0 &&
                AccountBalancy.Text.Length == 0 &&
                OpeningDate.Text.Length == 0 &&
                AccountOwnerImage == null
            )
            {
                MessageBox.Show("Необходимо заполнить хотя бы одно поле!");
                return;
            }

            string query = "UPDATE ACCOUNT SET ";
            if (AccountNumber.Text.Length == 6) query += "NUMBER = @num";
            if (DepositType.Text != "") query += ", DEPOSIT_TYPE = @deposit";
            if (AccountBalancy.Text != "") query += ", BALANCE = @balance";
            if (OpeningDate.Text != "") query += ", OPENING_DATE = @opening";
            if (AccountOwnerImage != null) query += ", CLIENT_IMAGE = @img";
            query += ", NOTIFICATIONS = @notifications, " +
                    "INTERNET_BANKING = @internetBanking " +
                    $"WHERE ACCOUNT_OWNER = {Convert.ToInt32(AccountOwnerId.Text)}";

            query = Regex.Replace(query, @"SET ,", "SET ");

            AccountNumber.Text = AccountNumber.Text.Trim();
            AccountOwnerId.Text = AccountOwnerId.Text.Trim();
            AccountBalancy.Text = AccountBalancy.Text.Trim();

            SqlConnection connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                string notifications = Notifications.IsChecked == true ? "on" : "off";
                string internetBanking = InternetBanking.IsChecked == true ? "on" : "off";

                var addAccountCommand = string.Format(query);
                using (SqlCommand command = new SqlCommand(addAccountCommand, connection))
                {
                    command.Transaction = transaction;

                    Int32.TryParse(AccountNumber.Text, out int accNumber);
                    Int32.TryParse(AccountBalancy.Text, out int balance);

                    if (AccountNumber.Text.Length == 6) command.Parameters.AddWithValue("@num", accNumber);
                    if (DepositType.Text != "") command.Parameters.AddWithValue("@deposit", DepositType.Text);
                    if (AccountBalancy.Text != "") command.Parameters.AddWithValue("@balance", balance);
                    if (OpeningDate.Text != "") command.Parameters.AddWithValue("@opening", OpeningDate.SelectedDate);
                                        
                    command.Parameters.AddWithValue("@notifications", notifications);
                    command.Parameters.AddWithValue("@internetBanking", internetBanking);

                    if (AccountOwnerImage != null)
                    {
                        byte[] imageData;
                        string shortFileName = this.AccountOwnerImage.Substring(AccountOwnerImage.LastIndexOf('\\') + 1);
                        using (System.IO.FileStream fs = new System.IO.FileStream(AccountOwnerImage, FileMode.Open))
                        {
                            imageData = new byte[fs.Length];
                            fs.Read(imageData, 0, imageData.Length);
                        }
                        command.Parameters.AddWithValue("@img", imageData);
                    }

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }

                LoadAccounts();
                ClearAccountInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            if (AccountOwnerId.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поле с ID владельца!");
                return;
            }

            SqlConnection connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                var addAccountOwnerCommand = string.Format(
                    $"DELETE FROM ACCOUNT " +
                    $"WHERE ACCOUNT_OWNER = {Convert.ToInt32(AccountOwnerId.Text)}");

                using (SqlCommand command = new SqlCommand(addAccountOwnerCommand, connection))
                {
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }

                LoadAccounts();
                ClearAccountInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EditAccountOwner_Click(object sender, RoutedEventArgs e)
        {
            if (AccountOwnerId.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поле с ID владельца!");
                return;
            }

            PassportNumber.Text = PassportNumber.Text.Trim();
            SurnameInput.Text = SurnameInput.Text.Trim();
            NameInput.Text = NameInput.Text.Trim();
            PatronimicInput.Text = PatronimicInput.Text.Trim();

            if (
                PassportNumber.Text == "" &&
                SurnameInput.Text == "" &&
                NameInput.Text == "" &&
                PatronimicInput.Text == "" &&
                BirthDate.Text == ""
            )
            {
                MessageBox.Show("Необходимо заполнить хотя бы одно поле!");
                return;
            }

            string query = "UPDATE ACCOUNT_OWNER SET ";

            if (PassportNumber.Text != "") query += "PASSPORT_NUMBER = @PassNum";
            if (SurnameInput.Text != "") query += ", SURNAME = @Surname";
            if (NameInput.Text != "") query += ", NAME = @Name";
            if (PatronimicInput.Text != "") query += ", PATRONIMIC = @Patronimic";
            if (BirthDate.Text != "") query += ", BIRTH_DATE = @Birth";

            query += $" WHERE OWNER_ID = {Convert.ToInt32(AccountOwnerId.Text)}";
            query = Regex.Replace(query, @"SET ,", "SET ");

            SqlConnection connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                var addAccountOwnerCommand = string.Format(query);
                using (SqlCommand command = new SqlCommand(addAccountOwnerCommand, connection))
                {
                    command.Transaction = transaction;

                    Int32.TryParse(PassportNumber.Text, out int passport);

                    if (PassportNumber.Text != "") command.Parameters.AddWithValue("@PassNum", passport);
                    if (SurnameInput.Text != "") command.Parameters.AddWithValue("@Surname", SurnameInput.Text);
                    if (NameInput.Text != "") command.Parameters.AddWithValue("@Name", NameInput.Text);
                    if (PatronimicInput.Text != "") command.Parameters.AddWithValue("@Patronimic", PatronimicInput.Text);
                    if (BirthDate.Text != "") command.Parameters.AddWithValue("@Birth", BirthDate.SelectedDate);

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }

                LoadAccountsOwners();
                ClearAccountOwnerInputs();
                ClearAccountInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteAccountOwner_Click(object sender, RoutedEventArgs e)
        {
            AccountOwnerId.Text = AccountOwnerId.Text.Trim();
            if (AccountOwnerId.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить поле с ID владельца!");
                return;
            }

            SqlConnection connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                var addAccountOwnerCommand = string.Format(
                    $"DELETE FROM ACCOUNT_OWNER " +
                    $"WHERE OWNER_ID = {Convert.ToInt32(AccountOwnerId.Text)}");

                using (SqlCommand command = new SqlCommand(addAccountOwnerCommand, connection))
                {
                    command.Transaction = transaction;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }

                LoadAccountsOwners();
                ClearAccountInputs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadImage_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.ShowDialog();
            AccountOwnerImage = dialog.FileName;
        }

        private void ShowAccountOwnerImage_Click(object sender, RoutedEventArgs e)
        {
            AccountOwnerId.Text = AccountOwnerId.Text.Trim();
            if (AccountOwnerId.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить поле с ID владельца!");
                return;
            }

            DataTable ImgUser = new DataTable();
            var connection = new SqlConnection(this.connectionString);
            try
            {
                connection.Open();

                var command = new SqlCommand(
                    $"SELECT CLIENT_IMAGE " +
                    $"FROM ACCOUNT " +
                    $"WHERE ACCOUNT_OWNER = {Convert.ToInt32(AccountOwnerId.Text)}", connection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(ImgUser);

                if (ImgUser.Rows[0].ItemArray[0].ToString().Length != 0)
                {
                    var pic = (byte[])ImgUser.Rows[0].ItemArray[0];
                    MemoryStream memory = new MemoryStream(pic);
                    OwnerImage.Source = BitmapFrame.Create(memory, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                }
                else
                {
                    MessageBox.Show("Изображение отсутствует!");
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
                MessageBox.Show(er.StackTrace);
            }
            finally
            {
                connection.Close();
            }
        }

        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            var connection = new SqlConnection(this.connectionString);

            connection.Open();
            SqlTransaction transaction = connection.BeginTransaction();
            try
            {
                if (OrderAccountOwners.SelectedItem != null)
                {
                    DataTable Sort = new DataTable();
                    var command = new SqlCommand($"Select * from ACCOUNT_OWNER Order by '{OrderAccountOwners.Text}'", connection);
                    command.Transaction = transaction;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(Sort);
                    AccountsOwnersGrid.ItemsSource = Sort.DefaultView;
                }
                if (OrderAccounts.SelectedItem != null)
                {
                    DataTable Sort = new DataTable();
                    var command = new SqlCommand($"Select * from ACCOUNT Order by '{OrderAccounts.Text}'", connection);
                    command.Transaction = transaction;
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(Sort);
                    AccountsGrid.ItemsSource = Sort.DefaultView;
                }
                transaction.Commit();
            }
            catch (Exception er)
            {
                MessageBox.Show("Операция завершилась ошибкой!");
            }
            finally
            {
                transaction.Dispose();
                connection.Close();
            }
        }
    }
}
