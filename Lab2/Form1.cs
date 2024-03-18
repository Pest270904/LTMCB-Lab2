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

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                richTextBox1.Text = content;
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Wrong path");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.ShowDialog();
                FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate);
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(richTextBox1.Text.ToUpper().Trim());
                }
                fs.Close();
            }
            catch
            {
                MessageBox.Show("Wrong path");
            }
        }
    }
}
