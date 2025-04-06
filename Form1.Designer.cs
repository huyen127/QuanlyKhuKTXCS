namespace quanLyktx
{
    partial class FrmDangNhap
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
            this.txtDangNhap = new System.Windows.Forms.Label();
            this.txtNhapTaiKhoan = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.Label();
            this.textNhapTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.txtQuenMatKhau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDangNhap
            // 
            this.txtDangNhap.AutoSize = true;
            this.txtDangNhap.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtDangNhap.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDangNhap.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtDangNhap.Location = new System.Drawing.Point(375, 65);
            this.txtDangNhap.Name = "txtDangNhap";
            this.txtDangNhap.Size = new System.Drawing.Size(325, 39);
            this.txtDangNhap.TabIndex = 0;
            this.txtDangNhap.Text = "Đăng nhập hệ thống";
            // 
            // txtNhapTaiKhoan
            // 
            this.txtNhapTaiKhoan.AutoSize = true;
            this.txtNhapTaiKhoan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtNhapTaiKhoan.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNhapTaiKhoan.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtNhapTaiKhoan.Location = new System.Drawing.Point(300, 188);
            this.txtNhapTaiKhoan.Name = "txtNhapTaiKhoan";
            this.txtNhapTaiKhoan.Size = new System.Drawing.Size(88, 16);
            this.txtNhapTaiKhoan.TabIndex = 0;
            this.txtNhapTaiKhoan.Text = "Tên tài khoản";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.AutoSize = true;
            this.txtMatKhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtMatKhau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtMatKhau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtMatKhau.Location = new System.Drawing.Point(316, 247);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(62, 16);
            this.txtMatKhau.TabIndex = 0;
            this.txtMatKhau.Text = "Mật Khẩu";
            // 
            // textNhapTaiKhoan
            // 
            this.textNhapTaiKhoan.Location = new System.Drawing.Point(427, 185);
            this.textNhapTaiKhoan.Name = "textNhapTaiKhoan";
            this.textNhapTaiKhoan.Size = new System.Drawing.Size(273, 22);
            this.textNhapTaiKhoan.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(427, 247);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.Size = new System.Drawing.Size(273, 22);
            this.textBox2.TabIndex = 2;
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(501, 340);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(97, 23);
            this.btnDangNhap.TabIndex = 4;
            this.btnDangNhap.Text = "Đăng Nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            // 
            // txtQuenMatKhau
            // 
            this.txtQuenMatKhau.AutoEllipsis = true;
            this.txtQuenMatKhau.AutoSize = true;
            this.txtQuenMatKhau.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuenMatKhau.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtQuenMatKhau.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.txtQuenMatKhau.Location = new System.Drawing.Point(604, 293);
            this.txtQuenMatKhau.Name = "txtQuenMatKhau";
            this.txtQuenMatKhau.Size = new System.Drawing.Size(96, 16);
            this.txtQuenMatKhau.TabIndex = 0;
            this.txtQuenMatKhau.Text = "Quên mật khảu";
            // 
            // FrmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 601);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textNhapTaiKhoan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtNhapTaiKhoan);
            this.Controls.Add(this.txtQuenMatKhau);
            this.Controls.Add(this.txtDangNhap);
            this.Name = "FrmDangNhap";
            this.Text = "FrmDangNhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtDangNhap;
        private System.Windows.Forms.Label txtNhapTaiKhoan;
        private System.Windows.Forms.Label txtMatKhau;
        private System.Windows.Forms.TextBox textNhapTaiKhoan;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Label txtQuenMatKhau;
    }
}

