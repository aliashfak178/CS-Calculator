using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculator_CS
{
    public partial class MainForm : Form
    {
        private decimal fnumber = 0.0m;
        private decimal snumber = 0.0m;
        private string operatorstring = "+";
        private decimal Resultdec = 0.0m;
        public MainForm()
        {
            InitializeComponent();
        }

        private void zero_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(0);
        }

        private void one_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(1);
        }

        private void RemoveZero(int num)
        {
            if (CalcTextBox.Text == "0")
                CalcTextBox.Text = num.ToString();
            else
                CalcTextBox.Text += num.ToString();
        }

        private void two_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(2);
        }

        private void three_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(3);
        }

        private void four_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(4);
        }

        private void five_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(5);
        }

        private void six_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(6);
        }

        private void seven_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(7);
        }

        private void eight_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(8);
        }

        private void nine_Button_Click(object sender, EventArgs e)
        {
            RemoveZero(9);
        }

        private void cancel_Button_Click(object sender, EventArgs e)
        {
            CalcTextBox.Clear();
            CalcTextBox.Text = "0";
            fnumber = 0.0m;
            snumber = 0.0m;
            Resultdec = 0.0m;
        }

        private void dot_Button_Click(object sender, EventArgs e)
        {
            if (!CalcTextBox.Text.Contains("."))
            {
                CalcTextBox.Text += ".";
            }
        }

        private void plus_Button_Click(object sender, EventArgs e)
        {
            SuplayerOperator("+");
        }

        private void SuplayerOperator(string opstring)
        {
            operatorstring = opstring;
            fnumber = decimal.Parse(CalcTextBox.Text);
            CalcTextBox.Text = "0";
        }

        private void min_Button_Click(object sender, EventArgs e)
        {
            SuplayerOperator("-");
        }

        private void div_Button_Click(object sender, EventArgs e)
        {
            SuplayerOperator("/");
        }

        private void mul_Button_Click(object sender, EventArgs e)
        {
            SuplayerOperator("*");
        }

        private void equal_Button_Click(object sender, EventArgs e)
        {
            snumber = decimal.Parse( CalcTextBox.Text);
            switch (operatorstring)
            {
                case "+":
                    Resultdec = fnumber + snumber;
                    break;
                case "-":
                    Resultdec = fnumber - snumber;
                    break;
                case "*":
                    Resultdec = fnumber * snumber;
                    break;
                case "/":
                    Resultdec = fnumber / snumber;
                    break;
                case "%":
                    Resultdec = fnumber % snumber;
                    break;
            }
            CalcTextBox.Text = Resultdec.ToString();
        }

        private void plusminus_Button_Click(object sender, EventArgs e)
        {
            if (!CalcTextBox.Text.Contains("-"))
            {
                CalcTextBox.Text = "-" + CalcTextBox.Text;
            }
            else
            {
                CalcTextBox.Text = CalcTextBox.Text.Trim('-');
            }
        }

        private void modu_Button_Click(object sender, EventArgs e)
        {
            SuplayerOperator("%");
        }
    }
}
