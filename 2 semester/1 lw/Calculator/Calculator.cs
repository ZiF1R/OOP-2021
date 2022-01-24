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

namespace _1_lw
{
    public partial class Calculator : Form
    {
        private double prevNumber = 0;
        private double nextNumber = 0;
        private string selectedOperation = "";

        public Calculator()
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

        ///
        /// Buttons for numbers
        ///
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

        private void DotButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text.Length > 0 && !OutputField.Text.Contains("."))
                OutputField.Text += ".";
        }

        private void ChangeSignButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = -number;
                OutputField.Text = Convert.ToString(number);
            }
        }

        ///
        /// Buttons for operations
        ///
        private void AddButton_Click(object sender, EventArgs e)
        {
            this.savePrevNumber();
            this.selectedOperation = "+";
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            this.savePrevNumber();
            this.selectedOperation = "-";
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            this.savePrevNumber();
            this.selectedOperation = "*";
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            this.savePrevNumber();
            this.selectedOperation = "/";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            this.saveNextNumber();
            double result = 0;
            
            // apply selected operation to numbers
            switch (this.selectedOperation)
            {
                case "+":
                    result = this.prevNumber + this.nextNumber;
                    break;
                case "-":
                    result = this.prevNumber - this.nextNumber;
                    break;
                case "*":
                    result = this.prevNumber * this.nextNumber;
                    break;
                case "/":
                    result = this.prevNumber / this.nextNumber;
                    break;
                default: break;
            }

            OutputField.Text = Convert.ToString(result);
        }

        ///
        /// Buttons for functions
        ///
        private void SquareButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = Math.Pow(number, 2);
                OutputField.Text = Convert.ToString(number);
            }
        }

        private void CubeButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = Math.Pow(number, 3);
                OutputField.Text = Convert.ToString(number);
            }
        }

        private void SinButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = Math.Sin(number);
                OutputField.Text = Convert.ToString(number);
            }
        }

        private void CosButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = Math.Cos(number);
                OutputField.Text = Convert.ToString(number);
            }
        }

        private void TanButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = Math.Tan(number);
                OutputField.Text = Convert.ToString(number);
            }
        }

        private void CotButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = 1 / Math.Tan(number);
                OutputField.Text = Convert.ToString(number);
            }
        }

        private void CubeRootButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = Math.Pow(number, 1 / 3.0);
                OutputField.Text = Convert.ToString(number);
            }
        }

        private void SquareRootButton_Click(object sender, EventArgs e)
        {
            if (OutputField.Text != "")
            {
                double number = Convert.ToDouble(OutputField.Text);
                number = Math.Sqrt(number);
                OutputField.Text = Convert.ToString(number);
            }
        }

        ///
        /// function-helpers
        ///
        private void savePrevNumber()
        {
            if (OutputField.Text.EndsWith("."))
                OutputField.Text = OutputField.Text.Substring(0, OutputField.Text.Length - 1);
            if (OutputField.Text.Length == 0) OutputField.Text = "0";
            this.prevNumber = Convert.ToDouble(OutputField.Text);
            OutputField.Text = "";
        }

        private void saveNextNumber()
        {
            if (OutputField.Text.EndsWith("."))
                OutputField.Text = OutputField.Text.Substring(0, OutputField.Text.Length - 1);
            if (OutputField.Text.Length == 0) OutputField.Text = "0";
            this.nextNumber = Convert.ToDouble(OutputField.Text);
            OutputField.Text = "";
        }
    }
}
