using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Enter Name");

            }
            else if(textBox2.Text=="")
            {
                MessageBox.Show("Enter amount");
            }
            else if (double.Parse(textBox2.Text) > Form1.balance)
            {
                MessageBox.Show("Insufficient fund");
            }
            else
            {
                Form1.balance -= double.Parse(textBox2.Text);
                Form1.trans[0, 0] = textBox1.Text;
                Form1.trans[0, 1] = textBox2.Text;
                MessageBox.Show("Amount transferred is " + textBox2.Text + "\n Your new balance is " + Form1.balance);


            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
