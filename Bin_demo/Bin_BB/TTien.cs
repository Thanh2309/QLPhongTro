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
    public partial class TTien : Form
    {
        public TTien()
        {
            InitializeComponent();
        }

        private void btn_QLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbb_LP_SelectedIndexChanged(object sender, EventArgs e)
        {
            //code để DGView hiện thông tin phòng 
        }

        decimal Tien;

        private void btn_TTien_Click(object sender, EventArgs e)
        {
            grB_2.Visible = true;
            grB_2.Enabled = true;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            //SoNuocMoi = txt_SNMoi.Text;
            //SoDienMoi = txt_SDMoi.Text;
            //decimal Phi = decimal.Parse(txt_ThemPhi.Text);

            //code tính tiền
            txt_TCong.Text = Convert.ToString(Tien);
            grB_2.Enabled = false;
            grB_2.Visible = false;
        }
    }
}
