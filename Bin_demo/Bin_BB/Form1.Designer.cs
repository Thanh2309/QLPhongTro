namespace Bin_BB
{
    partial class Form1
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
            this.lb_title = new System.Windows.Forms.Label();
            this.lb_TaiKhoan = new System.Windows.Forms.Label();
            this.lb_Matkhau = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Pass = new System.Windows.Forms.TextBox();
            this.btn_DangNhap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_title.Location = new System.Drawing.Point(122, 87);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(197, 25);
            this.lb_title.TabIndex = 8;
            this.lb_title.Text = "Đăng nhập tài khoản ";
            // 
            // lb_TaiKhoan
            // 
            this.lb_TaiKhoan.AutoSize = true;
            this.lb_TaiKhoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_TaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_TaiKhoan.Location = new System.Drawing.Point(12, 162);
            this.lb_TaiKhoan.Name = "lb_TaiKhoan";
            this.lb_TaiKhoan.Size = new System.Drawing.Size(91, 20);
            this.lb_TaiKhoan.TabIndex = 9;
            this.lb_TaiKhoan.Text = "Tài khoản :";
            // 
            // lb_Matkhau
            // 
            this.lb_Matkhau.AutoSize = true;
            this.lb_Matkhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_Matkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lb_Matkhau.Location = new System.Drawing.Point(12, 208);
            this.lb_Matkhau.Name = "lb_Matkhau";
            this.lb_Matkhau.Size = new System.Drawing.Size(87, 20);
            this.lb_Matkhau.TabIndex = 10;
            this.lb_Matkhau.Text = "Mật khẩu :";
            // 
            // txt_User
            // 
            this.txt_User.Location = new System.Drawing.Point(144, 162);
            this.txt_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(239, 22);
            this.txt_User.TabIndex = 1;
            // 
            // txt_Pass
            // 
            this.txt_Pass.ForeColor = System.Drawing.Color.Red;
            this.txt_Pass.Location = new System.Drawing.Point(144, 208);
            this.txt_Pass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_Pass.Name = "txt_Pass";
            this.txt_Pass.PasswordChar = '❤';
            this.txt_Pass.Size = new System.Drawing.Size(239, 22);
            this.txt_Pass.TabIndex = 2;
            // 
            // btn_DangNhap
            // 
            this.btn_DangNhap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_DangNhap.Location = new System.Drawing.Point(179, 286);
            this.btn_DangNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_DangNhap.Name = "btn_DangNhap";
            this.btn_DangNhap.Size = new System.Drawing.Size(111, 55);
            this.btn_DangNhap.TabIndex = 3;
            this.btn_DangNhap.Text = "Đăng nhập";
            this.btn_DangNhap.UseVisualStyleBackColor = true;
            this.btn_DangNhap.Click += new System.EventHandler(this.btn_DangNhap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(155, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nhóm 2 lớp 15DTH11";
            // 
            // Form1
            // 
            this.AcceptButton = this.btn_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_DangNhap);
            this.Controls.Add(this.txt_Pass);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.lb_Matkhau);
            this.Controls.Add(this.lb_TaiKhoan);
            this.Controls.Add(this.lb_title);
            this.Name = "Form1";
            this.Text = "Quản Lý Phòng Trọ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label lb_TaiKhoan;
        private System.Windows.Forms.Label lb_Matkhau;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Pass;
        private System.Windows.Forms.Button btn_DangNhap;
        private System.Windows.Forms.Label label1;
    }
}

