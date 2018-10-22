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
    }
}
