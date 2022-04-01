using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_Winforms
{
    public partial class KQ_HS_MonHoc : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public KQ_HS_MonHoc()
        {
            InitializeComponent();
        }
        HocSinh hs;
        public KQ_HS_MonHoc(HocSinh f)
        {
            InitializeComponent();
            hs = f;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KQ_HS_MonHoc_FormClosing);

        }
        public void getValue(string mahs, string  name)
        {
            txtmahs.Text = mahs;
            txtName.Text = name;
        }
        private void KQ_HS_MonHoc_Load(object sender, EventArgs e)
        {
            hienmalop();
            hienmamon();
            hienmanam();
            hienmahk();
            loaddt();
            dnb();
           
           //datalistkqhs.Enabled = true;
           btnluu.Enabled = true;
        }
        private void loaddt()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select tblKQ_HOCSINH_MONHOC.sMaHS as[Mã HS],tblHocSinh.sTenHS as [Tên học sinh], tblLop.sLop as[Lớp], tblMonHoc.sMon as[Môn], tblNamHoc.sTennam as[Năm], tblHocKy.sTenhki as[Kỳ], fDiemMiengTB as[Điểm miệng], fDiem15PhutTB as[Điểm 15], fDiem45PhutTB as[Điểm 45], fDiemThi as[Điểm thi], fDiemTBHK as[DTB]  from(((((tblKQ_HOCSINH_MONHOC inner join tblLop on tblKQ_HOCSINH_MONHOC.sMaLop = tblLop.sMalop) inner join tblMonHoc on tblKQ_HOCSINH_MONHOC.sMaMH = tblMonHoc.sMaMH) inner join tblNamHoc on tblKQ_HOCSINH_MONHOC.sManam = tblNamHoc.sManam) inner join tblHocKy on tblKQ_HOCSINH_MONHOC.sMahki = tblHocKy.sMahki) inner join tblHocSinh on tblKQ_HOCSINH_MONHOC.sMaHs = tblHocSinh.sMaHS) where tblKQ_HOCSINH_MONHOC.sMaHS = '"+txtmahs.Text+"' group by tblKQ_HOCSINH_MONHOC.sMaHS,tblHocSinh.sTenHS, tblLop.sLop, tblMonHoc.sMon, tblNamHoc.sTennam, tblHocKy.sTenhki, fDiemMiengTB, fDiem15PhutTB, fDiem45PhutTB, fDiemThi, fDiemTBHK", cnn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datalistkqhs.DataSource = tb;
                    }
                }
            }
            foreach(DataGridViewRow dt in datalistkqhs.Rows)
            {
                dt.Cells[10].Value = ((float.Parse(dt.Cells[9].Value.ToString()) + float.Parse(dt.Cells[8].Value.ToString()) + float.Parse(dt.Cells[7].Value.ToString()) + float.Parse(dt.Cells[6].Value.ToString())) / 4).ToString();
            }
          //  enb();
        }
        private DataTable laymlop()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("lop");
                        da.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienmalop()
        {
            DataTable t = laymlop();
            DataView v = new DataView(t);
            v.Sort = "sMalop";
            cbmalop.DataSource = v;
            cbmalop.DisplayMember = "sLop";
            cbmalop.ValueMember = "sMalop";
        }

        private DataTable laymamon()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblMonHoc where iTT = 'false' ", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("mon");
                        da.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienmamon()
        {
            DataTable t = laymamon();
            DataView v = new DataView(t);
            v.Sort = "sMaMH";
            cbmamon.DataSource = v;
            cbmamon.DisplayMember = "sMon";
            cbmamon.ValueMember = "sMaMH";
        }

        private DataTable laymanam()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNamHoc", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("namhoc");
                        da.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienmanam()
        {
            DataTable t = laymanam();
            DataView v = new DataView(t);
            v.Sort = "sManam";
            cbmanam.DataSource = v;
            cbmanam.DisplayMember = "sTennam";
            cbmanam.ValueMember = "sManam";
        }
        private DataTable laymahk()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblHocKy", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("hocky");
                        da.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienmahk()
        {
            DataTable t = laymahk();
            DataView v = new DataView(t);
            v.Sort = "sMahki";
            cbmaky.DataSource = v;
            cbmaky.DisplayMember = "sTenhki";
            cbmaky.ValueMember = "sMahki";
        }

        private void KQ_HS_MonHoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Ban thuc su muon thoat?", "Canh bao!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void enb()
        {
            //txtmahs.Enabled = true;
            cbmalop.Enabled = true;
            cbmamon.Enabled = true;
            cbmanam.Enabled = true;
            cbmaky.Enabled = true;
            txtdmieng.Enabled = true;
            txt15.Enabled = true;
            txt45.Enabled = true;
            txtdthi.Enabled = true;
            txtdtb.Enabled = true;
            txtName.Enabled = true;
        }
        private void dnb()
        {
            txtmahs.Enabled = false ;
            cbmalop.Enabled = false;
            cbmamon.Enabled = false;
            cbmanam.Enabled = false;
            cbmaky.Enabled = false;
            txtdmieng.Enabled = false;
            txt15.Enabled = false;
            txt45.Enabled = false;
            txtdthi.Enabled = false;
            txtdtb.Enabled = false;
            txtName.Enabled = false;
        }
        private void clearkq()
        {
            txtdmieng.Clear();
            txt15.Clear();
            txt45.Clear();
            txtdthi.Clear();
            txtdtb.Clear();
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            enb();
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
            btnthem.Enabled = true;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_upt_diem", cnn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", txtmahs.Text);
                        cmd.Parameters.AddWithValue("@idlop", cbmalop.SelectedValue);
                        cmd.Parameters.AddWithValue("@idMh", cbmamon.SelectedValue);
                        cmd.Parameters.AddWithValue("@idnam", cbmanam.SelectedValue);
                        cmd.Parameters.AddWithValue("@idhk", cbmaky.SelectedValue);
                        cmd.Parameters.AddWithValue("@dm", float.Parse(txtdmieng.Text));
                        cmd.Parameters.AddWithValue("@d15", float.Parse(txt15.Text));
                        cmd.Parameters.AddWithValue("@d45", float.Parse(txt45.Text));
                        cmd.Parameters.AddWithValue("@dt", float.Parse(txtdthi.Text));
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                        cnn.Close();
  //                      MessageBox.Show(txtmahs.Text +cbmalop.SelectedValue + cbmamon.SelectedValue+  cbmanam.SelectedValue+ cbmaky.SelectedValue+ txtdmieng.Text+ txtdthi.Text +txt45.Text+ txt15.Text);
                    }
                    catch
                    {
                        MessageBox.Show("loi khi sua", "error", MessageBoxButtons.OK);

                    }

                    loaddt();
                }
              
                clearkq();
            }
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_ThemKQHS", cnn))
                {
                    try
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@id", txtmahs.Text);
                        cmd.Parameters.AddWithValue("@idlop", cbmalop.SelectedValue);
                        cmd.Parameters.AddWithValue("@idMh", cbmamon.SelectedValue);
                        cmd.Parameters.AddWithValue("@idnam", cbmanam.SelectedValue);
                        cmd.Parameters.AddWithValue("@idhk", cbmaky.SelectedValue);
                        cmd.Parameters.AddWithValue("@dm", float.Parse(txtdmieng.Text));
                        cmd.Parameters.AddWithValue("@d15", float.Parse(txt15.Text));
                        cmd.Parameters.AddWithValue("@d45", float.Parse(txt45.Text));
                        cmd.Parameters.AddWithValue("@dt", float.Parse(txtdthi.Text));
                        cnn.Open();
                        cmd.ExecuteNonQuery();
                    }
                    catch
                    {
                        MessageBox.Show("loi khi them", "error", MessageBoxButtons.OK);
                        
                    }
                 
                    loaddt();
                }
                cnn.Close();
                clearkq();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int RowIndex = datalistkqhs.CurrentRow.Index;
            datalistkqhs.Rows.RemoveAt(RowIndex);
            clearkq();
        }

        private void btnboqua_Click(object sender, EventArgs e)
        {
            clearkq();
            dnb();
           // btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnboqua.Enabled = false;
        }

        private void datalistkqhs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            enb();
            txtmahs.Text = datalistkqhs.CurrentRow.Cells["Mã HS"].Value.ToString();
            cbmalop.Text= datalistkqhs.CurrentRow.Cells[2].Value.ToString();
            cbmamon.Text = datalistkqhs.CurrentRow.Cells[3].Value.ToString();
            cbmanam.Text = datalistkqhs.CurrentRow.Cells[4].Value.ToString();
            cbmaky.Text = datalistkqhs.CurrentRow.Cells[5].Value.ToString();
            txtdmieng.Text = datalistkqhs.CurrentRow.Cells["Điểm miệng"].Value.ToString();
            txt15.Text = datalistkqhs.CurrentRow.Cells["Điểm 15"].Value.ToString();
            txt45.Text = datalistkqhs.CurrentRow.Cells["Điểm 45"].Value.ToString();
            txtdthi.Text = datalistkqhs.CurrentRow.Cells["Điểm thi"].Value.ToString();
            txtdtb.Text = datalistkqhs.CurrentRow.Cells["DTB"].Value.ToString();
            btnthem.Enabled = true;
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
            btnboqua.Enabled = true;
        }

        private void cbmalop_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnthem.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
