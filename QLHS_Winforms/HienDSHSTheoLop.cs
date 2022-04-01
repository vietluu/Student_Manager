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
//using System.Windows.Forms.RibbonForm;


namespace QLHS_Winforms
{
    public partial class HienDSHSTheoLop : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public HienDSHSTheoLop()
        {
            InitializeComponent();
        }

        private void HienDSHSTheoLop_Load(object sender, EventArgs e)
        {
            hienmalop();
            loaddt();
        }
        private void loaddt()
        {

            using (SqlConnection cnn= new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select sMaHS as[Mã HS], sTenHS as[Họ tên], dNgaysinh as[Ngày sinh], sGioitinh as[Giới tính], SDiachi as [Địa chỉ], sSDT as[SDT] from tblHocSinh", cnn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datahstheolop.DataSource = tb;
                    }
                }
            }
        }
        //((tblHocSinh inner join tblKQ_HOCSINH_MONHOC on " +
          //          "tblHocSinh.sMaHS= tblKQ_HOCSINH_MONHOC.sMaHS) inner join tblLop on tblKQ_HOCSINH_MONHOC.sMaLop= tblLop.sMalop)
        private DataTable laymalop()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblLop", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("Lop");
                        da.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienmalop()
        {
            DataTable t = laymalop();
            DataView v = new DataView(t);
            v.Sort = "sMalop";
            combolop.DataSource = v;
            combolop.DisplayMember = "sMalop";
            combolop.ValueMember = "sMalop";
        }

        private void combolop_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("Select tblHocSinh.sMaHS as[Mã HS], sTenHS as[Họ tên], dNgaysinh as[Ngày sinh], sGioitinh as[Giới tính], SDiachi as [Địa chỉ], sSDT as[SDT] from ((tblHocSinh inner join tblKQ_HOCSINH_MONHOC on " +
                              "tblHocSinh.sMaHS= tblKQ_HOCSINH_MONHOC.sMaHS) inner join tblLop on tblKQ_HOCSINH_MONHOC.sMaLop= tblLop.sMalop)" +
                    "where tblKQ_HOCSINH_MONHOC.sMaLop like '%" + combolop.Text + "%'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datahstheolop.DataSource = tb;
                    }
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            loaddt();
        }

        private void HienDSHSTheoLop_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Ban thuc su muon thoat?", "Canh bao!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            HienThiHSrp ht = new HienThiHSrp();
            ht.Show();
        }
    }
}
