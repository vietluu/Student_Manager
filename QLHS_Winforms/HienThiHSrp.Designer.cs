
namespace QLHS_Winforms
{
    partial class HienThiHSrp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboloprp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rphstheolop = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboloprp
            // 
            this.comboloprp.FormattingEnabled = true;
            this.comboloprp.Location = new System.Drawing.Point(221, 29);
            this.comboloprp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboloprp.Name = "comboloprp";
            this.comboloprp.Size = new System.Drawing.Size(82, 21);
            this.comboloprp.TabIndex = 0;
            this.comboloprp.SelectedIndexChanged += new System.EventHandler(this.comboloprp_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chon Ma lop";
            // 
            // rphstheolop
            // 
            this.rphstheolop.ActiveViewIndex = -1;
            this.rphstheolop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rphstheolop.Cursor = System.Windows.Forms.Cursors.Default;
            this.rphstheolop.Location = new System.Drawing.Point(1, 53);
            this.rphstheolop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rphstheolop.Name = "rphstheolop";
            this.rphstheolop.Size = new System.Drawing.Size(535, 242);
            this.rphstheolop.TabIndex = 2;
            this.rphstheolop.ToolPanelWidth = 133;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(335, 27);
            this.btnload.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(54, 23);
            this.btnload.TabIndex = 3;
            this.btnload.Text = "Refresh";
            this.btnload.UseVisualStyleBackColor = true;
            // 
            // HienThiHSrp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 313);
            this.Controls.Add(this.btnload);
            this.Controls.Add(this.rphstheolop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboloprp);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HienThiHSrp";
            this.Text = "HienThiHSrp";
            this.Load += new System.EventHandler(this.HienThiHSrp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboloprp;
        private System.Windows.Forms.Label label1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer rphstheolop;
        private System.Windows.Forms.Button btnload;
    }
}