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
using System.Globalization;

namespace QLHS_Winforms
{
    public partial class HocSinh : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public HocSinh()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            loaddata();
            
        }
        private void loaddata()
        {
            lisths.Enabled = true;

            
            using (SqlConnection cnn= new SqlConnection(constr))
            {
                using (SqlCommand cmd= new SqlCommand("select sMaHS as[Mã HS], sTenHS as[Họ tên], dNgaysinh as[Ngày sinh], sGioitinh as[Giới tính],SDiachi as[Địa chỉ], sSDT as[SDT], fHocphi as[Học Phí], sTrangthaiHP as[Trạng thái HP] from tblHocSinh", cnn))
                {
                    using (SqlDataAdapter da= new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        lisths.DataSource = tb;
                    }
                   
                }
            }
            lisths.Columns.Add("Column", "Test");
            foreach (DataGridViewRow dt in lisths.Rows)
            {
                DateTime ns1 = Convert.ToDateTime(dt.Cells[3].Value.ToString());
                DateTime today1 = DateTime.Today;
                int tuoi1= today1.Year - ns1.Year;
                DataGridViewCell cell = new DataGridViewTextBoxCell();
                cell.Value = "hi";
                dt.Cells[9].Value = cell;

                
                
                                
            }




        }
        private void cleardata()
        {
            txtmahs.Clear();
            txthoten.Clear();
            txtns.Clear();
          //  txtgt.Clear();
            txtdc.Clear();
            txtdt.Clear();
            txthp.Clear();
            txttrangthaihp.Clear();
        }
        private void enb()
        {
            txtmahs.Enabled = true;
            txthoten.Enabled = true;
            txtns.Enabled = true;
            txtgt.Enabled = true;
            txtdc.Enabled = true;
            txtdt.Enabled = true;
            txthp.Enabled = true;
            txttrangthaihp.Enabled = true;
        }
        private void dnb()
        {
            txtmahs.Enabled = false;
            txthoten.Enabled = false;
            txtns.Enabled = false;
            txtgt.Enabled = false;
            txtdc.Enabled = false;
            txtdt.Enabled = false;
            txthp.Enabled = false;
            txttrangthaihp.Enabled = false;
        }
        private void btnthem_Click(object sender, EventArgs e)
        {
            cleardata();
            enb();
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            txtmahs.Focus();
            txtgt.SelectedIndex = 0;
        }
        private bool check(String connectingString, String id)
        {
            string q = "select* from tblHocSinh";
            using (SqlConnection cnn = new SqlConnection(connectingString))
            {
                using (SqlCommand cmd = new SqlCommand(q, cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (id == rd.GetString(0))
                                return true;
                        }
                        rd.Close();
                        cnn.Close();
                        return false;
                    }
                }
            }
        }
        private void btnluu_Click(object sender, EventArgs e)
        {
            DateTime ns = Convert.ToDateTime(txtns.Text);
            DateTime today = DateTime.Today;
            int tuoi = today.Year - ns.Year;
            if (tuoi >= 15 && tuoi <= 18)
            {
                //string constr = ConfigurationManager.ConnectionStrings["QLHocSinh_BTL"].ConnectionString;
                if(check(constr, txtmahs.Text.ToUpper())== true)
                {
                    MessageBox.Show("ma sinh vien da ton tai", "error", MessageBoxButtons.OK);
                }
                else
                {
                    using (SqlConnection cnn = new SqlConnection(constr))
                    {
                        using (SqlCommand cmd = new SqlCommand())
                        {

                            cmd.Connection = cnn;
                            cmd.CommandText = "sp_addHocsinh";
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.Parameters.AddWithValue("@idst", txtmahs.Text.ToUpper());
                            cmd.Parameters.AddWithValue("@name", CultureInfo.InvariantCulture.TextInfo.ToTitleCase(txthoten.Text.ToLower()));
                            //  DateTime Ns = Convert.ToDateTime(txtns.Text);
                            cmd.Parameters.AddWithValue("@date", ns.ToString("yyyy - MM - dd"));
                            cmd.Parameters.AddWithValue("@gt", txtgt.Text);
                            cmd.Parameters.AddWithValue("@addr", txtdc.Text);
                            cmd.Parameters.AddWithValue("@sdt", txtdt.Text);
                            cmd.Parameters.AddWithValue("@cost", txthp.Text);
                            cmd.Parameters.AddWithValue("@state", txttrangthaihp.Text);
                            cnn.Open();
                            cmd.ExecuteNonQuery();
                            loaddata();
                            cnn.Close();
                            cleardata();
                            //dnb();
                            //btnluu.Enabled = false;
                            //btnhuy.Enabled = false;
                        }
                    }
                }
              
            }
            else
            {
                MessageBox.Show("ngay sinh khong phu hop", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtns.Clear();


            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int RowIndex = lisths.CurrentRow.Index;
            lisths.Rows.RemoveAt(RowIndex);
            cleardata();
        }

        private void lisths_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmahs.Text = lisths.CurrentRow.Cells["Mã HS"].Value.ToString();
            txthoten.Text = lisths.CurrentRow.Cells["Họ tên"].Value.ToString();
            //DateTime ns = Convert.ToDateTime(lisths.CurrentRow.Cells["Ngày sinh"].Value);
            //txtns.Text = ns.ToString("yyyy - MM - dd");
            txtns.Text = lisths.CurrentRow.Cells["Ngày sinh"].Value.ToString();
            txtgt.Text = lisths.CurrentRow.Cells["Giới tính"].Value.ToString();
            txtdc.Text = lisths.CurrentRow.Cells["Địa chỉ"].Value.ToString();
            txtdt.Text = lisths.CurrentRow.Cells["SDT"].Value.ToString();
            txthp.Text = lisths.CurrentRow.Cells["Học Phí"].Value.ToString();
            txttrangthaihp.Text = lisths.CurrentRow.Cells["Trạng thái HP"].Value.ToString();
            txtmahs.Focus();
            enb();
            btnxoa.Enabled = true;
            btnluu.Enabled = true;
            btnhuy.Enabled = true;
            btnthem.Enabled = false;
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            cleardata();
            dnb();
            btnhuy.Enabled = false;
            btnluu.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled= true; 
        }

        private void lisths_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            KQ_HS_MonHoc kq = new KQ_HS_MonHoc();
            string ma = txtmahs.Text;
            string name = txthoten.Text;
            kq.getValue(ma,name);

            kq.Show();
        }

        private void lisths_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
