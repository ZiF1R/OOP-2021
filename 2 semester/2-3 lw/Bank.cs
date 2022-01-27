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

namespace _2_lw
{
    public partial class Bank : Form
    {
        private BankAccount[] bankAccounts = new BankAccount[] { };

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
                new Passport(PassportInput.Text, ExpiresDate.Value)
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
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(BankAccount[]));
            using (FileStream fs = new FileStream("bankAccounts.json", FileMode.OpenOrCreate))
            {
                serializer.WriteObject(fs, this.bankAccounts);
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
                    BankAccount[] restoredFigure = (BankAccount[])serializer.ReadObject(fs);
                    foreach (BankAccount bankAccount in restoredFigure)
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
    }
}
