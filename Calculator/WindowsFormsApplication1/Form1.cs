using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double operand1=0;
        double operand2=0;
        double result = 0;
        String temp = "";
        char myOperator = '+';
        


        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "tan";
            myOperator = 't';
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            temp += "0";
            resultTextBox.Text += "0";

        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            temp += "2";
            resultTextBox.Text += "2";
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            temp += "6";
            resultTextBox.Text += "6";

        }

        private void sinButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "sin";
            myOperator = 's';
        }

        private void cosButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "cos";
            myOperator = '-';
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(temp);
            resultTextBox.Text += "/";
            temp = "";
            myOperator = '/';

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(temp);
            resultTextBox.Text += "*";
            temp = "";
            myOperator = '*';
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(temp);
            resultTextBox.Text += "-";
            temp = "";
            myOperator = '-';
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(temp);
            resultTextBox.Text += "+";
            temp = "";
            myOperator = '+';
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            int flag = 0;
            operand2 =Convert.ToDouble(temp) ;
            switch (myOperator)
            {
                case '+':
                    result = operand1 + operand2;
                    break;
                case '-':
                    result = operand1 - operand2;
                    break;
                case '*':
                    result = operand1 * operand2;
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        resultTextBox.Text = "Cannot divide by zero";
                        flag = 1;

                    }
                    else
                    {
                        result = operand1 / operand2;
                    }
                    break;
                case 's':
                    result = Math.Sin(operand2);
                    break;
                case 'c':
                    result = Math.Cos(operand2);
                    break;
                case 't':
                    result = Math.Tan(operand2);
                    break;
                case 'l':
                    result = Math.Log(operand2);
                    break;
                
                default:
                    break;
                    
            }
            if(flag==0)
                resultTextBox.Text = result.ToString();
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            temp += "1";
            resultTextBox.Text += "1";
        }

        private void threeButton_Click(object sender, EventArgs e)
        {

            temp += "3";
            resultTextBox.Text += "3";
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            temp += "4";
            resultTextBox.Text += "4";
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            temp += "5";
            resultTextBox.Text += "5";
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            temp += "7";
            resultTextBox.Text += "7";
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            temp += "8";
            resultTextBox.Text += "8";
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            temp += "9";
            resultTextBox.Text += "9";
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            temp += ".";
            resultTextBox.Text += ".";
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "";
            temp = "";
        }

        private void logButton_Click(object sender, EventArgs e)
        {
            resultTextBox.Text= "log";
            myOperator = 'l';
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
