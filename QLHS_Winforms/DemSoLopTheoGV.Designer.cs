
namespace QLHS_Winforms
{
    partial class DemSoLopTheoGV
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
            this.label1 = new System.Windows.Forms.Label();
            this.datatklop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datatklop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê số lớp chủ nhiệm của Giáo viên";
            // 
            // datatklop
            // 
            this.datatklop.AllowUserToAddRows = false;
            this.datatklop.AllowUserToDeleteRows = false;
            this.datatklop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatklop.Enabled = false;
            this.datatklop.Location = new System.Drawing.Point(22, 73);
            this.datatklop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.datatklop.Name = "datatklop";
            this.datatklop.ReadOnly = true;
            this.datatklop.RowHeadersWidth = 62;
            this.datatklop.RowTemplate.Height = 28;
            this.datatklop.Size = new System.Drawing.Size(500, 208);
            this.datatklop.TabIndex = 1;
            // 
            // DemSoLopTheoGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.datatklop);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "DemSoLopTheoGV";
            this.Text = "DemSoLopTheoGV";
            this.Load += new System.EventHandler(this.DemSoLopTheoGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatklop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datatklop;
    }
}