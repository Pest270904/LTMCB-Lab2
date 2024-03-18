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
    public partial class Bai_02 : Form
    {
        public Bai_02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            FileStream fs = new FileStream(ofd.FileName, FileMode.OpenOrCreate);
            StreamReader sr = new StreamReader(fs);
            string content = sr.ReadToEnd();
            rtbShow.Text = content;
            fs.Close();
            // Name
            string name = ofd.SafeFileName;
            tbName_File.Text= name;
            // Url
            string url = fs.Name;
            tbUrl.Text = url;
            // Lenght
            int charCount = content.Length;
            tbChar.Text = charCount.ToString();
            // Count Line
            fs = new FileStream(ofd.FileName, FileMode.Open);
            sr = new StreamReader (fs);
            int dem = 0;
            string line;
            while((line = sr.ReadLine()) != null)
            {
                if(!string.IsNullOrEmpty(line))
                {
                    dem++;
                }
            }
            tbLine.Text = dem.ToString();
            // Count Char
            string[] source = content.Split(new char[] {'.','?','!',' ',';',':',',', '\n','\t','\r'}, StringSplitOptions.RemoveEmptyEntries);
            tbTu.Text = source.Count().ToString();

        }
    }
}
