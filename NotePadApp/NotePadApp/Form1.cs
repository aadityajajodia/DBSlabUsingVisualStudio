using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePadApp
{
    public partial class Form1 : Form
    {
        int savedflag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Open";
            dlg.ShowDialog();
            string fName = dlg.FileName;
            if (fName != "")
            {
                StreamReader sr = new StreamReader(fName);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.ShowDialog();
            string fName = saveFileDialog1.FileName;
            if (fName != "")
            {

                StreamWriter sw = new StreamWriter(fName);
                sw.Write(richTextBox1.Text);
                sw.Flush();
                sw.Close();
                savedflag = 1;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            savedflag = 0;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savedflag == 1)
            {
                richTextBox1.Text = "";
            }
            else
            {
                MessageBox.Show("Save Your File");
            }

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            pd.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (savedflag == 1)
            {

                DialogResult result = MessageBox.Show("EXIT", "EXIT", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Save your file");
            }

        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
            {
                Clipboard.SetData(DataFormats.Text, richTextBox1.SelectedText);
                richTextBox1.SelectedText="";
            }


        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText!="")
            {
                Clipboard.SetData(DataFormats.Text, richTextBox1.SelectedText);
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            String data=Clipboard.GetData(DataFormats.Text).ToString();
            int position = richTextBox1.SelectionStart;
            richTextBox1.Text=richTextBox1.Text.Insert(position, data);

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("You are using version 1.0 of Jajodia NotePad\nPlease bear with us for all the bugs\nWe wont be fixing it any time soon :)");
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.Font = fd.Font;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() != DialogResult.Cancel)
            {
                richTextBox1.ForeColor = cd.Color;
            }
        }
    }
}
