﻿using System;
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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
           
        }

        private void txtTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            var stt = txtTenHang.SelectedIndex;
            switch(stt)
            {
                case 0:
                    txtDonGia.Text = "100000";
                    break;
                case 1:
                    txtDonGia.Text = "200000";
                    break;
                case 2:
                    txtDonGia.Text = "150000";
                    break;
            }

        }

        private void txtTinhTien_Click(object sender, EventArgs e)
        {
            int DonGia = int.Parse(txtDonGia.Text);
            int SoLuong = int.Parse(txtSoLuong.Text);
            double ThanhTien = DonGia * SoLuong;
            if(rdChuyenKhoan.Checked)
            {
                ThanhTien = DonGia * SoLuong * 0.95;
            }
            lblThanhTien.Text = ThanhTien.ToString();
        }

        private void lblThanhTien_Click(object sender, EventArgs e)
        {
        }
    }
}