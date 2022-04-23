using _9lw.DB_Entities;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Data.Entity.Infrastructure;
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

namespace _9lw
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string AccountOwnerImage;

        public MainWindow()
        {
            InitializeComponent();

            LoadAccounts();
            LoadAccountsOwners();
        }

        private void GetOwnerID(DBContext context, ComboBox comboBox)
        {
            int?[] owners = context.accountOwners.Select(col => col.OWNER_ID).ToArray();
            if (owners.Length != 0)
            {
                comboBox.Items.Clear();
                owners = owners.OrderBy(x => x).ToArray();
                foreach (int field in owners)
                    comboBox.Items.Add(field);
            }
        }

        private void GetAccountNumbers(DBContext context)
        {
            int?[] owners = context.accounts.Select(col => col.NUMBER).ToArray();
            if (owners.Length != 0)
            {
                AccountNumbers.Items.Clear();
                owners = owners.OrderBy(x => x).ToArray();
                foreach (int field in owners)
                    AccountNumbers.Items.Add(field);
            }
        }

        private void LoadAccounts()
        {
            try
            {
                using (DBContext context = new DBContext())
                {
                    AccountsGrid.ItemsSource = context.accounts.ToList<Account>();
                    GetAccountNumbers(context);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки аккаунтов!");
            }
        }

        private void LoadAccountsOwners()
        {
            try
            {
                using (DBContext context = new DBContext())
                {
                    AccountsOwnersGrid.ItemsSource = context.accountOwners.ToList<AccountOwner>();
                    GetOwnerID(context, AccountOwnerId);
                    GetOwnerID(context, AccountOwnerIdForEdit);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки владельцов!");
            }
        }

        private void AddAccount_Click(object sender, RoutedEventArgs e)
        {
            AccountOwnerId.Text = AccountOwnerId.Text.Trim();
            AccountBalancy.Text = AccountBalancy.Text.Trim();

            if (
                AccountOwnerId.Text.Length == 0 ||
                DepositType.Text.Length == 0 ||
                AccountBalancy.Text.Length == 0 ||
                OpeningDate.Text.Length == 0 ||
                AccountOwnerImage == null ||
                !Decimal.TryParse(AccountBalancy.Text, out decimal balance)
            )
            {
                MessageBox.Show("Не все поля заполнены или имеют неверный формат!");
                return;
            }

            using (DBContext context = new DBContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        byte[] imageData = null;
                        if (AccountOwnerImage != null)
                        {
                            string shortFileName = this.AccountOwnerImage.Substring(AccountOwnerImage.LastIndexOf('\\') + 1);
                            using (System.IO.FileStream fs = new System.IO.FileStream(AccountOwnerImage, FileMode.Open))
                            {
                                imageData = new byte[fs.Length];
                                fs.Read(imageData, 0, imageData.Length);
                            }
                        }

                        string notifications = Notifications.IsChecked == true ? "on" : "off";
                        string internetBanking = InternetBanking.IsChecked == true ? "on" : "off";

                        Account account = new Account(Convert.ToInt32(AccountOwnerId.Text), Convert.ToString(DepositType.Text), balance,
                            (DateTime)OpeningDate.SelectedDate, notifications, internetBanking, imageData);

                        context.accounts.Add(account);
                        context.SaveChanges();
                        transaction.Commit();

                        LoadAccounts();
                        ClearAccountInputs();
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось добавить аккаунт!");
                        transaction.Rollback();
                    }
                }
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

            using (DBContext context = new DBContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        context.accountOwners.Add(new AccountOwner(passport, (DateTime)BirthDate.SelectedDate, SurnameInput.Text, NameInput.Text, PatronimicInput.Text));
                        context.SaveChanges();
                        transaction.Commit();

                        LoadAccountsOwners();
                        ClearAccountOwnerInputs();
                    }
                    catch
                    {
                        MessageBox.Show("Не удалось добавить владельца!");
                        transaction.Rollback();
                    }
                }
            }
        }

        private void ClearAccountInputs()
        {
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
            if (AccountNumbers.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поле с номером аккаунта!");
                return;
            }

            if (
                DepositType.Text.Length == 0 &&
                AccountBalancy.Text.Length == 0 &&
                OpeningDate.Text.Length == 0 &&
                AccountOwnerImage == null
            )
            {
                MessageBox.Show("Необходимо заполнить хотя бы одно поле!");
                return;
            }

            try
            {
                using (DBContext context = new DBContext())
                {
                    var account = context.accounts.Find(Convert.ToInt32(AccountNumbers.Text));

                    if (account == null) return;
                    if (DepositType.Text != "") account.DEPOSIT_TYPE = DepositType.Text;
                    if (AccountBalancy.Text != "") account.BALANCE = Convert.ToDecimal(AccountBalancy.Text);
                    if (OpeningDate.Text != "") account.OPENING_DATE = (DateTime)OpeningDate.SelectedDate;
                    
                    account.NOTIFICATIONS = Notifications.IsChecked == true ? "on" : "off";
                    account.INTERNET_BANKING = InternetBanking.IsChecked == true ? "on" : "off";

                    if (AccountOwnerImage != null)
                    {
                        byte[] imageData;
                        string shortFileName = this.AccountOwnerImage.Substring(AccountOwnerImage.LastIndexOf('\\') + 1);
                        using (System.IO.FileStream fs = new System.IO.FileStream(AccountOwnerImage, FileMode.Open))
                        {
                            imageData = new byte[fs.Length];
                            fs.Read(imageData, 0, imageData.Length);
                        }
                        account.CLIENT_IMAGE = imageData;
                    }
                    context.SaveChangesAsync().Wait();

                    LoadAccounts();
                    ClearAccountInputs();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка редактирования аккаунта!");
            }
        }

        private void DeleteAccount_Click(object sender, RoutedEventArgs e)
        {
            if (AccountNumbers.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить поле с номером аккаунта владельца!");
                return;
            }

            try
            {
                using (DBContext context = new DBContext())
                {
                    var account = context.accounts.Find(Convert.ToInt32(AccountNumbers.Text));
                    context.accounts.Remove(account);
                    context.SaveChanges();

                    LoadAccounts();
                    ClearAccountInputs();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления аккаунта!");
            }
        }

        private void EditAccountOwner_Click(object sender, RoutedEventArgs e)
        {
            PassportNumber.Text = PassportNumber.Text.Trim();
            SurnameInput.Text = SurnameInput.Text.Trim();
            NameInput.Text = NameInput.Text.Trim();
            PatronimicInput.Text = PatronimicInput.Text.Trim();

            if (AccountOwnerIdForEdit.Text == "")
            {
                MessageBox.Show("Необходимо заполнить поле с ID владельца!");
                return;
            }

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

            try
            {
                using (DBContext context = new DBContext())
                {
                    var owner = context.accountOwners.Find(Convert.ToInt32(AccountOwnerIdForEdit.Text));

                    if (PassportNumber.Text != "") owner.PASSPORT_NUMBER = Convert.ToInt32(PassportNumber.Text);
                    if (SurnameInput.Text != "") owner.SURNAME = SurnameInput.Text;
                    if (NameInput.Text != "") owner.NAME = NameInput.Text;
                    if (PatronimicInput.Text != "") owner.PATRONIMIC = PatronimicInput.Text;
                    if (BirthDate.Text != "") owner.BIRTH_DATE = BirthDate.DisplayDate;

                    context.SaveChangesAsync().Wait();

                    LoadAccountsOwners();
                    ClearAccountOwnerInputs();
                    ClearAccountInputs();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка редактирования владельца!");
            }
        }

        private void DeleteAccountOwner_Click(object sender, RoutedEventArgs e)
        {
            if (AccountOwnerIdForEdit.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить поле с ID владельца!");
                return;
            }

            try
            {
                using (DBContext context = new DBContext())
                {
                    var owner = context.accountOwners.Find(Convert.ToInt32(AccountOwnerIdForEdit.Text));
                    context.accountOwners.Remove(owner);
                    context.SaveChanges();

                    LoadAccountsOwners();
                    ClearAccountInputs();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка удаления владельца!");
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
            if (AccountNumbers.Text.Length == 0)
            {
                MessageBox.Show("Необходимо заполнить поле с номером аккаунта владельца!");
                return;
            }

            try
            {
                using (DBContext context = new DBContext())
                {
                    var account = context.accounts.Find(Convert.ToInt32(AccountNumbers.Text));
                    if (account != null && account.CLIENT_IMAGE != null)
                    {
                        MemoryStream memory = new MemoryStream(account.CLIENT_IMAGE);
                        OwnerImage.Source = BitmapFrame.Create(memory, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                    }
                    else
                    {
                        MessageBox.Show("Изображение отсутствует!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки изображения!");
            }
        }

        private void SortOwnersButton_Click(object sender, RoutedEventArgs e)
        {
            using (DBContext context = new DBContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        switch (OrderAccountOwners.Text)
                        {
                            case "OWNER_ID":
                                var owner1 = from p in context.accountOwners
                                            orderby p.OWNER_ID
                                            select p;
                                AccountsOwnersGrid.ItemsSource = owner1.ToList<AccountOwner>();
                                break;
                            case "PASSPORT_NUMBER":
                                var owner2 = from p in context.accountOwners
                                             orderby p.PASSPORT_NUMBER
                                             select p;
                                AccountsOwnersGrid.ItemsSource = owner2.ToList<AccountOwner>();
                                break;
                            case "BIRTH_DATE":
                                var owner3 = from p in context.accountOwners
                                             orderby p.BIRTH_DATE
                                             select p;
                                AccountsOwnersGrid.ItemsSource = owner3.ToList<AccountOwner>();
                                break;
                            case "SURNAME":
                                var owner4 = from p in context.accountOwners
                                             orderby p.SURNAME
                                             select p;
                                AccountsOwnersGrid.ItemsSource = owner4.ToList<AccountOwner>();
                                break;
                            case "NAME":
                                var owner5 = from p in context.accountOwners
                                             orderby p.NAME
                                             select p;
                                AccountsOwnersGrid.ItemsSource = owner5.ToList<AccountOwner>();
                                break;
                            case "PATRONIMIC":
                                var owner6 = from p in context.accountOwners
                                             orderby p.PATRONIMIC
                                             select p;
                                AccountsOwnersGrid.ItemsSource = owner6.ToList<AccountOwner>();
                                break;
                            default: MessageBox.Show("Ничего не изменено!");
                                break;
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        MessageBox.Show("Операция завершилась ошибкой!");
                        transaction.Rollback();
                    }
                }
            }
        }

        private void SortAccountsButton_Click(object sender, RoutedEventArgs e)
        {
            using (DBContext context = new DBContext())
            {
                using (var transaction = context.Database.BeginTransaction())
                {
                    try
                    {
                        switch (OrderAccounts.Text)
                        {
                            case "NUMBER":
                                var acc1 = from p in context.accounts
                                           orderby p.NUMBER
                                           select p;
                                AccountsGrid.ItemsSource = acc1.ToList<Account>();
                                break;
                            case "ACCOUNT_OWNER":
                                var acc2 = from p in context.accounts
                                             orderby p.ACCOUNT_OWNER
                                           select p;
                                AccountsGrid.ItemsSource = acc2.ToList<Account>();
                                break;
                            case "DEPOSIT_TYPE":
                                var acc3 = from p in context.accounts
                                             orderby p.DEPOSIT_TYPE
                                           select p;
                                AccountsGrid.ItemsSource = acc3.ToList<Account>();
                                break;
                            case "BALANCE":
                                var acc4 = from p in context.accounts
                                             orderby p.BALANCE
                                           select p;
                                AccountsGrid.ItemsSource = acc4.ToList<Account>();
                                break;
                            case "OPENING_DATE":
                                var acc5 = from p in context.accounts
                                             orderby p.OPENING_DATE
                                           select p;
                                AccountsGrid.ItemsSource = acc5.ToList<Account>();
                                break;
                            case "NOTIFICATIONS":
                                var acc6 = from p in context.accounts
                                             orderby p.NOTIFICATIONS
                                           select p;
                                AccountsGrid.ItemsSource = acc6.ToList<Account>();
                                break;
                            case "INTERNET_BANKING":
                                var acc7 = from p in context.accounts
                                           orderby p.INTERNET_BANKING
                                           select p;
                                AccountsGrid.ItemsSource = acc7.ToList<Account>();
                                break;
                            default:
                                MessageBox.Show("Ничего не изменено!");
                                break;
                        }
                        transaction.Commit();
                    }
                    catch
                    {
                        MessageBox.Show("Операция завершилась ошибкой!");
                        transaction.Rollback();
                    }
                }
            }
        }

        private void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (DBContext context = new DBContext())
                {
                    if (PassportNumber.Text != "" && SurnameInput.Text != "")
                    {
                        var result = context.accountOwners
                            .Where(t =>
                                t.PASSPORT_NUMBER.ToString().Contains(PassportNumber.Text) &&
                                t.SURNAME.Contains(SurnameInput.Text))
                            .Select(t => t);
                        AccountsOwnersGrid.ItemsSource = result.ToList();
                    }
                    else if (PassportNumber.Text == "" && SurnameInput.Text != "")
                    {
                        var result = context.accountOwners
                            .Where(t => t.SURNAME.Contains(SurnameInput.Text))
                            .Select(t => t);
                        AccountsOwnersGrid.ItemsSource = result.ToList();
                    }
                    else if (PassportNumber.Text != "" && SurnameInput.Text == "")
                    {
                        var result = context.accountOwners
                            .Where(t => t.PASSPORT_NUMBER.ToString().Contains(PassportNumber.Text))
                            .Select(t => t);
                        AccountsOwnersGrid.ItemsSource = result.ToList();
                    }
                    else
                    {
                        MessageBox.Show("Необходимо заполнить поля! " +
                            "Поиск происхожит только по номеру паспорта и/или фамилии!");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Не удалось произвести поиск!");
            }
        }
    }
}
