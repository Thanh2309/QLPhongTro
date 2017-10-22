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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        
        private void infoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            InformationVersion Infor = new InformationVersion();
            Infor.ShowDialog();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKPhong f3 = new TKPhong();
            f3.ShowDialog();
        }

        private void ngườiTrọToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TKNguoi f4 = new TKNguoi();
            f4.ShowDialog();
        }

        private void phòngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TaoPhong f5 = new TaoPhong();
            f5.ShowDialog();
        }

        private void ngườiTrọToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TTNguoi f6 = new TTNguoi();
            f6.ShowDialog();
        }

        private void tínhTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTien f7 = new TTien();
            f7.ShowDialog();
        }
        
        private void thôngTinPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTPhong f1 = new TTPhong();
            f1.ShowDialog();
        }

        private void ngườiTrọToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            TTNguoi f2 = new TTNguoi();
            f2.ShowDialog();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaoPhong f0 = new TaoPhong();
            f0.ShowDialog();
        }

        private void exitStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
