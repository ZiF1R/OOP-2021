using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1_lw
{
    public partial class Generator : Form
    {
        private List<Square> list = new List<Square>();
        private delegate List<Square> Comparator(Comparison<Square> condition);

        public Generator()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            this.list.Clear();
            Random random = new Random();
            for (int i = 0; i < Convert.ToInt32(SizeInput.Value); i++)
                this.list.Add(new Square(random.Next(99) + 1));

            this.PrintList(this.list);
        }

        private void AscendingSortButton_Click(object sender, EventArgs e)
        {
            Comparator comparator;
            comparator = this.ListSorting;
            comparator((el1, el2) =>
            {
                if (el1.EdgeSize > el2.EdgeSize) return 1;
                else if (el1.EdgeSize == el2.EdgeSize) return 0;
                else return -1;
            });
            this.PrintList(this.list);
        }

        private void DescendingSortButton_Click(object sender, EventArgs e)
        {
            Comparator comparator;
            comparator = this.ListSorting;
            comparator((el1, el2) =>
            {
                if (el1.EdgeSize < el2.EdgeSize) return 1;
                else if (el1.EdgeSize == el2.EdgeSize) return 0;
                else return -1;
            });
            this.PrintList(this.list);
        }

        private List<Square> ListSorting(Comparison<Square> condition)
        {
            list.Sort(condition);
            return list;
        }

        private void PrintList(List<Square> list)
        {
            Output.Items.Clear();
            for (int i = 0; i < list.Count; i++)
                Output.Items.Add(list[i].ToString());
        }

        ///
        /// Queries
        ///
        private void FirstQuery_Click(object sender, EventArgs e)
        {
            if (this.list.Count == 0) return;
            Square getMinimalElement = (from square in this.list select square).Min();
            Output.Items.Clear();
            Output.Items.Add((string)getMinimalElement.ToString());
        }

        private void SecondQuery_Click(object sender, EventArgs e)
        {
            if (this.list.Count == 0) return;
            Square getMaximalElement = (from square in this.list select square).Max();
            Output.Items.Clear();
            Output.Items.Add((string)getMaximalElement.ToString());
        }

        private void ThirdQuery_Click(object sender, EventArgs e)
        {
            if (this.list.Count == 0) return;

            (int min, int max) range = (10, 44);
            List<Square> getElementsInRange = (from square in this.list
                                               where (square.EdgeSize >= range.min) && (square.EdgeSize <= range.max)
                                               select square).ToList();

            this.PrintList(getElementsInRange);
        }
    }
}
