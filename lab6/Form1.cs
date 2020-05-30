using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab6
{
    public partial class Form1 : Form
    {

        string input;
        string first;
        string second;
        char operation;
        double result;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Textbox_TextChanged(object sender, EventArgs e)
        {

        }


        private void Button1_Click_1(object sender, EventArgs e)
        {
            label.Text += operation + input + "=";
            second = input;
            double firstoperand = Convert.ToDouble(first);
            double secondoperand = Convert.ToDouble(second);
            switch (operation)
            {
                case '+':
                    result = firstoperand + secondoperand;
                    textbox.Text = Convert.ToString(result);
                    break;
                case '-':
                    result = firstoperand - secondoperand;
                    textbox.Text = Convert.ToString(result);
                    break;
                case '*':
                    result = firstoperand * secondoperand;
                    textbox.Text = Convert.ToString(result);
                    break;
                case '/':
                    if (secondoperand == 0)
                    {
                        label.Text = String.Empty;
                        textbox.Text = "На ноль делить нельзя!";
                    }
                    else
                    {
                        result = firstoperand / secondoperand;
                        textbox.Text = Convert.ToString(result);
                    }
                    break;
            }

            input = Convert.ToString(result);
        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            textbox.Text += "1";
            input += "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            textbox.Text += "2";
            input += "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            textbox.Text += "3";
            input += "3";
        }


        private void Btn4_Click(object sender, EventArgs e)
        {
            textbox.Text += "4";
            input += "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            textbox.Text += "5";
            input += "5";
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            textbox.Text += "6";
            input += "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            textbox.Text += "7";
            input += "7";
        }

        private void Btn8_Click(object sender, EventArgs e)
        {
            textbox.Text += "8";
            input += "8";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            textbox.Text += "9";
            input += "9";
        }

        private void Btn0_Click(object sender, EventArgs e)
        {
            textbox.Text += "0";
            input += "0";
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            textbox.Text += ".";
            input += ",";
        }

        private void CeBtn_Click(object sender, EventArgs e)
        {
            if (textbox.Text != null)
                textbox.Text = "0";
            input = String.Empty;
            first = String.Empty;
            second = String.Empty;
            label.Text = "";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            first = input;
            operation = '+';
            label.Text = input;
            textbox.Text = "+";
            input = String.Empty;
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            first = input;
            operation = '-';
            label.Text = input;
            textbox.Text = "-";
            input = String.Empty;
        }

        private void MultiBtn_Click(object sender, EventArgs e)
        {
            first = input;
            operation = '*';
            label.Text = input;
            textbox.Text = "*";
            input = String.Empty;
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            first = input;
            operation = '/';
            label.Text = input;
            textbox.Text = "/";
            input = String.Empty;
        }

        private void Label_Click(object sender, EventArgs e)
        {

        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            switch(e.KeyChar){
                case '1': btn1.PerformClick();
                    break;
                case '2': btn2.PerformClick();
                    break;
                case '3': btn3.PerformClick();
                    break;
                case '4': btn4.PerformClick();
                    break;
                case '5': btn5.PerformClick();
                    break;
                case '6': btn6.PerformClick();
                    break;
                case '7': btn7.PerformClick();
                    break;
                case '8': btn8.PerformClick();
                    break;
                case '9': btn9.PerformClick();
                    break;
                case '0': btn0.PerformClick();
                    break;
                case '+': plusBtn.PerformClick();
                    break;
                case '-': minusBtn.PerformClick();
                    break;
                case '*': multiBtn.PerformClick();
                    break;
                case '/': divBtn.PerformClick();
                    break;
                case '.': dotBtn.PerformClick();
                    break;
                case '=': equalBtn.PerformClick();
                    break;
                case (char)13 : equalBtn.PerformClick();
                    break;
            }
        }
    }
}
