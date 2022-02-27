using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

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

        public BankAccount[][] SortHistory { get; set; }

        public SortForm()
        {
            InitializeComponent();
        }

        public SortForm(SortBy sort, BankAccount[] bankAccounts)
        {
            this.Sort = sort;
            InitializeComponent();
            this.SortHistory = new BankAccount[][] {};
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
                    bankAccounts = bankAccounts.OrderBy(x => x.DepositType).ToArray();
                    break;
                }
                case SortBy.OpeningDate:
                {
                    bankAccounts = bankAccounts.OrderBy(x => x.OpeningDate).ToArray();
                    break;
                }
            }
            foreach (BankAccount bankAccount in bankAccounts)
                Output.Text += bankAccount.ToString() + Environment.NewLine;
            this.SortHistory = this.SortHistory.Append(bankAccounts).ToArray();
        }
    }
}
