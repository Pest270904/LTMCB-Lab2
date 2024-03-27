using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Bai_03 : Form
    {
        public Bai_03()
        {
            InitializeComponent();
        }

        private void btn_Read_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream fs = new FileStream("..\\..\\..\\Text\\input_3.txt", FileMode.OpenOrCreate);
                StreamReader sr = new StreamReader(fs);

                string content = sr.ReadToEnd();
                ReadRTB.Text = content;
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Calc_Click(object sender, EventArgs e)
        {
            OutputRTB.Clear();
            File.WriteAllText("..\\..\\..\\Text\\output_3.txt", string.Empty);

            if (String.IsNullOrEmpty(ReadRTB.Text))
                MessageBox.Show("Can't find anything to calculate");
            else
                try {
                    FileStream fws = new FileStream("..\\..\\..\\Text\\output_3.txt", FileMode.OpenOrCreate);

                    using (StreamWriter sw = new StreamWriter(fws, Encoding.UTF8))
                    {
                        string[] str = ReadRTB.Text.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None);
                        foreach (var str2 in str)
                        {
                            if(str2.Contains("//") || string.IsNullOrEmpty(str2))
                                sw.WriteLine(str2);
                            else
                                sw.WriteLine(calc(str2));
                        }
                    }
                    fws.Close();

                    FileStream frs = new FileStream("..\\..\\..\\Text\\output_3.txt", FileMode.OpenOrCreate);
                    StreamReader sr = new StreamReader(frs);

                    string content = sr.ReadToEnd();
                    OutputRTB.Text = content;
                    frs.Close();
                }
                catch (Exception ex) { 
                    MessageBox.Show(ex.Message); 
                }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            ReadRTB.Clear();
            OutputRTB.Clear();
        }

        private string calc(string expression)
        {
            try {
                string temp = expression;
                temp = temp.Replace(',', '.');
                temp = temp.Replace(" ", string.Empty);
                temp = temp.Replace("--", "+");
                temp = temp.Replace("+-", "-");

                // Change format of expression for negative number
                if (temp[0] == '-')
                    temp = "~" + temp.Remove(0, 1);
                temp = temp.Replace("*-", "*~");
                temp = temp.Replace("/-", "/~");

                // Array of numbers
                string[] number = temp.Split(new char[] {'+', '-', '*', '/'});
                
                // Array of signs in expression
                List<string> listSigns = new List<string>();
                foreach (char c in temp)
                    if (c == '+' || c == '-' || c == '*' || c == '/')
                        listSigns.Add(c.ToString());
                string[] signs = listSigns.ToArray();

                // declare variables
                int sign_length = signs.Length, i = -1;
                double res = 0;

                foreach (string num in number) {
                    int negative = num[0] == '~' ? -1 : 1;
                    if (i == -1){
                        res = Convert.ToDouble(num.Replace('~', '0')) * negative;
                        i++;
                        continue;
                    }
                    if (i < sign_length) {
                        switch (signs[i]) {
                            case "+":
                                res += Convert.ToDouble(num.Replace('~', '0')) * negative;
                                break;
                            case "-":
                                res -= Convert.ToDouble(num.Replace('~', '0')) * negative;
                                break;
                            case "*":
                                res *= Convert.ToDouble(num.Replace('~', '0')) * negative;
                                break;
                            case "/":
                                if (Convert.ToDouble(num.Replace('~', '0')) == 0)
                                    return "Can't calculate this expression...";
                                res /= Convert.ToDouble(num.Replace('~', '0')) * negative;
                                break;
                        }
                        i++;
                    }
                }

                return expression + " = " + Convert.ToString(res);
            }
            catch {
                return "Can't calculate this expression...";
            }    
        }
    }
}
