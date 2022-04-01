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
    public partial class DemSoLopTheoGV : Form
    {
        public DemSoLopTheoGV()
        {
            InitializeComponent();
        }

        private void DemSoLopTheoGV_Load(object sender, EventArgs e)
        {
            string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString; ;
            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select sMaGV as[Mã GV], count(sMalop) as[Số lớp] from tblLop group by sMaGV", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using(SqlDataAdapter da= new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datatklop.DataSource = tb;
                    }
                }
            }
        }

    }
}
