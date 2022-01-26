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

namespace _2_lw
{
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (!this.isFormFieldsDataCorrect())
                MessageBox.Show("Не все поля заполнены или имеют неверный формат!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool isFormFieldsDataCorrect()
        {
            string[] depositTypes = { "Накопительный", "Расчетный", "Сберегательный", "Срочный" };

            if (BankAccountNumber.Text.Length != 11) return false;
            if (!depositTypes.Contains(DepositTypeList.SelectedItem.ToString())) return false;
            if (SurnameInput.Text == "" || Regex.IsMatch(SurnameInput.Text, @"[\W|\d]")) return false;
            if (NameInput.Text == "" || Regex.IsMatch(NameInput.Text, @"[\W|\d]")) return false;
            if (PatronimicInput.Text == "" || Regex.IsMatch(PatronimicInput.Text, @"[\W|\d]")) return false;
            if (PassportInput.Text.Length != 14) return false;

            return true;
        }
    }
}
