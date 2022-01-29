using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using _2_lw.SearchForm;
using _2_lw.SortForm;

namespace _2_lw
{
    public partial class Bank : Form
    {
        private BankAccount[] bankAccounts = new BankAccount[] { };
        public BankAccount[][] SortHistory = new BankAccount[][] { };
        public BankAccount[][] SearchHistory = new BankAccount[][] { };

        public Bank()
        {
            InitializeComponent();
            DepositTypeList.SelectedIndex = 0;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!this.isFormFieldsDataCorrect())
            {
                MessageBox.Show(
                    "Не все поля заполнены или имеют неверный формат!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            Owner owner = new Owner(
                SurnameInput.Text,
                NameInput.Text,
                PatronimicInput.Text,
                BirthDate.Value,
                new Passport(PassportInput.Text.ToUpper(), ExpiresDate.Value)
            );

            BankAccount newAccount = new BankAccount(
                Convert.ToInt32(Regex.Replace(BankAccountNumber.Text, @"-", "")),
                DepositTypeList.SelectedItem.ToString(),
                AccountOpeningDate.Value,
                owner,
                Convert.ToInt32(AccountBalance.Value),
                SMSNotificationsCheckbox.Checked,
                InternetBanking.Checked
            );

            this.bankAccounts = this.bankAccounts.Append(newAccount).ToArray();
            this.ClearFormFields();
        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {
            if (this.bankAccounts.Length > 0)
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(BankAccount[]));
                using (FileStream fs = new FileStream("bankAccounts.json", FileMode.Create))
                {
                    serializer.WriteObject(fs, this.bankAccounts);
                    MessageBox.Show("Serialization success!", "Serialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void DeserializeButton_Click(object sender, EventArgs e)
        {
            if (File.Exists("bankAccounts.json"))
            {
                Output.Text = String.Empty;
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(BankAccount[]));
                using (FileStream fs = new FileStream("bankAccounts.json", FileMode.Open))
                {
                    BankAccount[] restoredFigures = (BankAccount[])serializer.ReadObject(fs);
                    this.bankAccounts = restoredFigures;
                    foreach (BankAccount bankAccount in restoredFigures)
                        Output.Text += bankAccount.ToString() + Environment.NewLine;
                }
            }
        }

        private bool isFormFieldsDataCorrect()
        {
            string[] depositTypes = { "Накопительный", "Расчетный", "Сберегательный", "Срочный" };

            if (BankAccountNumber.Text.Length != 11) return false;
            if (!depositTypes.Contains(DepositTypeList.SelectedItem.ToString())) return false;

            // Full name fields should be filled and contain only alphabetic symbols
            if (SurnameInput.Text == "" || Regex.IsMatch(SurnameInput.Text, @"[\W|\d]")) return false;
            if (NameInput.Text == "" || Regex.IsMatch(NameInput.Text, @"[\W|\d]")) return false;
            if (PatronimicInput.Text == "" || Regex.IsMatch(PatronimicInput.Text, @"[\W|\d]")) return false;

            if (PassportInput.Text.Length != 14) return false;

            return true;
        }

        private void ClearFormFields()
        {
            BankAccountNumber.Text =
                NameInput.Text =
                SurnameInput.Text =
                PatronimicInput.Text =
                PassportInput.Text = String.Empty;
            DepositTypeList.SelectedIndex = 0;
            AccountOpeningDate.Value =
                ExpiresDate.Value =
                BirthDate.Value = DateTime.Now;
            AccountBalance.Value = AccountBalance.Minimum;
            SMSNotificationsCheckbox.Checked = false;
            InternetBanking.Checked = false;
        }

        private void AboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Сreator: Добриян Александр\n" +
                "Version: v1.0.3",
                "About program",
                MessageBoxButtons.OK
            );
        }

        ///
        /// Search menu buttons
        ///
        private void SearchAccountNumber_Click(object sender, EventArgs e)
        {
            this.OpenSearchForm(SearchForm.SearchForm.SearchBy.AccountNumber);
        }

        private void SearchFullName_Click(object sender, EventArgs e)
        {
            this.OpenSearchForm(SearchForm.SearchForm.SearchBy.FullName);
        }

        private void SearchBalance_Click(object sender, EventArgs e)
        {
            this.OpenSearchForm(SearchForm.SearchForm.SearchBy.Balance);
        }

        private void SearchDepositType_Click(object sender, EventArgs e)
        {
            this.OpenSearchForm(SearchForm.SearchForm.SearchBy.DepositType);
        }

        private void OpenSearchForm(SearchForm.SearchForm.SearchBy option)
        {
            SearchForm.SearchForm search = new SearchForm.SearchForm(option, this.bankAccounts);
            search.Activate();
            search.Show();
            search.Disposed += (object sender, EventArgs e) =>
            {
                if (search.SearchHistory.Length > 0)
                {
                    this.SearchHistory = this.SearchHistory.Concat(search.SearchHistory).ToArray();
                }
            };
        }

        ///
        /// Sort menu buttons
        ///
        private void SortDepositType_Click(object sender, EventArgs e)
        {
            this.OpenSortForm(SortForm.SortForm.SortBy.DepositType);
        }

        private void SortOpeningDate_Click(object sender, EventArgs e)
        {
            this.OpenSortForm(SortForm.SortForm.SortBy.OpeningDate);
        }

        private void OpenSortForm(SortForm.SortForm.SortBy option)
        {
            SortForm.SortForm sort = new SortForm.SortForm(option, this.bankAccounts);
            sort.Activate();
            sort.Show();
            sort.Disposed += (object sender, EventArgs e) =>
            {
                if (sort.SortHistory.Length > 0)
                {
                    this.SortHistory = this.SortHistory.Concat(sort.SortHistory).ToArray();
                }
            };
        }

        private void SaveMenuButton_Click(object sender, EventArgs e)
        {
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(BankAccount[][]));
            using (FileStream fs = new FileStream("queriesHistory.json", FileMode.OpenOrCreate))
            {
                serializer.WriteObject(fs, this.SearchHistory.Concat(this.SortHistory).ToArray());
                MessageBox.Show("Serialization success!", "Serialization", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
