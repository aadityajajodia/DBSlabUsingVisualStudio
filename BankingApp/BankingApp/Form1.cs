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
   
    public partial class Form1 : Form
    {
        public static String username = "aditya";
        public static String password = "aditya";
        public static String lastAccess = DateTime.Now.ToString();
        public static double balance = 5000;
        public static string[,] trans=new string[5,2];
        
       
        public Form1()
        {
            InitializeComponent();
            trans[0, 0] = "Aditya";
            trans[0, 1] = "500";
            trans[1, 0] = "Pranjal";
            trans[1, 1] = "600";
            trans[2, 0] = "Manish";
            trans[2, 1] = "70";
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text==username&&textBox2.Text==password)
            {
                lastAccess = DateTime.Now.ToString();
                MessageBox.Show("Hello");
                Form2 frm2 =new Form2();
                frm2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }

        }
    }
}
