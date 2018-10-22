using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using bus;

namespace QUANLYKHACHSAN1
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        //viết cho nút đăng nhập
        private void button1_Click(object sender, EventArgs e)
        {
            DataSet d = new DataSet();
            loginbus Lgbus = new loginbus();
            d = Lgbus.layDS(textBox1.Text, textBox2.Text);
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Chua nhap day du thong tin");
            else
            {
                if (d.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Dang nhap thanh cong");
                    MenuChinh frmmenuchinh = new MenuChinh();
                    this.Hide();
                    frmmenuchinh.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Dang nhap that bai");
            }

        }


        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
          if (MessageBox.Show("Bạn có thật sự muốn thoát chương trình?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            BanQuyen frmbanquyen = new BanQuyen();
            frmbanquyen.ShowDialog();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            help frmh = new help();
            frmh.ShowDialog();
        }
    }
}
