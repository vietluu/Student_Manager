using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace QLHS_Winforms

{
   
    public partial class ReportGv : Form
    {
        ReportDocument rp = new ReportDocument();
        public ReportGv()
        {
            InitializeComponent();
        }
        private void login()
        {
            rp.Load(@"C:\Users\HP\Desktop\QLHS_Winforms\QLHS_Winforms\QLHS_Winforms\CrystalReportGv.rpt");
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
        private void comboBox1Load()
        {
            string conn = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString; using (SqlConnection cnn = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand("select*from tblGiaoVien", cnn))
                {
                    cnn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        adapter.Fill(tb);
                        comboBox1.DataSource = tb;
                        comboBox1.DisplayMember = "sTenGV";
                        comboBox1.ValueMember = "sMaGV";
                    }
                }
            }
        }


        private void loadData()
        {
         login();
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1Load();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = comboBox1.Text;
            login();
            ParameterFieldDefinition rpd = rp.DataDefinition.ParameterFields["MaGV"];
            rp.RecordSelectionFormula = "{tblGiaoVien.sTenGV} = {?MaGV}";
            ParameterValues pvl = new ParameterValues();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pdv.Value = value;
            pvl.Add(pdv);
            rpd.CurrentValues.Clear();
            rpd.ApplyCurrentValues(pvl);
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }


    }
}