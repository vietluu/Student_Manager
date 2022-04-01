using System;
using System.Collections.Generic;
using System.ComponentModel;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Windows.Forms;
using System.Globalization;

namespace QLHS_Winforms
{
    public partial class baocaomon : Form
    {
        ReportDocument rp = new ReportDocument();
        public baocaomon()
        {
            InitializeComponent();
        }

        private void login()
        {
            rp.Load(@"C:\Users\HP\Desktop\QLHS_Winforms\QLHS_Winforms\QLHS_Winforms\CrystalReport2.rpt");
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

        private void Form2_Load(object sender, EventArgs e)
        {

            login();
            rp.RecordSelectionFormula = "{tblMonHoc.sMon} <> '' and {tblMonHoc.iTongtiet} <100 ";
            crystalReportViewer1.ReportSource = rp;
            crystalReportViewer1.Refresh();


        }
    }
}
