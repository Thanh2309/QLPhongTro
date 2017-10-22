using System;
using System.Collections;
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
    public partial class TaoPhong : Form
    {
        QuanLyPhongTroEntities7 Db = new QuanLyPhongTroEntities7();
        public int maphong;
        public TaoPhong()
        {
            InitializeComponent();
        }

        private void locktext()
        {
            cbb_LP.Enabled = false;
            txt_Sluong.Enabled = false;
            txt_MaP.Enabled = false;
            txt_Internet.Enabled = false;
            txt_Rac.Enabled = false;
            txt_CPKhac.Enabled = false;
            txt_GiaDien.Enabled = false;
            txt_GiaNuoc.Enabled = false;
        }

        private void unlocktext()
        {
            cbb_LP.Enabled = true;
            txt_Sluong.Enabled = true;
            txt_MaP.Enabled = true;
            txt_Internet.Enabled = true;
            txt_Rac.Enabled = true;
            txt_CPKhac.Enabled = true;
            txt_GiaDien.Enabled = true;
            txt_GiaNuoc.Enabled = true;
        }

        private void resettext()
        {
            txt_TLoai.Text = null;
            txt_MaP.Text = null;
            txt_Sluong.Text = null;
            txt_Internet.Text = null;
            txt_Rac.Text = null;
            txt_CPKhac.Text = null;
            txt_GiaNuoc.Text = null;
            txt_GiaDien.Text = null;
        }

        private int checktext()
        {
            if (cbb_LP.SelectedItem == null || txt_MaP.Text == "" || txt_Internet.Text == "" || txt_Rac.Text == "" || txt_GiaNuoc.Text == "" || txt_GiaDien.Text == "" || txt_CPKhac.Text == "")
                return 1;
            return 0;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if (txt_GiaPhong.Enabled == false && txt_MaP.Enabled == false)
            {
                resettext();
                unlocktext();
                btn_Sua.Enabled = false;
                btn_Xoa.Enabled = false;
            }
            else
            {
                do
                {
                    if (checktext() == 1)
                    {
                        MessageBox.Show("Hãy nhập đầy đủ thông tin !");
                        return;
                    }
                    else
                    {
                        string tam = cbb_LP.Text;
                        string maloai = Db.LoaiPhongs.Where(a => a.TenLoai == tam).Select(a => a.MaLoai).SingleOrDefault().ToString();
                        List <string> maphong = Db.Phongs.Select(a => a.MaPhong).ToList();
                        int slmp = maphong.Count;
                        int tam_SL = int.Parse(txt_Sluong.Text);
                        for (int i = 0; i < tam_SL; i++)
                        {
                            int dem = 0;
                            for (int j = 0; j < slmp; j++)
                            {
                                if (txt_MaP.Text + "." + i.ToString() == maphong[j])
                                {
                                    dem += 1;
                                }
                            }

                            if(dem!=0)
                            {
                                MessageBox.Show("Hãy nhập tên phòng khác !");
                                return;
                            }
                            Db.Phongs.Add(new Phong()
                            {
                                Maloai = int.Parse(maloai),
                                MaPhong = txt_MaP.Text + "." + i.ToString(),
                                Internet = decimal.Parse(txt_Internet.Text),
                                Rac = decimal.Parse(txt_Rac.Text),
                                Nuoc = decimal.Parse(txt_GiaNuoc.Text),
                                Dien = decimal.Parse(txt_GiaDien.Text),
                                ChiPhiKhac = decimal.Parse(txt_CPKhac.Text)
                            });
                        }
                        Db.SaveChanges();
                        DGViewShow();
                        locktext();
                        btn_Sua.Enabled = true;
                        btn_Xoa.Enabled = true;
                    }
                } while (checktext() == 1);
            }
        }
        
        private void btn_Sua_Click(object sender, EventArgs e)
        {
            if (txt_GiaPhong.Enabled == false && txt_GiaDien.Enabled == false)
            {
                unlocktext();
                txt_GiaPhong.Enabled = false;
                txt_MaP.Enabled = false;
                btn_Xoa.Enabled = false;
                btn_Them.Enabled = false;
            }
            else
            {
                do
                {
                    Phong p = Db.Phongs.FirstOrDefault();
                        p.Internet = decimal.Parse(txt_Internet.Text);
                        p.Rac = decimal.Parse(txt_Rac.Text);
                        p.Nuoc = decimal.Parse(txt_GiaNuoc.Text);
                        p.Dien = decimal.Parse(txt_GiaDien.Text);
                        p.ChiPhiKhac = decimal.Parse(txt_CPKhac.Text);
                    
                    Db.SaveChanges();
                    DGViewShow();
                    locktext();
                    btn_Them.Enabled = true;
                    btn_Xoa.Enabled = true;
                    MessageBox.Show("Bạn đã sửa thành công !!", "Thông báo");
                } while (checktext() == 1);
            }
        }

        private void DGViewShow()
        {
            dataGridView2.DataSource = Db.Phongs.Select(a => new ViewTT()
            {
                TenLoai = a.LoaiPhong.TenLoai,
                TenPhong = a.MaPhong,
                GiaPhong = a.LoaiPhong.GiaPhong,
                Internet = a.Internet,
                Rac = a.Rac,
                GiaDien = a.Dien,
                GiaNuoc = a.Nuoc,
                ChiPhiKhac = a.ChiPhiKhac
            }).ToList();
        }
        
        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (txt_MaP.Text == "")
                    MessageBox.Show("Hãy Chọn Đối Tượng Cần Xóa!!!", "Thông Báo");
                else
                {
                     string tam = txt_MaP.Text;
                    var xoa = Db.Phongs.Where(a => a.MaPhong == tam).SingleOrDefault();
                    Db.Phongs.Remove(xoa);
                    Db.SaveChanges();
                    resettext();
                    DGViewShow();
                    MessageBox.Show("Bạn đã xóa thành công !!", "Thông báo");
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                btn_Huy_Click(sender, e);
            }
        }
        
        private void btn_QLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_TLPhong_Click(object sender, EventArgs e)
        {
            if (txt_TLoai.Enabled == false)
            {
                txt_TLoai.Enabled = true;
                txt_GiaPhong.Enabled = true;
                txt_TLoai.Text = "";
                txt_GiaPhong.Text = "";
            }
            else
            {
                if (txt_GiaPhong.Text == "" || txt_TLoai.Text == "")
                {
                    MessageBox.Show("Hãy nhập thông tin", "Thông báo");
                    return;
                }
                else
                {
                    Db.LoaiPhongs.Add(new LoaiPhong() { TenLoai = txt_TLoai.Text, GiaPhong = decimal.Parse(txt_GiaPhong.Text) });
                    Db.SaveChanges();
                    var cbb = from LoaiPhong in Db.LoaiPhongs
                              select LoaiPhong;
                    cbb_LP.DataSource = cbb.ToList();
                    cbb_LP.DisplayMember = "TenLoai";
                    txt_GiaPhong.Enabled = false;
                    txt_TLoai.Enabled = false;
                    unlocktext();
                    btn_Sua.Enabled = true;
                    btn_Xoa.Enabled = true;

                }
            }
        }

        private void TaoPhong_Load(object sender, EventArgs e)
        {
            DGViewShow();
            locktext();
            var cbb = from LoaiPhong in Db.LoaiPhongs
                      select LoaiPhong;
            cbb_LP.DataSource = cbb.ToList();
            cbb_LP.DisplayMember = "TenLoai";
            MessageBox.Show("aaaaaaaaaaaaaaaaaa");
            MessageBox.Show("bbbbbbbbbbbbbbbbbb");
        }

        private void cbb_LP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView2.Rows[e.RowIndex];
            txt_TLoai.Text = row.Cells[0].Value.ToString();
            txt_MaP.Text = row.Cells[1].Value.ToString();
            txt_Internet.Text = row.Cells[3].Value.ToString();
            txt_Rac.Text = row.Cells[4].Value.ToString();
            txt_GiaDien.Text = row.Cells[5].Value.ToString();
            txt_GiaNuoc.Text = row.Cells[6].Value.ToString();
            txt_CPKhac.Text = row.Cells[7].Value.ToString();
        }

        public class ViewTT
        {
            public string TenLoai { get; set; }
            public string TenPhong { get; set; }
            public decimal? GiaPhong { get; set; }
            public decimal? Internet { get; set; }
            public decimal? Rac { get; set; }
            public decimal? GiaDien { get; set; }
            public decimal? GiaNuoc { get; set; }
            public decimal? ChiPhiKhac { get; set; }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            TaoPhong_Load(sender,e);
            txt_GiaPhong.Enabled = false;
            txt_TLoai.Enabled = false;
            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

    }
}
