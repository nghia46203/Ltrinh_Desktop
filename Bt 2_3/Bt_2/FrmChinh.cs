using System;
using System.Windows.Forms;

namespace Bt_2
{
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Bai_1();
            form.ShowDialog();
        }

        private void Bai2_Click(object sender, EventArgs e)
        {
            var form = new Bai_2();
            form.ShowDialog();
        }

        private void Bai3_Click(object sender, EventArgs e)
        {
            var form = new Bai_3();
            form.ShowDialog();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Bai_4();
            form.ShowDialog();
        }
    }
}
