using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace Lab2
{
    public partial class Bai_04 : Form
    {
        public Bai_04()
        {
            InitializeComponent();
        }
        List<Student> students = new List<Student>();

        private void bt_addsv_Click(object sender, EventArgs e)
        {
            Student sinhvien = new Student
            {
                MSSV = tb_mssv.Text,
                HoTen = tb_hoten.Text,
                SDT = tb_sdt.Text,
                DToan = float.Parse(tb_diemtoan.Text),
                DVan = float.Parse(tb_diemvan.Text)
            };
            students.Add(sinhvien);
            LoadData();
            try
            {
                sinhvien.SetSt(tb_mssv.Text, tb_hoten.Text, tb_sdt.Text, float.Parse(tb_diemtoan.Text.Trim()), float.Parse(tb_diemvan.Text.Trim()));
                students.Add(sinhvien);
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fs = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, students);
                fs.Close();
                MessageBox.Show("Học viên đã được lưu vào file input.txt. Nhấn button Tính ĐTB để tính ĐTB");
            }
            catch 
            {
                MessageBox.Show("Wrong path");
            }
        }
        private void LoadData()
        {
            listView1.Items.Clear();
            foreach (Student student in students)
            {
                ListViewItem item = new ListViewItem(student.MSSV);
                item.SubItems.Add(student.HoTen);
                item.SubItems.Add(student.SDT);
                item.SubItems.Add(student.DToan.ToString());
                item.SubItems.Add(student.DVan.ToString());
                listView1.Items.Add(item);
            }
        }

        private void bt_tinhdtb_Click(object sender, EventArgs e)
        {
            FileStream fi = null;
            try
            {
                foreach (Student St in students)
                {
                    St.Tinh();
                }
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();

                fi = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bi = new BinaryFormatter();
                bi.Serialize(fi, students);
                fi.Close();
                MessageBox.Show("ĐTB đã được lưu vào file output.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_mo_file_output_Click(object sender, EventArgs e)
        {
           richTextBox1.Clear();
            
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.ShowDialog();
                FileStream fi = new FileStream(ofd.FileName, FileMode.Open);
                BinaryFormatter bi = new BinaryFormatter();
                List<Student> list = new List<Student>();
                list = (List<Student>)bi.Deserialize(fi);
                for (int i = 0; i < list.Count - 1; i++)
                {
                    richTextBox1.Text += list[i].GetSt().ToString() + "\n";
                }
            }
            catch 
            {
                MessageBox.Show("Co loi xay ra ");
            }
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {

        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
