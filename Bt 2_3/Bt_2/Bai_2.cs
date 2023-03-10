using System;
using System.Windows.Forms;

namespace Bt_2
{
    public partial class Bai_2 : Form
    {
        public Bai_2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ChonHang_Click(object sender, EventArgs e)
        {
            var item = listBox1.SelectedItem;
            listBox2.Items.Add(item);
        }

        private void BoHang_Click(object sender, EventArgs e)
        {
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void TinhTien_Click(object sender, EventArgs e)
        {
            int soTien = 0;

            foreach (string hang in listBox2.Items)
            {
                switch (hang)
                {
                    case "Chuột":
                        soTien += 100000;
                        break;
                    case "Bàn Phím":
                        soTien += 140000;
                        break;
                    case "Máy In":
                        soTien += 150000;
                        break;
                    case "USB Kingmax":
                        soTien += 200000;
                        break;
                    default:
                        break;

                }
                lblTinhTien.Text = soTien + " đồng";
            }
        }
    }
}
