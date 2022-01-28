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

namespace _2_lw.SearchForm
{
    public partial class SearchForm : Form
    {
        public SearchBy Search { get; set; }
        public enum SearchBy
        {
            AccountNumber,
            FullName,
            Balance,
            DepositType
        }

        public BankAccount[][] SearchHistory = new BankAccount[][] { };
        private BankAccount[] bankAccounts = null;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(SearchBy search, BankAccount[] bankAccounts)
        {
            this.Search = search;
            this.bankAccounts = bankAccounts;
            InitializeComponent();
            SearchInputLabel.Text = $"Enter {this.Search}:";
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchInput.Text != "")
            {
                BankAccount[] matchesAccounts = null;
                switch (this.Search)
                {
                    case SearchBy.AccountNumber:
                        {
                            matchesAccounts = this.findAccounts((acc) =>
                                Regex.IsMatch(acc.Number.ToString(), SearchInput.Text));
                            break;
                        }
                    case SearchBy.FullName:
                        {
                            matchesAccounts = this.findAccounts((acc) =>
                                Regex.IsMatch(
                                    $"{acc.AccountOwner.Surname} {acc.AccountOwner.Name} {acc.AccountOwner.Patronimic}",
                                    @"(?i)" + SearchInput.Text
                                )
                            );
                            break;
                        }
                    case SearchBy.Balance:
                        {
                            matchesAccounts = this.findAccounts((acc) => acc.Balance >= Convert.ToInt32(SearchInput.Text));
                            break;
                        }
                    case SearchBy.DepositType:
                        {
                            matchesAccounts = this.findAccounts((acc) => Regex.IsMatch(acc.DepositType, @"(?i)" + SearchInput.Text));
                            break;
                        }
                }

                Output.Text = "";
                if (matchesAccounts.Length > 0)
                {
                    this.SearchHistory.Append(matchesAccounts);
                    foreach (BankAccount bankAccount in matchesAccounts)
                        Output.Text += bankAccount.ToString() + Environment.NewLine;
                }
                else Output.Text = "Nothing found!";
            }
            else Output.Text = "Nothing found!";
        }

        private BankAccount[] findAccounts(Predicate<BankAccount> predicate)
        {
            return Array.FindAll(this.bankAccounts, predicate);
        }
    }
}
