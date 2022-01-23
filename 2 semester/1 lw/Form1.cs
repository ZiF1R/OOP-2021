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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            OutputField.Text = "";
        }

        private void BackspaceButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
                OutputField.Text = OutputField.Text.Substring(0, OutputField.Text.Length - 1);
        }

        private void ZeroNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "0";
        }

        private void OneNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "1";
        }

        private void TwoNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "2";
        }

        private void ThreeNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "3";
        }

        private void FourNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "4";
        }

        private void FiveNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "5";
        }

        private void SixNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "6";
        }

        private void SevenNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "7";
        }

        private void EightNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "8";
        }

        private void NineNumberButton_Click(object sender, EventArgs e)
        {
            OutputField.Text += "9";
        }

        private void OutputField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
