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
    public partial class TKNguoi : Form
    {
        QuanLyPhongTroEntities7 Db = new QuanLyPhongTroEntities7();
        public TKNguoi()
        {
            InitializeComponent();
        }
        private void btn_TK_Click(object sender, EventArgs e)
        {
            int tam_ID = Convert.ToInt32(txt_CMND.Text);
            string tam_Ten = txt_Ten.Text;
            if(cb_CMND.Checked == true && cb_Ten.Checked == true)
            {
                dataGridView1.DataSource = Db.NguoiTroes.Where(a => a.Cmnd == tam_ID && a.HoTen == tam_Ten).Select(a => new ViewTT()
                {
                    IdNguoi = a.IdNguoi,
                    //trỏ từ Nguoi qua ChiTietP                   
                    // MaPhong =( a.ChitietPhongs.SingleOrDefault(b=>b.Phong.MaPhong)),
                    HoTen = a.HoTen,
                    NgaySinh = a.NamSinh,
                    CMND = a.Cmnd,
                    SoDT = a.SoDT,
                   // ChuPhong = a.ChitietPhongs.ChuPhong,
                }).ToList();
            }
            else if (cb_CMND.Checked == true && cb_Ten.Checked == false)
            {
                dataGridView1.DataSource = Db.ChitietPhongs.Where(a => a.IdNguoi == tam_ID ).Select(a => new ViewTT()
                {
                    IdNguoi = a.IdNguoi,
                    MaPhong = a.Phong.MaPhong,
                    HoTen = a.NguoiTro.HoTen,
                    NgaySinh = a.NguoiTro.NamSinh,
                    CMND = a.NguoiTro.Cmnd,
                    SoDT = a.NguoiTro.SoDT,
                    ChuPhong = a.ChuPhong,
                }).ToList();
            }
            else if (cb_CMND.Checked == false && cb_Ten.Checked == true)
            {
                dataGridView1.DataSource = Db.ChitietPhongs.Where(a => a.NguoiTro.HoTen == tam_Ten).Select(a => new ViewTT()
                {
                    IdNguoi = a.IdNguoi,
                    MaPhong = a.Phong.MaPhong,
                    HoTen = a.NguoiTro.HoTen,
                    NgaySinh = a.NguoiTro.NamSinh,
                    CMND = a.NguoiTro.Cmnd,
                    SoDT = a.NguoiTro.SoDT,
                    ChuPhong = a.ChuPhong,
                }).ToList();
            }

        }

        private void btn_QLai_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void txt_CMND_TextChanged(object sender, EventArgs e)
        {
            btn_TK.Enabled = true;
        }

        private void txt_Ten_TextChanged(object sender, EventArgs e)
        {
            btn_TK.Enabled = true;
        }

        private void cb_CMND_CheckedChanged(object sender, EventArgs e)
        {
            txt_CMND.Enabled = true;
        }

        private void cb_Ten_CheckedChanged(object sender, EventArgs e)
        {
            txt_Ten.Enabled = true;
        }

    }

    public class ViewTT
    {
        public int IdNguoi { get; set; }
        public string MaPhong { get; set; }
        public string HoTen { get; set; }
        public DateTime? NgaySinh { get; set; }
        public int? CMND { get; set; }
        public int? SoDT { get; set; }
        public bool? ChuPhong { get; set; }
    }
}
