using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
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
    public partial class HienThiHSrp : Form
    {
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public HienThiHSrp()
        {
            InitializeComponent();
        }

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
            comboloprp.DataSource = v;
            comboloprp.DisplayMember = "sMalop";
            comboloprp.ValueMember = "sMalop";
        }

        private void hienthihsrp()
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"D:\C#Code\QLHS_Winforms\QLHS_Winforms\HTHSTheoLop.rpt");
            rphstheolop.ReportSource = rd;
            rphstheolop.Refresh();
        }
        private void HienThiHSrp_Load(object sender, EventArgs e)
        {
            hienmalop();
            hienthihsrp();
        }

        private void comboloprp_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"D:\C#Code\QLHS_Winforms\QLHS_Winforms\HTHSTheoLop.rpt");
            ParameterFieldDefinition pfd = rd.DataDefinition.ParameterFields["malop"];
            ParameterValues pv = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = comboloprp.Text;
            pv.Add(pdv);
            pfd.CurrentValues.Clear();
            pfd.ApplyCurrentValues(pv);
            rphstheolop.ReportSource = rd;
            rphstheolop.Refresh();
        }
    }
}
