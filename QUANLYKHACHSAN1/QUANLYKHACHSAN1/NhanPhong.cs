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
    public partial class NhanPhong : Form
    {
        public NhanPhong()
        {
            InitializeComponent();
        }
        datphong ttkh = new datphong();
        string mak;
        private void NhanPhong_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ttkh.checkinHKN();
            dataGridView1.DataSource = dt;
            this.lbT.Text = "Có tổng số " + dataGridView1.Rows.Count.ToString() + " khách hàng";

        }
        // gắn địa chỉ cho ô textbox để hiển thị thông tin mình muốn
        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            int dong;
            dong = e.RowIndex;
            mak = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            this.txtmaKH.Text = dataGridView1.Rows[dong].Cells[0].Value.ToString();
            this.txtten.Text = dataGridView1.Rows[dong].Cells[1].Value.ToString();
            this.txtdiachi.Text = dataGridView1.Rows[dong].Cells[2].Value.ToString();
            this.txtsdt.Text = dataGridView1.Rows[dong].Cells[3].Value.ToString();
            this.txtcmnd.Text = dataGridView1.Rows[dong].Cells[4].Value.ToString();
            this.txtGT.Text = dataGridView1.Rows[dong].Cells[5].Value.ToString();
            this.dateTimePickerD.Text = dataGridView1.Rows[dong].Cells[6].Value.ToString();
            this.dateTimePickerT.Text = dataGridView1.Rows[dong].Cells[7].Value.ToString();
            this.dateTimePickerNS.Text = dataGridView1.Rows[dong].Cells[8].Value.ToString();
            this.cbcheck.Text = dataGridView1.Rows[dong].Cells[9].Value.ToString();
        }
        //viết cho nút thêm khách
        private void btn_themK_Click(object sender, EventArgs e)
        {
            dateTimePickerD.CustomFormat = "MM-dd-yyyy";
            dateTimePickerD.Format = DateTimePickerFormat.Custom;

            dateTimePickerT.CustomFormat = "MM-dd-yyyy";
            dateTimePickerT.Format = DateTimePickerFormat.Custom;

            dateTimePickerNS.CustomFormat = "MM-dd-yyyy";
            dateTimePickerNS.Format = DateTimePickerFormat.Custom;

            if (this.txtmaKH.TextLength == 0)
                MessageBox.Show("Bạn cần chọn khách hàng cần sửa");
            else
                if (this.txtmaKH.TextLength == 0)
                MessageBox.Show("Mã Khách Hàng Không Được Bổ Trống");
            else
               if (this.txtten.TextLength == 0)
                MessageBox.Show("Tên Khách Hàng Không Được Bổ Trống");
            else
                    if (this.txtsdt.TextLength == 0)
                MessageBox.Show("SĐT Không Được Bổ Trống");
            else
            {
                ttkh.updatekh(mak, txtmaKH.Text, txtten.Text, txtdiachi.Text, txtcmnd.Text, txtsdt.Text, txtGT.Text, dateTimePickerD.Text, dateTimePickerT.Text, dateTimePickerNS.Text, cbcheck.Text);
                MessageBox.Show("Đã sửa khách " + this.txtten.Text + " thành công");
                NhanPhong_Load(sender, e);
            }
        }

        //viết nút hủy phòng
        private void btn_huy_Click(object sender, EventArgs e)
        {
            if (this.txtmaKH.TextLength == 0)
                MessageBox.Show("Bạn cần chọn khách hàng cần xóa");
            else
         if (DialogResult.Yes == MessageBox.Show("Bạn có chắc muốn hủy đặt phòng của khách " + txtten.Text + " hay không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                ttkh.deleteKH(mak);
                MessageBox.Show("Đã hủy đặt phòng của khách " + this.txtten.Text + " thành công");
                NhanPhong_Load(sender, e);
            }

        }
        //viết cho nút tìm kiếm
        private void btn_tim_Click(object sender, EventArgs e)
        {
            dateTimePickerD.CustomFormat = "MM-dd-yyyy";
            dateTimePickerD.Format = DateTimePickerFormat.Custom;

            dateTimePickerT.CustomFormat = "MM-dd-yyyy";
            dateTimePickerT.Format = DateTimePickerFormat.Custom;


            if (this.txtmakhcantim.TextLength == 0)
                MessageBox.Show("Bạn  chưa nhập thông tin cần tìm!!");
            else
            {
                DataTable dt = new DataTable();
                dt = ttkh.lookingHK(this.txtmakhcantim.Text);
                dataGridView1.DataSource = dt;
                this.Lbtb.Text = "Có tổng số " + dataGridView1.Rows.Count.ToString() + " nhân viên";
                if (dt.Rows.Count == 0)
                {
                    this.Lbtb.ForeColor = Color.Red;
                    this.Lbtb.Text = "Không Tìm Thấy dữ Liệu";
                }
                else
                    this.Lbtb.ResetText();
            }
        }

        private void btn_tl_Click(object sender, EventArgs e)
        {
            NhanPhong_Load(sender, e);
            this.txtmakhcantim.Clear();
            this.Lbtb.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Click(object sender, EventArgs e)
        {
            NhanPhong_Load(sender, e);
            this.txtmakhcantim.Clear();
            this.Lbtb.ResetText();
        }
    }
}
