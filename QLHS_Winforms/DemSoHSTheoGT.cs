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
    public partial class DemSoHSTheoGT : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public DemSoHSTheoGT()
        {
            InitializeComponent();
            
        }
        
        private void DemTheoGT()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select sGioitinh as[Giới tính], count(sMaHS) as[Số HS] from tblHocSinh group by sGioitinh", cnn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datahstheogt.DataSource = tb;
                    }
                }
            }
        }

        private void DemTheoLop()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select tblLop.sMalop as[Mã lớp], count(tblKQ_HOCSINH_MONHOC.sMaHS) as[Số HS] from ((tblLop inner join tblKQ_HOCSINH_MONHOC on " +
                    "tblLop.sMalop= tblKQ_HOCSINH_MONHOC.sMaLop) inner join tblHocSinh on tblKQ_HOCSINH_MONHOC.sMaHS= tblHocSinh.sMaHS) group by tblLop.sMalop", cnn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datatkhstheolop.DataSource = tb;
                    }
                }
            }
        }
        private void DemSoHSTheoGT_Load(object sender, EventArgs e)
        {
            DemTheoGT();
            DemTheoLop();
        }

    }
}
