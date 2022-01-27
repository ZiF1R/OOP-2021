using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(SearchBy search)
        {
            this.Search = search;
            InitializeComponent();
            SearchInputLabel.Text = $"Enter {this.Search}:";
        }
    }
}
