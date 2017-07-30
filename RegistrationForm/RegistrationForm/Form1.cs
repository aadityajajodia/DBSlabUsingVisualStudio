using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        String error = "";

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("CS");
            comboBox1.Items.Add("CC");
            comboBox1.Items.Add("IT");
            comboBox1.Items.Add("CIVIL");
            comboBox1.Items.Add("MECHANICAL");
            comboBox1.Items.Add("BIOTECH");
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            error = "";
            if (textBox1.Text == "")
                error += "enter your name\n";
            if (textBox2.Text == "")
                error += "enter your email address\n";
            if (textBox3.Text == "")
                error += "enter your mobile number\n";
            if (radioButton1.Checked == false && radioButton2.Checked == false)
                error += "enter your gender\n";
            if (comboBox1.Text == "")
                error += "enter your branch\n";
            if (monthCalendar1.SelectionRange.Start.ToString() == monthCalendar1.TodayDate.ToString())
                error += "enter DOB\n";
            if (checkBox1.Checked == false)
                error += ("please acccept terms and conditions to proceed");

            if (error == "")
            {
                if(textBox1.Text.Contains('@'))
                    error+="invalid name\n";
                if (!(textBox2.Text.Contains('@') && textBox2.Text.Contains('.')))
                    error += "invalid email";
                if (textBox3.Text.Length != 10)
                    error += "invalid mobile number";

                

            }
            if (error != "")
                MessageBox.Show(error);
            else
            {
                MessageBox.Show("Registration Complete");

            }
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
