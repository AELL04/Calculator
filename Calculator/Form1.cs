using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        double firstNumber;
        string operation;
        public Calculator()
        {
            InitializeComponent();
        }
        private void btn0_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + "0";
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }
        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }
        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }
        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }
        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }
        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }
        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }
        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" && txtResult.Text != null)
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "+";
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "-";
        }
        private void btnMultiply_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "*";
        }
        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "/";
        }
        private void btnComma_Click(object sender, EventArgs e)
        {
            txtResult.Text = txtResult.Text + ".";
        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            double secondNumber;
            double result;

            secondNumber = Convert.ToDouble(txtResult.Text);

            if (operation == "+")
            {
                result = (firstNumber + secondNumber);
                txtResult.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "-")
            {
                result = (firstNumber - secondNumber);
                txtResult.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "*")
            {
                result = (firstNumber * secondNumber);
                txtResult.Text = Convert.ToString(result);
                firstNumber = result;
            }
            if (operation == "/")
            {
                if (secondNumber == 0)
                {
                    Console.WriteLine("SYNTAX ERROR");
                }
                else
                {
                    result = (firstNumber / secondNumber);
                    txtResult.Text = Convert.ToString(result);
                    firstNumber = result;
                }
            }
        }
    }
}
