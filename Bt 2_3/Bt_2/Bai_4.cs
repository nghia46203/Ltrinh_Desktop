using System;
using System.Windows.Forms;

namespace Bt_2
{
    public partial class Bai_4 : Form
    {

        public Bai_4()
        {
            InitializeComponent();
        }

        private void Bai_4_Load(object sender, EventArgs e)
        {
            int so;
            Random rand = new Random();
            for (int i = 0; i < 10; i++)
            {
                so = rand.Next(1, 100);
                listBox1.Items.Add(so);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int soCanTim = int.Parse(txtSo.Text);
            lblKetQua.Text = "Không tìm thấy";
            foreach (int so in listBox1.Items)
            {
                if (soCanTim == so)
                {
                    lblKetQua.Text = "Tìm thấy";
                    break;
                }
            }
        }
    }
}
