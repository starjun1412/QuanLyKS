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
                MessageBox.Show("Chưa nhập đày đủ thông tin!!");
            else
            {
                if (d.Tables[0].Rows.Count > 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    MenuChinh frmmenuchinh = new MenuChinh();
                    this.Hide();
                    frmmenuchinh.ShowDialog();
                    this.Show();
                    this.textBox1.Clear();
                    this.textBox2.Clear();
                    this.textBox1.Focus();
                }
                else
                    MessageBox.Show("Kiểm tra lại tài khoản và mật khẩu!!");
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = !textBox2.UseSystemPasswordChar;
        }
    }
}
