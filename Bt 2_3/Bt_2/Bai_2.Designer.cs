namespace Bt_2
{
    partial class Bai_2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ChonHang = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTinhTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TinhTien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BoHang = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ChonHang);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(28, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(358, 253);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Danh sách hàng hóa:";
            // 
            // ChonHang
            // 
            this.ChonHang.Location = new System.Drawing.Point(223, 114);
            this.ChonHang.Name = "ChonHang";
            this.ChonHang.Size = new System.Drawing.Size(103, 23);
            this.ChonHang.TabIndex = 1;
            this.ChonHang.Text = "Chọn Hàng  >";
            this.ChonHang.UseVisualStyleBackColor = true;
            this.ChonHang.Click += new System.EventHandler(this.ChonHang_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn Phím",
            "Máy In",
            "USB Kingmax"});
            this.listBox1.Location = new System.Drawing.Point(51, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 116);
            this.listBox1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTinhTien);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.TinhTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.BoHang);
            this.panel2.Controls.Add(this.listBox2);
            this.panel2.Location = new System.Drawing.Point(408, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 253);
            this.panel2.TabIndex = 1;
            // 
            // lblTinhTien
            // 
            this.lblTinhTien.AutoSize = true;
            this.lblTinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTinhTien.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTinhTien.Location = new System.Drawing.Point(239, 219);
            this.lblTinhTien.Name = "lblTinhTien";
            this.lblTinhTien.Size = new System.Drawing.Size(19, 20);
            this.lblTinhTien.TabIndex = 4;
            this.lblTinhTien.Text = "0";
            this.lblTinhTien.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng tiền thanh toán:";
            // 
            // TinhTien
            // 
            this.TinhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TinhTien.Location = new System.Drawing.Point(202, 187);
            this.TinhTien.Name = "TinhTien";
            this.TinhTien.Size = new System.Drawing.Size(103, 23);
            this.TinhTien.TabIndex = 4;
            this.TinhTien.Text = "Tính tiền";
            this.TinhTien.UseVisualStyleBackColor = true;
            this.TinhTien.Click += new System.EventHandler(this.TinhTien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Các mặt hàng khách mua:";
            // 
            // BoHang
            // 
            this.BoHang.Location = new System.Drawing.Point(40, 114);
            this.BoHang.Name = "BoHang";
            this.BoHang.Size = new System.Drawing.Size(103, 23);
            this.BoHang.TabIndex = 3;
            this.BoHang.Text = "<  Bỏ hàng";
            this.BoHang.UseVisualStyleBackColor = true;
            this.BoHang.Click += new System.EventHandler(this.BoHang_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Items.AddRange(new object[] {
            "Chuột",
            "USB Kingmax",
            "USB Kingmax"});
            this.listBox2.Location = new System.Drawing.Point(172, 55);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(150, 116);
            this.listBox2.TabIndex = 3;
            // 
            // Bai_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Bai_2";
            this.Text = "Bán Hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ChonHang;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTinhTien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button TinhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BoHang;
        private System.Windows.Forms.ListBox listBox2;
    }
}