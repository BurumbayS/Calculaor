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
        double firstNumber = 0;
        double secondNumber = 0;
        double result = 0;
        string operation = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            operation = "*";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-" + textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            operation = "/";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            operation = "-";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            operation = "+";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            operation = "sqrt";

            firstNumber = double.Parse(textBox1.Text);
            result = Math.Sqrt(firstNumber);
            textBox1.Text = result.ToString();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            operation = "%";
            firstNumber = double.Parse(textBox1.Text);
            textBox1.Text = "";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            secondNumber = double.Parse(textBox1.Text);

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "%":
                    result = firstNumber * secondNumber / 100;
                    break;
            }

            textBox1.Text = result.ToString();
        }
    }
}
