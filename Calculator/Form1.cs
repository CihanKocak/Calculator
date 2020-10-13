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
    public partial class Form1 : Form
    {
        bool operandState = false;
        double transactionResult;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
            ActiveControl = tbxResult;
            tbxResult.Focus();
        }
      
        private void SelectedNumberButtons(object sender, EventArgs e)
        {
            if (tbxResult.Text == "0" || operandState)
            {
                tbxResult.Clear();
            }
            operandState = false;
            Button button = (Button)sender;
            tbxResult.Text += button.Text;
        }

        private void OperandButtons(object sender, EventArgs e)
        {
            operandState = true;
            Button button = (Button)sender;
            string newOperation = button.Text;

            lblMemory.Text = lblMemory.Text + " " + tbxResult.Text + " " + newOperation;

            switch (operation)
            {
                case "+": tbxResult.Text = (transactionResult + Double.Parse(tbxResult.Text)).ToString(); break;
                case "-": tbxResult.Text = (transactionResult - Double.Parse(tbxResult.Text)).ToString(); break;
                case "X": tbxResult.Text = (transactionResult * Double.Parse(tbxResult.Text)).ToString(); break;
                case "÷": tbxResult.Text = (transactionResult / Double.Parse(tbxResult.Text)).ToString(); break;
                case "%": tbxResult.Text = (transactionResult % Double.Parse(tbxResult.Text)).ToString(); break;
            }
            transactionResult = Double.Parse(tbxResult.Text);
            tbxResult.Text = transactionResult.ToString();
            operation = newOperation;
        }

        private void BtnComma_Click(object sender, EventArgs e)
        {
            if (tbxResult.Text.IndexOf(",") < 1)
            {
                tbxResult.Text += ",";
            }
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "0";
            lblMemory.Text = "";
            operation = "";
            transactionResult = 0;
            operandState = false;
        }
        private void BtnCe_Click(object sender, EventArgs e)
        {
            tbxResult.Text = "0";
        }

        private void BtnBackspace_Click(object sender, EventArgs e)
        {
            tbxResult.Text = tbxResult.Text.Substring(0, tbxResult.Text.Length - 1);
            if (tbxResult.Text == "")
            {
                tbxResult.Text = "0";
            }
        }
        private void BtnPow_Click(object sender, EventArgs e)
        {
            double pow = Convert.ToDouble(tbxResult.Text);
            pow = Math.Pow(pow, 2);
            tbxResult.Text = Convert.ToString(pow);
        }

        private void BtnSqrt_Click(object sender, EventArgs e)
        {
            double sqrt = Convert.ToDouble(tbxResult.Text);
            sqrt = Math.Sqrt(sqrt);
            tbxResult.Text = Convert.ToString(sqrt);
        }

        private void BtnDivideX_Click(object sender, EventArgs e)
        {
            double divideX = Convert.ToDouble(tbxResult.Text);
            divideX = 1 / (divideX);
            tbxResult.Text = Convert.ToString(divideX);
        }

        private void BtnEqual_Click(object sender, EventArgs e)
        {
            lblMemory.Text = "";
            operandState = true;

            switch (operation)
            {
                case "+": tbxResult.Text = (transactionResult + Double.Parse(tbxResult.Text)).ToString(); break;
                case "-": tbxResult.Text = (transactionResult - Double.Parse(tbxResult.Text)).ToString(); break;
                case "X": tbxResult.Text = (transactionResult * Double.Parse(tbxResult.Text)).ToString(); break;
                case "÷": tbxResult.Text = (transactionResult / Double.Parse(tbxResult.Text)).ToString(); break;
                case "%": tbxResult.Text = (transactionResult % Double.Parse(tbxResult.Text)).ToString(); break;
            }
            transactionResult = Double.Parse(tbxResult.Text);
            tbxResult.Text = transactionResult.ToString();
            operation = "";
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0)
            {
                btnZero.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1)
            {
                btnOne.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2)
            {
                btnTwo.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3)
            {
                btnThree.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4)
            {
                btnFour.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5)
            {
                btnFive.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6)
            {
                btnSix.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7)
            {
                btnSeven.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8)
            {
                btnEight.PerformClick();
            }
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9)
            {
                btnNine.PerformClick();
            }
            if (e.KeyCode == Keys.Divide)
            {
                btnDivide.PerformClick();
            }
            if (e.KeyCode == Keys.Multiply)
            {
                btnMultiply.PerformClick();
            }
            if (e.KeyCode == Keys.Add)
            {
                btnPlus.PerformClick();
            }
            if (e.KeyCode == Keys.Subtract)
            {
                btnMinus.PerformClick();
            }
            if (e.KeyCode == Keys.Decimal)
            {
                btnComma.PerformClick();
            }
            if (e.KeyCode == Keys.Enter)
            {
                btnEqual.PerformClick();
            }
            if (e.KeyCode == Keys.Delete)
            {
                btnC.PerformClick();
            }
            if (e.KeyCode == Keys.Back)
            {
                btnBackspace.PerformClick();
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
