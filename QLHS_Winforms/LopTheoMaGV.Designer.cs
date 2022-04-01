
namespace QLHS_Winforms
{
    partial class LopTheoMaGV
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
            this.combomagv = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datalop = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datalop)).BeginInit();
            this.SuspendLayout();
            // 
            // combomagv
            // 
            this.combomagv.FormattingEnabled = true;
            this.combomagv.Location = new System.Drawing.Point(301, 41);
            this.combomagv.Name = "combomagv";
            this.combomagv.Size = new System.Drawing.Size(121, 28);
            this.combomagv.TabIndex = 0;
            this.combomagv.SelectedIndexChanged += new System.EventHandler(this.combomagv_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Chọn mã Giáo viên";
            // 
            // datalop
            // 
            this.datalop.AllowUserToAddRows = false;
            this.datalop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalop.Enabled = false;
            this.datalop.Location = new System.Drawing.Point(51, 110);
            this.datalop.Name = "datalop";
            this.datalop.RowHeadersWidth = 62;
            this.datalop.RowTemplate.Height = 28;
            this.datalop.Size = new System.Drawing.Size(686, 265);
            this.datalop.TabIndex = 2;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(503, 37);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(82, 35);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // LopTheoMaGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.datalop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combomagv);
            this.Name = "LopTheoMaGV";
            this.Text = "LopTheoMaGV";
            this.Load += new System.EventHandler(this.LopTheoMaGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combomagv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datalop;
        private System.Windows.Forms.Button btnrefresh;
    }
}