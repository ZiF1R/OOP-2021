using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_lw
{
    public partial class RemoveAccountForm : Form
    {
        public BankAccount[] bankAccounts = null;

        public RemoveAccountForm()
        {
            InitializeComponent();
        }

        public RemoveAccountForm(BankAccount[] bankAccounts)
        {
            InitializeComponent();
            this.bankAccounts = bankAccounts;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (BankAccountNumber.Text.Length != 11)
            {
                MessageBox.Show(
                    "Заполните поле!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            int accountNumberToRemove = Convert.ToInt32(Regex.Replace(BankAccountNumber.Text, @"-", ""));

            int lengthBeforeRemoving = this.bankAccounts.Length;
            this.bankAccounts = this.bankAccounts.Where(acc => acc.Number != accountNumberToRemove).ToArray();

            if (lengthBeforeRemoving != this.bankAccounts.Length)
            {
                MessageBox.Show(
                    "Аккаунт был успешно удален!",
                    "Успех",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(
                    "Аккаунт с таким номером не найден!",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            BankAccountNumber.Text = "";
        }
    }
}
