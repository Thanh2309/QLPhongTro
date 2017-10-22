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
    public partial class TTNguoi : Form
    {
        QuanLyPhongTroEntities7 Db = new QuanLyPhongTroEntities7();
        public TTNguoi()
        {
            InitializeComponent();
        }

        private void locktext()
        {
            txt_IdNguoi.Enabled = false;
            txt_MaPhong.Enabled = false;
            txt_HTen.Enabled = false;
            txt_CMND.Enabled = false;
            txt_SoDT.Enabled = false;
            dtp_NgaySinh.Enabled = false;
            dtp_NgayVao.Enabled = false;
            cb_CPhong.Enabled = false;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void unlocktext()
        {
            txt_MaPhong.Enabled = true;
            txt_HTen.Enabled = true;
            txt_CMND.Enabled = true;
            txt_SoDT.Enabled = true;
            dtp_NgaySinh.Enabled = true;
            dtp_NgayVao.Enabled = true;
            cb_CPhong.Enabled = true;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
        }

        private void resettext()
        {
            txt_SoDT.Text = null;
            txt_MaPhong.Text = null;
            txt_IdNguoi.Text = null;
            txt_HTen.Text = null;
            txt_CMND.Text = null;
            dtp_NgaySinh.Checked = false;
        }

        private int checktext()
        {
            if (txt_SoDT.Text == ""
            || txt_MaPhong.Text == ""
            || txt_HTen.Text == ""
            || txt_CMND.Text == "")
                return 1;
            return 0;
        }

        bool CLuu;

        private void btn_Them_Click(object sender, EventArgs e)
        {

            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            unlocktext();
            CLuu = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(CLuu == true)
            {
                //code Thêm
            }
            else
            {
                //code Sửa
            }
        }

        private void btn_QLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            //code Xóa
        }
    }
}
