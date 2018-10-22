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
    public partial class Nhanvien : Form
    {
        public Nhanvien()
        {
            InitializeComponent();
        }
        ttnhanvien ttnhanv = new ttnhanvien();
        string ma1;

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ttnhanv.ttnv();
            dataGridView1.DataSource = dt;
            this.IbT.Text = "Có tổng số " + dataGridView1.Rows.Count.ToString() + " nhân viên";
        }

        // gắn địa chỉ cho ô textbox để hiển thị thông tin mình muốn
        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            ma1 = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            this.txtma.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            this.txtten.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            this.txtchucvu.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            this.txtsdt.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            this.txtCMND.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            this.cbGT.Text = dataGridView1.Rows[dong].Cells[5].Value.ToString();
            this.dateTimePickerNS.Text = dataGridView1.Rows[dong].Cells[6].Value.ToString();

        }

        // viết cho nút thêm
        private void btn_Them_Click(object sender, EventArgs e)
        {
          
            dateTimePickerNS.CustomFormat = "MM-dd-yyyy";
            dateTimePickerNS.Format = DateTimePickerFormat.Custom;

            if (this.txtma.TextLength == 0)
                MessageBox.Show("Mã Nhân Viên Không Được Bổ Trống");
            else
                if (this.txtma.TextLength >5)
                     MessageBox.Show("Mã Nhân Viên Không Vượt Quá 5");
                 else
                     if (this.txtten.TextLength == 0)
                        MessageBox.Show("Tên Nhân Viên Không Được Bổ Trống");
                      else
                          {
                            try
                                 {
                                   ttnhanv.InsertNV(this.txtma.Text, this.txtten.Text, this.txtchucvu.Text,this.dateTimePickerNS.Text,this.cbGT.Text, this.txtCMND.Text, this.txtsdt.Text);
                                   MessageBox.Show("Đã thêm nhân viên " + this.txtten.Text + " thành công");
                                   Form1_Load(sender, e);
                                 }
                            catch
                                 {
                                   MessageBox.Show("Thêm nhân viên " + this.txtten.Text + " thất bại");
                                 }
                          }
        }

        //viết cho nút nhập lại
        private void btn_nhaplai_Click(object sender, EventArgs e)
        {
            this.txtma.Clear();
            this.txtten.Clear();
            this.txtchucvu.Clear();
            this.txtsdt.Clear();
            this.txtCMND.Clear();
            this.txtma.Focus();
        }

        // viết cho nút sửa
        private void bnt_sua_Click(object sender, EventArgs e)
        {

            dateTimePickerNS.CustomFormat = "MM-dd-yyyy";
            dateTimePickerNS.Format = DateTimePickerFormat.Custom;
            if (this.txtma.TextLength == 0)
                MessageBox.Show("Bạn cần chọn nhân viên cần sửa");
            else
                if (this.txtma.TextLength > 5)
                MessageBox.Show("Mã Nhân Viên Không Vượt Quá 5");
                else
                     if (this.txtten.TextLength == 0)
                    MessageBox.Show("Tên Nhân Viên Không Được Bổ Trống");
                     else
                    {
                    ttnhanv.update(ma1,txtma.Text,txtten.Text,txtchucvu.Text,cbGT.Text,txtsdt.Text,dateTimePickerNS.Text,txtCMND.Text);
                    MessageBox.Show("Đã sửa nhân viên " + this.txtten.Text + " thành công");
                    Form1_Load(sender, e);           
                    }
        }
        // viết cho nút xóa
        private void bnt_xoa_Click(object sender, EventArgs e)
        {
            if (this.txtma.TextLength == 0)
                MessageBox.Show("Bạn cần chọn nhân viên cần xóa");
            else
            if(DialogResult.Yes== MessageBox.Show("Bạn có chắc muốn xóa nhân viên "+txtten.Text+" hay không?","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                ttnhanv.delete(ma1);
                MessageBox.Show("Đã xóa nhân viên " + this.txtten.Text + " thành công");
                Form1_Load(sender, e);
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //viết cho nút tìm kiếm 
        private void btn_tim_Click(object sender, EventArgs e)
        {

            dateTimePickerNS.CustomFormat = "MM-dd-yyyy";
            dateTimePickerNS.Format = DateTimePickerFormat.Custom;
            if (this.txttenmacantim.TextLength == 0)
                MessageBox.Show("Bạn  chưa nhập thông tin cần tìm!!");
            else
            {
                DataTable dt = new DataTable();
                dt = ttnhanv.looking(this.txttenmacantim.Text);
                dataGridView1.DataSource = dt;
                this.IbT.Text = "Có tổng số " + dataGridView1.Rows.Count.ToString() + " nhân viên";
                if (dt.Rows.Count == 0)
                {
                    this.Ibstatus.ForeColor = Color.Red;
                    this.Ibstatus.Text = "Không Tìm Thấy dữ Liệu";
                }
                else
                    this.Ibstatus.ResetText();
            }
        }

        private void txttenmacantim_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        // viết cho nút trở lại
        private void btn_reset_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            this.txttenmacantim.Clear();
            this.Ibstatus.ResetText();
        }

        // viết cho nút thoát
        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
