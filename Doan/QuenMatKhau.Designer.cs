namespace Doan
{
    partial class QuenMatKhau
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
            this.btn_laymk = new System.Windows.Forms.Button();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_taikhoan = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_taikhoan = new System.Windows.Forms.Label();
            this.lbl_tieude = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_laymk
            // 
            this.btn_laymk.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_laymk.Location = new System.Drawing.Point(362, 423);
            this.btn_laymk.Name = "btn_laymk";
            this.btn_laymk.Size = new System.Drawing.Size(161, 43);
            this.btn_laymk.TabIndex = 19;
            this.btn_laymk.Text = "Lấy Lại Mật Khẩu";
            this.btn_laymk.UseVisualStyleBackColor = true;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matkhau.Location = new System.Drawing.Point(77, 312);
            this.txt_matkhau.Multiline = true;
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.PasswordChar = '*';
            this.txt_matkhau.Size = new System.Drawing.Size(446, 44);
            this.txt_matkhau.TabIndex = 18;
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Font = new System.Drawing.Font("Times New Roman", 20.03478F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_taikhoan.Location = new System.Drawing.Point(77, 179);
            this.txt_taikhoan.Multiline = true;
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(446, 44);
            this.txt_taikhoan.TabIndex = 17;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(73, 264);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Padding = new System.Windows.Forms.Padding(12);
            this.lbl_email.Size = new System.Drawing.Size(82, 46);
            this.lbl_email.TabIndex = 16;
            this.lbl_email.Text = "Email";
            // 
            // lbl_taikhoan
            // 
            this.lbl_taikhoan.AutoSize = true;
            this.lbl_taikhoan.Font = new System.Drawing.Font("Times New Roman", 11.89565F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_taikhoan.Location = new System.Drawing.Point(73, 131);
            this.lbl_taikhoan.Name = "lbl_taikhoan";
            this.lbl_taikhoan.Padding = new System.Windows.Forms.Padding(12);
            this.lbl_taikhoan.Size = new System.Drawing.Size(121, 46);
            this.lbl_taikhoan.TabIndex = 15;
            this.lbl_taikhoan.Text = "Tài Khoản";
            // 
            // lbl_tieude
            // 
            this.lbl_tieude.AutoSize = true;
            this.lbl_tieude.Font = new System.Drawing.Font("Times New Roman", 21.91304F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tieude.Location = new System.Drawing.Point(162, 23);
            this.lbl_tieude.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_tieude.Name = "lbl_tieude";
            this.lbl_tieude.Padding = new System.Windows.Forms.Padding(5);
            this.lbl_tieude.Size = new System.Drawing.Size(274, 50);
            this.lbl_tieude.TabIndex = 14;
            this.lbl_tieude.Text = "Quên Mật Khẩu";
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 513);
            this.Controls.Add(this.btn_laymk);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_taikhoan);
            this.Controls.Add(this.lbl_tieude);
            this.Name = "QuenMatKhau";
            this.Text = "HỆ THỐNG THUÊ XE DU LỊCH HỢP TÁC XÃ DỊCH VỤ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_laymk;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_taikhoan;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_taikhoan;
        private System.Windows.Forms.Label lbl_tieude;
    }
}