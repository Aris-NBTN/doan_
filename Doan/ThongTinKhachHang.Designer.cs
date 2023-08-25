namespace Doan
{
    partial class ThongTinKhachHang
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
            this.txt_tenkh = new System.Windows.Forms.TextBox();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.txt_sdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_cmnd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_XuatDuLieu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tenkh
            // 
            this.txt_tenkh.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenkh.Location = new System.Drawing.Point(30, 82);
            this.txt_tenkh.Multiline = true;
            this.txt_tenkh.Name = "txt_tenkh";
            this.txt_tenkh.Size = new System.Drawing.Size(457, 37);
            this.txt_tenkh.TabIndex = 18;
            this.txt_tenkh.TextChanged += new System.EventHandler(this.txt_tenxe_TextChanged);
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(24, 43);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Size = new System.Drawing.Size(226, 36);
            this.lbl_tieude.TabIndex = 17;
            this.lbl_tieude.Text = "Tên Khách Hàng";
            this.lbl_tieude.Click += new System.EventHandler(this.lbl_tieude_Click);
            // 
            // txt_sdt
            // 
            this.txt_sdt.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sdt.Location = new System.Drawing.Point(30, 197);
            this.txt_sdt.Multiline = true;
            this.txt_sdt.Name = "txt_sdt";
            this.txt_sdt.Size = new System.Drawing.Size(457, 37);
            this.txt_sdt.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Số Điện Thoại";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(30, 317);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(457, 37);
            this.txtDiaChi.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 36);
            this.label2.TabIndex = 21;
            this.label2.Text = "Địa Chỉ";
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(30, 439);
            this.txt_email.Multiline = true;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(457, 37);
            this.txt_email.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 36);
            this.label3.TabIndex = 23;
            this.label3.Text = "Email";
            // 
            // txt_cmnd
            // 
            this.txt_cmnd.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cmnd.Location = new System.Drawing.Point(30, 565);
            this.txt_cmnd.Multiline = true;
            this.txt_cmnd.Name = "txt_cmnd";
            this.txt_cmnd.Size = new System.Drawing.Size(457, 37);
            this.txt_cmnd.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 526);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 36);
            this.label4.TabIndex = 25;
            this.label4.Text = "CMND";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(525, 82);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 520);
            this.listView1.TabIndex = 27;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // btn_XuatDuLieu
            // 
            this.btn_XuatDuLieu.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XuatDuLieu.Location = new System.Drawing.Point(521, 21);
            this.btn_XuatDuLieu.Name = "btn_XuatDuLieu";
            this.btn_XuatDuLieu.Size = new System.Drawing.Size(132, 41);
            this.btn_XuatDuLieu.TabIndex = 30;
            this.btn_XuatDuLieu.Text = "Xuất Dữ Liệu";
            this.btn_XuatDuLieu.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(696, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(307, 36);
            this.label6.TabIndex = 29;
            this.label6.Text = "Thông Tin Khách Hàng";
            // 
            // ThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 614);
            this.Controls.Add(this.btn_XuatDuLieu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.txt_cmnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_sdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tenkh);
            this.Controls.Add(this.lbl_tieude);
            this.Name = "ThongTinKhachHang";
            this.Text = "HỆ THỐNG THUÊ XE DU LỊCH HỢP TÁC XÃ DỊCH VỤ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tenkh;
        private System.Windows.Forms.Label lbl_tieude;
        private System.Windows.Forms.TextBox txt_sdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_cmnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_XuatDuLieu;
        private System.Windows.Forms.Label label6;
    }
}