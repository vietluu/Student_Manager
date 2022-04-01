using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace QLHS_Winforms
{
    public partial class Lop : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public Lop()
        {
            InitializeComponent();
        }

        private void Lop_Load(object sender, EventArgs e)
        {
            loaddtlop();
            hienmagv();
        }
        private void loaddtlop()
        {

            using (SqlConnection cnn= new SqlConnection(constr))
            {
                using (SqlCommand cmd= new SqlCommand("select tblLop.sMalop as[Mã lớp] ,tblLop.sLop as [lớp],tblLop.sMaGV as[mã giáo viên] , count(tblKQ_HOCSINH_MONHOC.sMaHS) as [Sĩ số] from((tblKQ_HOCSINH_MONHOC inner join tblHocSinh on tblKQ_HOCSINH_MONHOC.sMaHS = tblHocSinh.sMaHS) inner join tblLop on tblKQ_HOCSINH_MONHOC.sMaLop = tblLop.sMalop) where tblKQ_HOCSINH_MONHOC.sMaLop = tblLop.sMalop group by tblLop.sLop,tblLop.sMalop,tblLop.sMaGV; ", cnn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        listlop.DataSource = tb;
                    }
                }
            }
        }
        private void enb()
        {
            txtmalop.Enabled = true;
            txtlop.Enabled = true;
            listmagv.Enabled = true;
            //txtss.Enabled = true;
        }
        private void cleardtlop()
        {
            txtmalop.Clear();
            txtlop.Clear();
            //listmagv.Items.Clear();
           // txtss.Clear();
        }
        private DataTable laymagv()
        {

            using (SqlConnection cnn= new SqlConnection(constr))
            {
                using (SqlCommand cmd= new SqlCommand("select * from tblGiaoVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("HS");
                       da.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienmagv()
        {
            DataTable t = laymagv();
            DataView v = new DataView(t);
            v.Sort = "sMaGV";
            listmagv.DataSource = v;
            listmagv.DisplayMember = "sMaGV";
            listmagv.ValueMember = "sMaGV";
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            enb();
            txtmalop.Focus();
            txttim.Enabled = false;
            btntim.Enabled = false;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            //hienmagv();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn= new SqlConnection(constr))
            {
                using (SqlCommand cmd= new SqlCommand("sp_addLop", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idcl", txtmalop.Text);
                    cmd.Parameters.AddWithValue("@cl", txtlop.Text);
                    cmd.Parameters.AddWithValue("@teacherId", listmagv.SelectedValue);
                    cmd.Parameters.AddWithValue("@count", 0);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    loaddtlop();
                }
                cnn.Close();
                cleardtlop();
            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cleardtlop();
            txtmalop.Enabled = false;
            txtlop.Enabled = false;
            listmagv.Enabled = false;
        //    txtss.Enabled = false;
            btnthem.Enabled = true;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnhuy.Enabled = false;
            txttim.Enabled = true;
            btntim.Enabled = true;
            btnluulai.Enabled = false;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int RowIndex = listlop.CurrentRow.Index;
            listlop.Rows.RemoveAt(RowIndex);
            cleardtlop ();
        }

        private void listlop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmalop.Text = listlop.CurrentRow.Cells["Mã lớp"].Value.ToString();
            txtlop.Text = listlop.CurrentRow.Cells["Lớp"].Value.ToString();
            listmagv.Text = listlop.CurrentRow.Cells[2].Value.ToString();
            //txtss.Text = listlop.CurrentRow.Cells["Sĩ số"].Value.ToString();
            enb();
            txttim.Enabled = false;
            btntim.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = true;
            btnhuy.Enabled = true;
            btnthem.Enabled = false;
            btnluulai.Enabled = true;
            txtlop.Focus();
            txtmalop.Enabled = false;
        }

        private void btnluulai_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_Sualop", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idcl", txtmalop.Text);
                    cmd.Parameters.AddWithValue("@cl", txtlop.Text);
                    cmd.Parameters.AddWithValue("@teacherId", listmagv.SelectedValue);
                 cmd.Parameters.AddWithValue("@count", null);
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                    loaddtlop();
                }
                cnn.Close();
                cleardtlop();
                txtlop.Focus();
            }
        }

        private void btntim_Click(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("sp_TimLopTheoMa", cnn))
                {
                    
                }
            }
        }
    }
}
