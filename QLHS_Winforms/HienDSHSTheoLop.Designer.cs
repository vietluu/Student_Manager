
namespace QLHS_Winforms
{
    partial class HienDSHSTheoLop
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
            this.combolop = new System.Windows.Forms.ComboBox();
            this.datahstheolop = new System.Windows.Forms.DataGridView();
            this.btnrefresh = new System.Windows.Forms.Button();
            this.btnbaocao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datahstheolop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chon Ma lop";
            // 
            // combolop
            // 
            this.combolop.FormattingEnabled = true;
            this.combolop.Location = new System.Drawing.Point(303, 53);
            this.combolop.Name = "combolop";
            this.combolop.Size = new System.Drawing.Size(121, 28);
            this.combolop.TabIndex = 1;
            this.combolop.SelectedIndexChanged += new System.EventHandler(this.combolop_SelectedIndexChanged);
            // 
            // datahstheolop
            // 
            this.datahstheolop.AllowUserToAddRows = false;
            this.datahstheolop.AllowUserToDeleteRows = false;
            this.datahstheolop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahstheolop.Enabled = false;
            this.datahstheolop.Location = new System.Drawing.Point(34, 112);
            this.datahstheolop.Name = "datahstheolop";
            this.datahstheolop.RowHeadersWidth = 62;
            this.datahstheolop.RowTemplate.Height = 28;
            this.datahstheolop.Size = new System.Drawing.Size(734, 280);
            this.datahstheolop.TabIndex = 2;
            // 
            // btnrefresh
            // 
            this.btnrefresh.Location = new System.Drawing.Point(481, 48);
            this.btnrefresh.Name = "btnrefresh";
            this.btnrefresh.Size = new System.Drawing.Size(82, 36);
            this.btnrefresh.TabIndex = 3;
            this.btnrefresh.Text = "Refresh";
            this.btnrefresh.UseVisualStyleBackColor = true;
            this.btnrefresh.Click += new System.EventHandler(this.btnrefresh_Click);
            // 
            // btnbaocao
            // 
            this.btnbaocao.Location = new System.Drawing.Point(303, 407);
            this.btnbaocao.Name = "btnbaocao";
            this.btnbaocao.Size = new System.Drawing.Size(109, 31);
            this.btnbaocao.TabIndex = 4;
            this.btnbaocao.Text = "Tạo Báo cáo";
            this.btnbaocao.UseVisualStyleBackColor = true;
            this.btnbaocao.Click += new System.EventHandler(this.btnbaocao_Click);
            // 
            // HienDSHSTheoLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnbaocao);
            this.Controls.Add(this.btnrefresh);
            this.Controls.Add(this.datahstheolop);
            this.Controls.Add(this.combolop);
            this.Controls.Add(this.label1);
            this.Name = "HienDSHSTheoLop";
            this.Text = "HienDSHSTheoLop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HienDSHSTheoLop_FormClosing);
            this.Load += new System.EventHandler(this.HienDSHSTheoLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datahstheolop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combolop;
        private System.Windows.Forms.DataGridView datahstheolop;
        private System.Windows.Forms.Button btnrefresh;
        private System.Windows.Forms.Button btnbaocao;
    }
}