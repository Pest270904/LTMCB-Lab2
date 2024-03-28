using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    [Serializable]
    public class Student
    {
        public string MSSV { get; set; }
        public string HoTen { get; set; }
        public string SDT { get; set; }
        public float DToan { get; set; }
        public float DVan { get; set; }
        public float DTB;
        public void SetSt(string mssv, string ht, string dt, float dToan, float dVan)
        {
            MSSV = mssv;
            HoTen = ht;
            SDT = dt;
            DToan = dToan;
            DVan = dVan;
        }
        public string GetSt()
        {
            string content = "";
            content = MSSV + "\n" + HoTen + "\n" + SDT + "\n" + DToan.ToString() + "\n" + DVan.ToString() + "\n";
            if (DTB.ToString() != null)
            {
                content += ((float)DTB).ToString();
            }
            content += "\n";
            return content;
        }
        public float Tinh()
        {
            DTB = (DToan + DVan) / 2;
            return DTB;
        }
    }
}
