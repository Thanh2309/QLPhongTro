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
    public partial class TKPhong : Form
    {
        QuanLyPhongTroEntities7 Db = new QuanLyPhongTroEntities7();

        public TKPhong()
        {
            InitializeComponent();
        }

        private void btn_TK_Click(object sender, EventArgs e)
        {
            int tam_LP = int.Parse(cbb_LP.Text);
            bool tam_TTrang = Convert.ToBoolean(cbb_TTrang.Text);

            if (cb_LP.Checked == true && cb_TTrang.Checked == true)
            {
                dataGridView1.DataSource = Db.ChitietPhongs.Where(a => a.Phong.LoaiPhong.MaLoai == tam_LP && a.TinhTrang == tam_TTrang).Select(a => new ViewTT()
                {
                    //TenLoai = a.Phong.LoaiPhong.TenLoai,
                    MaPhong = a.Phong.MaPhong,
                    //GiaPhong = a.Phong.LoaiPhong.GiaPhong,
                    //NgayVao = a.NgayVao,
                    TienCoc = a.TienCoc,
                    //Internet = a.Phong.Internet,
                    //Rac = a.Phong.Rac,
                    TinhTrang = a.TinhTrang,
                }).ToList();
            }
            else if(cb_LP.Checked == true && cb_TTrang.Checked == false)
            {
                //dataGridView1.DataSource = Db.ChitietPhongs.Where(a => a.Phong.LoaiPhong.MaLoai == tam_LP).Select(a => new ViewTT()
                //{
                //    TenLoai = a.Phong.LoaiPhong.TenLoai,
                //    MaPhong = a.Phong.MaPhong,
                //    GiaPhong = a.Phong.LoaiPhong.GiaPhong,
                //    NgayVao = a.NgayVao,
                //    TienCoc = a.TienCoc,
                //    Internet = a.Phong.Internet,
                //    Rac = a.Phong.Rac,
                //    TinhTrang = a.TinhTrang,
                //}).ToList();
            }
            else if (cb_LP.Checked == false && cb_TTrang.Checked == true)
            {
                //dataGridView1.DataSource = Db.ChitietPhongs.Where(a => a.TinhTrang == tam_TTrang).Select(a => new ViewTT()
                //{
                //    TenLoai = a.Phong.LoaiPhong.TenLoai,
                //    MaPhong = a.Phong.MaPhong,
                //    GiaPhong = a.Phong.LoaiPhong.GiaPhong,
                //    //NgayVao = a.NgayVao,
                //    TienCoc = a.TienCoc,
                //    Internet = a.Phong.Internet,
                //    Rac = a.Phong.Rac,
                //    TinhTrang = a.TinhTrang,
                //}).ToList();
            }
            else
            {
                //dataGridView1.DataSource = Db.ChitietPhongs.Select(a => new ViewTT()
                //{
                //    TenLoai = a.Phong.LoaiPhong.TenLoai,
                //    MaPhong = a.Phong.MaPhong,
                //    GiaPhong = a.Phong.LoaiPhong.GiaPhong,
                //    //NgayVao = a.NgayVao,
                //    TienCoc = a.TienCoc,
                //    Internet = a.Phong.Internet,
                //    Rac = a.Phong.Rac,
                //    TinhTrang = a.TinhTrang,
                //}).ToList();
            }
        }

        private void DGViewShow()
        {
            dataGridView1.DataSource = Db.Phongs.Select(a => new ViewTT()
            {
                MaPhong = a.MaPhong,
                LoaiPhong = a.Maloai,
               // SoLuong = a.ChitietPhongs,
                //TenNguoi = a.ChitietPhongs.SingleOrDefault(b => ),

            }).ToList();
        }

        public class ViewTT
        {
            public string MaPhong { get; set; }
            public int? LoaiPhong { get; set; }
            public int? SoLuong { get; set; }
            public string TenNguoi { get; set; }
            public decimal? TienCoc { get; set; }
            public bool? TinhTrang { get; set; }
        }

        private void cb_TTrang_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_TTrang.Checked == true)
            {
                cbb_TTrang.Enabled = true;
            }
            else
            {
                cbb_TTrang.Enabled = false;
            }
        }

        private void cb_LP_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_LP.Checked == true)
            {
                cbb_LP.Enabled = true;
            }
            else
            {
                cbb_LP.Enabled = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cb_TPhong.Checked == true)
            {
                txt_TPhong.Enabled = true;
            }
            else
            {
                txt_TPhong.Enabled = false;
            }
        }

        private void cbb_TTrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_TK.Enabled = true;
        }

        private void cbb_LP_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_TK.Enabled = true;
        }

        private void txt_TPhong_TextChanged(object sender, EventArgs e)
        {
            btn_TK.Enabled = true;
        }
    }
}
