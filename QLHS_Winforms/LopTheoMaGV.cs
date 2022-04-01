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
    public partial class LopTheoMaGV : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public LopTheoMaGV()
        {
            InitializeComponent();
        }

        private void LopTheoMaGV_Load(object sender, EventArgs e)
        {
            hienmgv();
            loaddatalop();
        }

        private void loaddatalop()
        {

            using (SqlConnection cnn= new SqlConnection(constr))
            {
                using (SqlCommand cmd= new SqlCommand("Select sMalop as[Mã lớp], sLop as[Lớp], sMaGV as[Mã GV], iSiso as[Sĩ số] from tblLop", cnn))
                {
                    using (SqlDataAdapter da= new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datalop.DataSource = tb;
                    }
                }
            }
        }
        private DataTable laymgv()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblGiaoVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("GiaoVien");
                        da.Fill(tb);
                        return tb;
                    }
                }
            }
        }
        private void hienmgv()
        {
            DataTable t = laymgv();
            DataView v = new DataView(t);
            v.Sort = "sMaGV";
            combomagv.DataSource = v;
            combomagv.DisplayMember = "sMaGV";
            combomagv.ValueMember = "sMaGV";
        }

        private void combomagv_SelectedIndexChanged(object sender, EventArgs e)
        {

            using (SqlConnection cnn= new SqlConnection(constr))
            {
                using (SqlCommand cmd= new SqlCommand("Select sMalop as[Mã lớp], sLop as[Lớp], sMaGV as[Mã GV], iSiso as[Sĩ số] from tblLop where sMaGV like '%" + combomagv.Text+"%'", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da= new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        datalop.DataSource = tb;
                        //DataSet ds = new DataSet();
                        //da.Fill(ds,"Lop");
                        //datalop.DataSource = ds.Tables["Lop"];
                    }
                }
            }
        }

        private void btnrefresh_Click(object sender, EventArgs e)
        {
            loaddatalop();
        }
    }
}
