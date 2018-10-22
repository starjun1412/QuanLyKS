using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUANLYKHACHSAN1
{
    public partial class Hethong : Form
    {
        public Hethong()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Nhanvien frmnhanvien = new Nhanvien();
            frmnhanvien.ShowDialog();
        }

        private void Hethong_Load(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DatPhong frmdatphong = new DatPhong();
            frmdatphong.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DanhsachKhach frmdanhsach = new DanhsachKhach();
            frmdanhsach.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NhanPhong frmnhanphong = new NhanPhong();
            frmnhanphong.Show();
        }
    }
}
