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
    public partial class ReportHs : Form
    {
        ReportDocument rp = new ReportDocument();
        string constr = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public ReportHs()
        {
            InitializeComponent();
        }

        private void ReportHs_Load(object sender, EventArgs e)
        {
            hienmalop();
            hienma();
            login();
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();

        }
        private void login()
        {
            rp.Load(@"C:\Users\HP\Desktop\QLHS_Winforms\QLHS_Winforms\QLHS_Winforms\CrystalReport3.rpt");
            TableLogOnInfo logon = new TableLogOnInfo();
            logon.ConnectionInfo.ServerName = @"HP\SQLEXPRESS";
            logon.ConnectionInfo.DatabaseName = "qlhocsinh";
            logon.ConnectionInfo.UserID = "sa";
            logon.ConnectionInfo.Password = "123456";
            foreach (Table t in rp.Database.Tables)
            {
                t.ApplyLogOnInfo(logon);
            }
        }
        private DataTable laymlop()
        {

            using (SqlConnection cnn = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("select sTenHS from tblHocSinh", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable("hs");
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
            v.Sort = "sTenHS";
            comboBox1.DataSource = v;
            comboBox1.DisplayMember = "sTenHS";
            comboBox1.ValueMember = "sTenHS";
        }
        private DataTable laym()
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
        private void hienma()
        {
            DataTable t = laym();
            DataView v = new DataView(t);
            v.Sort = "sMalop";
            comboBox2.DataSource = v;
            comboBox2.DisplayMember = "sLop";
            comboBox2.ValueMember = "sMalop";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string value = comboBox1.Text;
            login();
            ParameterFieldDefinition rpd = rp.DataDefinition.ParameterFields["Hs"];
            ParameterFieldDefinition rpd1 = rp.DataDefinition.ParameterFields["lop"];
            rp.RecordSelectionFormula = "{tblHocSinh.sTenHS} = {?Hs} and  {tblLop.sLop} = {?lop}";
            
            ParameterValues pvl = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = value;
            pvl.Add(pdv);
           
            rpd.CurrentValues.Clear();
            rpd.ApplyCurrentValues(pvl);
            pdv.Value = comboBox2.Text;
            pvl.Add(pdv);
            rpd1.CurrentValues.Clear();
            rpd1.ApplyCurrentValues(pvl);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }
    }
}
