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
    public partial class Form2 : Form 
    {
        public Form2()
        {
            InitializeComponent();
            label1.Text = "Hello " + Form1.username + "your balance is" + Form1.balance +
                "\n\nYour last five transactions" +
                "\n1." + Form1.trans[0, 0] + Form1.trans[0, 1] +
                "\n2." + Form1.trans[1, 0] + Form1.trans[1, 1] +
                "\n3." + Form1.trans[2, 0] + Form1.trans[2, 1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 frm3 = new Form3();
            if(frm3.ShowDialog()==DialogResult.Cancel)
                label1.Text = "Hello " + Form1.username + " your balance is" + Form1.balance +
                "\n\nYour last five transactions" +
                "\n1." + Form1.trans[0, 0] + "\t" + Form1.trans[0, 1] +
                "\n2." + Form1.trans[1, 0] + "\t" + Form1.trans[1, 1] +
                "\n3." + Form1.trans[2, 0] + "\t" + Form1.trans[2, 1];

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("enter new password");
            else
            {
                Form1.password = textBox1.Text;
                MessageBox.Show("password changed Successfully");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
