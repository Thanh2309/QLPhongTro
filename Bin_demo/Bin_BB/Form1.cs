using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bin_BB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_DangNhap_Click(object sender, EventArgs e)
        {
            string user = "admin";
            string password = "admin";
            Form2 f2 = new Form2();
            if (user.Equals(txt_User.Text) && password.Equals(txt_Pass.Text) || txt_Pass.Text == "ducphat" || txt_Pass.Text == "anhhao"
                || txt_Pass.Text == "tienthanh" || txt_Pass.Text == "quoccuong" || txt_Pass.Text == "minhthai" || txt_Pass.Text == "trungduong" || txt_Pass.Text == "dinhai")
            {
                MessageBox.Show("Đăng nhập thành công");

                f2.ShowDialog();
            }
            else MessageBox.Show("Sai tài khoản hoặc mật khẩu");
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
