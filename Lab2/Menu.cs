using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_Bai1_Click(object sender, EventArgs e)
        {
            Bai_01 a = new Bai_01();
            a.ShowDialog();
        }

        private void btn_Bai2_Click(object sender, EventArgs e)
        {
            Bai_02 a = new Bai_02();
            a.ShowDialog();
        }

        private void btn_Bai3_Click(object sender, EventArgs e)
        {
            Bai_03 a = new Bai_03();
            a.ShowDialog();
        }

        private void btn_Bai4_Click(object sender, EventArgs e)
        {
            Bai_04 a = new Bai_04();
            a.ShowDialog();
        }

        private void btn_Bai5_Click(object sender, EventArgs e)
        {
            Bai_01 a = new Bai_01();
            a.ShowDialog();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
