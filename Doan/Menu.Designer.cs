namespace Doan
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_danhgia = new System.Windows.Forms.Button();
            this.btn_hopdong = new System.Windows.Forms.Button();
            this.btn_datxe = new System.Windows.Forms.Button();
            this.btn_dongxe = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_body.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel_body.Controls.Add(this.pictureBox2);
            this.panel_body.Controls.Add(this.panel1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(200, 0);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1159, 696);
            this.panel_body.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.lbl_tieude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1159, 88);
            this.panel1.TabIndex = 0;
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 23.7913F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(449, 22);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(181, 43);
            this.lbl_tieude.TabIndex = 0;
            this.lbl_tieude.Text = "Trang Chủ";
            // 
            // panel_left
            // 
            this.panel_left.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel_left.Controls.Add(this.btn_danhgia);
            this.panel_left.Controls.Add(this.btn_hopdong);
            this.panel_left.Controls.Add(this.btn_datxe);
            this.panel_left.Controls.Add(this.btn_dongxe);
            this.panel_left.Controls.Add(this.btn_timkiem);
            this.panel_left.Controls.Add(this.pictureBox1);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(200, 696);
            this.panel_left.TabIndex = 3;
            // 
            // btn_danhgia
            // 
            this.btn_danhgia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_danhgia.Font = new System.Drawing.Font("Times New Roman", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_danhgia.Location = new System.Drawing.Point(0, 594);
            this.btn_danhgia.Name = "btn_danhgia";
            this.btn_danhgia.Size = new System.Drawing.Size(200, 100);
            this.btn_danhgia.TabIndex = 8;
            this.btn_danhgia.Text = "Khách Hàng";
            this.btn_danhgia.UseVisualStyleBackColor = true;
            this.btn_danhgia.Click += new System.EventHandler(this.btn_danhgia_Click);
            // 
            // btn_hopdong
            // 
            this.btn_hopdong.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_hopdong.Font = new System.Drawing.Font("Times New Roman", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hopdong.Location = new System.Drawing.Point(0, 494);
            this.btn_hopdong.Name = "btn_hopdong";
            this.btn_hopdong.Size = new System.Drawing.Size(200, 100);
            this.btn_hopdong.TabIndex = 7;
            this.btn_hopdong.Text = "Hợp Đồng";
            this.btn_hopdong.UseVisualStyleBackColor = true;
            this.btn_hopdong.Click += new System.EventHandler(this.btn_hopdong_Click);
            // 
            // btn_datxe
            // 
            this.btn_datxe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_datxe.Font = new System.Drawing.Font("Times New Roman", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_datxe.Location = new System.Drawing.Point(0, 394);
            this.btn_datxe.Name = "btn_datxe";
            this.btn_datxe.Size = new System.Drawing.Size(200, 100);
            this.btn_datxe.TabIndex = 6;
            this.btn_datxe.Text = "Đặt Xe";
            this.btn_datxe.UseVisualStyleBackColor = true;
            this.btn_datxe.Click += new System.EventHandler(this.btn_datxe_Click);
            // 
            // btn_dongxe
            // 
            this.btn_dongxe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_dongxe.Font = new System.Drawing.Font("Times New Roman", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dongxe.Location = new System.Drawing.Point(0, 294);
            this.btn_dongxe.Name = "btn_dongxe";
            this.btn_dongxe.Size = new System.Drawing.Size(200, 100);
            this.btn_dongxe.TabIndex = 5;
            this.btn_dongxe.Text = "Dòng Xe";
            this.btn_dongxe.UseVisualStyleBackColor = true;
            this.btn_dongxe.Click += new System.EventHandler(this.btn_dongxe_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_timkiem.Font = new System.Drawing.Font("Times New Roman", 13.77391F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timkiem.Location = new System.Drawing.Point(0, 194);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(200, 100);
            this.btn_timkiem.TabIndex = 4;
            this.btn_timkiem.Text = "Tìm Kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 194);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1159, 608);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 696);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.panel_left);
            this.Name = "Menu";
            this.Text = "HỆ THỐNG THUÊ XE DU LỊCH HỢP TÁC XÃ DỊCH VỤ";
            this.panel_body.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Button btn_danhgia;
        private System.Windows.Forms.Button btn_hopdong;
        private System.Windows.Forms.Button btn_dongxe;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.Button btn_datxe;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}