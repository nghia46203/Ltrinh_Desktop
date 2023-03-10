namespace Bt_2
{
    partial class FrmChinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChinh));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lêHàHiếuNghĩaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai1 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai2 = new System.Windows.Forms.ToolStripMenuItem();
            this.Bai3 = new System.Windows.Forms.ToolStripMenuItem();
            this.bài4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lêHàHiếuNghĩaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lêHàHiếuNghĩaToolStripMenuItem
            // 
            this.lêHàHiếuNghĩaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Bai1,
            this.Bai2,
            this.Bai3,
            this.bài4ToolStripMenuItem});
            this.lêHàHiếuNghĩaToolStripMenuItem.Name = "lêHàHiếuNghĩaToolStripMenuItem";
            this.lêHàHiếuNghĩaToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.lêHàHiếuNghĩaToolStripMenuItem.Text = "Lê Hà Hiếu Nghĩa";
            // 
            // Bai1
            // 
            this.Bai1.Image = ((System.Drawing.Image)(resources.GetObject("Bai1.Image")));
            this.Bai1.Name = "Bai1";
            this.Bai1.Size = new System.Drawing.Size(224, 26);
            this.Bai1.Text = "Bài_1";
            this.Bai1.Click += new System.EventHandler(this.bài1ToolStripMenuItem_Click);
            // 
            // Bai2
            // 
            this.Bai2.Image = ((System.Drawing.Image)(resources.GetObject("Bai2.Image")));
            this.Bai2.Name = "Bai2";
            this.Bai2.Size = new System.Drawing.Size(224, 26);
            this.Bai2.Text = "Bài_2";
            this.Bai2.Click += new System.EventHandler(this.Bai2_Click);
            // 
            // Bai3
            // 
            this.Bai3.Image = ((System.Drawing.Image)(resources.GetObject("Bai3.Image")));
            this.Bai3.Name = "Bai3";
            this.Bai3.Size = new System.Drawing.Size(224, 26);
            this.Bai3.Text = "Bài_3";
            this.Bai3.Click += new System.EventHandler(this.Bai3_Click);
            // 
            // bài4ToolStripMenuItem
            // 
            this.bài4ToolStripMenuItem.Name = "bài4ToolStripMenuItem";
            this.bài4ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bài4ToolStripMenuItem.Text = "Bài_4";
            this.bài4ToolStripMenuItem.Click += new System.EventHandler(this.bài4ToolStripMenuItem_Click);
            // 
            // FrmChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmChinh";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lêHàHiếuNghĩaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Bai1;
        private System.Windows.Forms.ToolStripMenuItem Bai2;
        private System.Windows.Forms.ToolStripMenuItem Bai3;
        private System.Windows.Forms.ToolStripMenuItem bài4ToolStripMenuItem;
    }
}

