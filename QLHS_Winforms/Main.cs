using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_Winforms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void họcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HocSinh hs = new HocSinh();
            hs.MdiParent = this;
            hs.Show();
        }

        private void lớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lop lop = new Lop();
            lop.MdiParent = this;
            lop.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ban thuc su muon thoat?", "Canh bao!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Ban thuc su muon thoat?", "Canh bao!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void hiểnThịDSHSTheoLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HienDSHSTheoLop ds = new HienDSHSTheoLop();
            ds.MdiParent = this;
            ds.Show();
        }

        private void hSTheoGTVàLớpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemSoHSTheoGT dem = new DemSoHSTheoGT();
            dem.MdiParent = this;
            dem.Show();
        }

        private void hiểnThịLớpTheoMãGvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LopTheoMaGV magv = new LopTheoMaGV();
            magv.MdiParent = this;
            magv.Show();
        }

        private void sốLớpTheoGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DemSoLopTheoGV lgv = new DemSoLopTheoGV();
            lgv.MdiParent = this;
            lgv.Show();
        }

        private void mônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Monhoc m = new Monhoc();
            m.MdiParent = this;
            m.Show();
        }

        private void thốngKêMônHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            baocaomon f = new baocaomon();
            f.MdiParent = this;
            f.Show();
        }

        private void giáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Giaovien gv = new Giaovien();
            gv.MdiParent = this;
            gv.Show();
        }

        private void thốngKêGiáoViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportGv rp = new ReportGv();
            rp.MdiParent = this;
            rp.Show();
        }

        private void Main_Load(object sender, EventArgs e)
        {
           // this.Enabled = false; ;

           // login l = new login();
            // l.MdiParent = this;
            //this.Hide();
            //l.Show();
            
                   }

        private void thốngKêĐiểmHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReportHs rp = new ReportHs();
            rp.MdiParent = this;
            rp.Show();
        }

        private void nămHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Namhoc n = new Namhoc();
            n.MdiParent = this;
            n.Show();
        }



        //private void kếtQuảHọcSinhToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    KQ_HS_MonHoc kq = new KQ_HS_MonHoc();
        //    kq.MdiParent = this;
        //    kq.Show();
        //}
    }
}
