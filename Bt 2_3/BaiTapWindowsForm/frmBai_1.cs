using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBai_1 : Form
    {
        public frmBai_1()
        {
            InitializeComponent();
        }

        private void frmBai_1_Load(object sender, EventArgs e)
        {
            HangHoa hh = new HangHoa();
            hh.MaHang = "HH01";
            hh.TenHang = "Chuột";
            hh.DVT = "Cái";
            hh.SoLuong = 4;
            hh.DonGia = 200000;
            lblThongBao.Text = hh.HienThi();
        }

        private void lblThongBao_Click(object sender, EventArgs e)
        {

        }
    }
}
