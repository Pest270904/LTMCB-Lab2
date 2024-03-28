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

        }

        private void bt_mo_file_output_Click(object sender, EventArgs e)
        {

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
