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
    public partial class frmBai_3 : Form
    {
        public frmBai_3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void rdTongAvàB_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btKetQua_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text);
            int b = int.Parse(txtB.Text);
            int n = int.Parse(txtN.Text);
            int  kq = 0;
            if (rdTongAvàB.Checked)
                TinhToan.CongHaiSo(a, b, ref kq);
            else
            TinhToan.TongCacDaySo(n);

            lblKetQua.Text = kq.ToString();
        }
    }
}
