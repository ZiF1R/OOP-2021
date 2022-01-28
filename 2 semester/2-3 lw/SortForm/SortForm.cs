using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2_lw.SortForm
{
    public partial class SortForm : Form
    {
        public SortBy Sort { get; set; }
        public enum SortBy
        {
            DepositType,
            OpeningDate
        }

        public SortForm()
        {
            InitializeComponent();
        }

        public SortForm(SortBy sort, BankAccount[] bankAccounts)
        {
            this.Sort = sort;
            InitializeComponent();
            this.GetSortedAccounts(bankAccounts);
        }

        private void GetSortedAccounts(BankAccount[] bankAccounts)
        {
            if (bankAccounts.Length == 0)
            {
                Output.Text = "There are no elements!";
                return;
            }
            switch (this.Sort)
            {
                case SortBy.DepositType:
                {
                    string[] depositTypes = { "Накопительный", "Расчетный", "Сберегательный", "Срочный" };
                    Array.Sort<BankAccount>(bankAccounts, (el1, el2) =>
                    {
                        int i = Array.IndexOf(depositTypes, el1.DepositType);
                        int j = Array.IndexOf(depositTypes, el2.DepositType);

                        if (i == j) return 0;
                        else if (i > j) return 1;
                        else return -1;
                    });
                    break;
                }
                case SortBy.OpeningDate:
                {
                    Array.Sort<BankAccount>(bankAccounts, (el1, el2) =>
                    {
                        if (el1.OpeningDate == el2.OpeningDate) return 0;
                        else if (el1.OpeningDate > el2.OpeningDate) return 1;
                        else return -1;
                    });
                    break;
                }
            }
            foreach (BankAccount bankAccount in bankAccounts)
                Output.Text += bankAccount.ToString() + Environment.NewLine;
        }
    }
}
