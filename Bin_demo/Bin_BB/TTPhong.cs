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
    public partial class TTPhong : Form
    {
        public TTPhong()
        {
            InitializeComponent();
        }
        QuanLyPhongTroEntities7 DB = new QuanLyPhongTroEntities7();

        private void locktext()
        {
            cb_TTrạng.Enabled = false;
           // txt_MaPhong.Enabled = false;
            txt_SNguoi.Enabled = false;
            txt_SoDT.Enabled = false;
            txt_CPhòng.Enabled = false;
            txt_TCoc.Enabled = false;
            txt_SDCũ.Enabled = false;
            txt_SDTruoc.Enabled = false;
            txt_SNCũ.Enabled = false;
            txt_SNTrước.Enabled = false;
            dtp_1.Enabled = false;

            btn_Them.Enabled = true;
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Luu.Enabled = false;
        }

        private void unlocktext()
        {
            cb_TTrạng.Enabled = true;
           // txt_MaPhong.Enabled = true;
            txt_SNguoi.Enabled = true;
            txt_CPhòng.Enabled = true;
            txt_TCoc.Enabled = true;
            txt_SDCũ.Enabled = true;
            txt_SNCũ.Enabled = true;

            btn_Them.Enabled = false;
            btn_Sua.Enabled = false;
            btn_Xoa.Enabled = false;
            btn_Luu.Enabled = true;
        }

        private void resettext()
        {
            cb_TTrạng.Checked = false;
           // txt_MaPhong.Text = null;
            txt_SNguoi.Text = null;
            txt_SDCũ.Text = null;
            txt_SNCũ.Text = null;
            txt_TCoc.Text = null;
            txt_CPhòng.Text = null;
        }

        //private int checktext()
        //{
        //    if(txt_MaPhong.Text == "" || txt_SNguoi.Text == "" || txt_SNCũ.Text == "" || txt_SDCũ.Text == "" || txt_CPhòng.Text == "")
        //        return 1;
        //    return 0;
        //}

        bool CLuu;

        private void btn_Them_Click(object sender, EventArgs e)
        {
           // unlocktext();
            resettext();
            CLuu = true;
            
            
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            unlocktext();
            CLuu = false;
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có chắc chắn muốn xóa", "Thông báo", MessageBoxButtons.YesNo);
            //code Xóa
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if(CLuu == true)
            {
                //code Thêm
            }
            else
            {
                //code sửa
            }
        }

        private void btn_QLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TTPhong_Load(object sender, EventArgs e)
        {
            locktext();
            cbb_MaPhong.Enabled = true;
            //List<string> tam = DB.Phongs.Select(a => a.MaPhong).ToList();

            //cbb_MaPhong.Items.Add(tam);
            dataGridView1.DataSource()
            var cbb = from Phong in DB.Phongs
                      select Phong;
            cbb_MaPhong.DataSource = cbb.ToList();
            cbb_MaPhong.DisplayMember = "MaPhong";
            string tam=cbb_MaPhong.SelectedText;
            ///////////////////////////
          
            
            List<string> maphong = DB.Phongs.Select(a => a.MaPhong).ToList();
            int slmp = maphong.Count;
            //int tam_SL = int.Parse(txt_Sluong.Text);
            //for (int i = 0; i < tam_SL; i++)
            //{
            //    int dem = 0;
                for (int j = 0; j < slmp; j++)
                {
                    if (tam==maphong[j])
                    {
                      
                    }
                }

                if (dem != 0)
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
            //}
            DB.SaveChanges();
            DGViewShow();
            locktext();
            btn_Sua.Enabled = true;
            btn_Xoa.Enabled = true;
        }

    }

        public class ViewTTPhong
        {
            public string MaPhong { get; set; }
            public int ?SoNguoi { get; set; }
            public string TenNguoi { get; set; }
            public bool ChuPhong { get; set; }
            public int ? SDT { get; set; }
            public int? SoDienCu { get; set; }
            public int ? SoNuocCu { get; set; }
            public int ? SoDien { get; set; }
            public int ? SoNuoc { get; set; }
            public decimal ? TienCoc { get; set; }
        }
        public void GetDate(DateTime a,DateTime b)
        {
            //a.Date = b.Date;
        }
    }
}
