using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string option;
        int firstNumber;
        int secondNumber;
        int result;


        private void button1_Click_1(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button9.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            CalcDisplay.Text = CalcDisplay.Text + button0.Text;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            option = "+";
            firstNumber = int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }

        private void SubButton_Click(object sender, EventArgs e)
        {
            option = "-";
            firstNumber = int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }

        private void MulButton_Click(object sender, EventArgs e)
        {
            option = "*";
            firstNumber = int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }

        private void DivButton_Click(object sender, EventArgs e)
        {
            option = "/";
            firstNumber = int.Parse(CalcDisplay.Text);
            CalcDisplay.Clear();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            secondNumber = int.Parse(CalcDisplay.Text);
            if (option.Equals("+"))
                result = firstNumber + secondNumber;
            if (option.Equals("-"))
                result = firstNumber - secondNumber;
            if (option.Equals("*"))
                result = firstNumber * secondNumber;
            if (option.Equals("/"))
                result = firstNumber / secondNumber;

            CalcDisplay.Text = result + "";
           // CalcDisplay.Clear();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CalcDisplay.Clear();//\reusbbhh
            result = (0);
            firstNumber = (0);
            secondNumber = (0);
        }
    }
}
