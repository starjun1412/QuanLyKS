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
    public partial class MenuChinh : Form
    {
        public MenuChinh()
        {
            InitializeComponent();
        }

        private void btn_hethong_Click(object sender, EventArgs e)
        {
            Hethong frmhethong = new Hethong();
            this.Hide();
            frmhethong.ShowDialog();
            this.Show();

        }

        private void MenuChinh_Load(object sender, EventArgs e)
        {

        }

        private void btn_DSP_Click(object sender, EventArgs e)
        {
            DSPhong frmdsp = new DSPhong();
            this.Hide();
            frmdsp.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ThanhToan frmthanhtoan = new ThanhToan();
            frmthanhtoan.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TÍNH NĂNG SẮP ĐƯỢC CẬP NHẬP", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("TÍNH NĂNG SẮP ĐƯỢC CẬP NHẬP", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
