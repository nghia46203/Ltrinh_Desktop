using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bt_2
{
    public partial class Bai_3 : Form
    {
        List<string> list = new List<string>();
        public Bai_3()
        {
            InitializeComponent();
        }

        private void ThemTu_Click(object sender, EventArgs e)
        {
            var tu = TuMoi.Text;
            var nghia = NghiaCuaTu.Text;
            listBox1.Items.Add(tu);
            list.Add(nghia);
        }

        private void txtHienThiNghia_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var stt = listBox1.SelectedIndex;
            txtHienThiNghia.Text = list[stt];
        }
    }
}
