
namespace QLHS_Winforms
{
    partial class DemSoHSTheoGT
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
            this.datahstheogt = new System.Windows.Forms.DataGridView();
            this.datatkhstheolop = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datahstheogt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatkhstheolop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thong ke so Hoc sinh ";
            // 
            // datahstheogt
            // 
            this.datahstheogt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datahstheogt.Location = new System.Drawing.Point(411, 87);
            this.datahstheogt.Name = "datahstheogt";
            this.datahstheogt.RowHeadersWidth = 62;
            this.datahstheogt.RowTemplate.Height = 28;
            this.datahstheogt.Size = new System.Drawing.Size(338, 206);
            this.datahstheogt.TabIndex = 1;
            // 
            // datatkhstheolop
            // 
            this.datatkhstheolop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatkhstheolop.Location = new System.Drawing.Point(37, 87);
            this.datatkhstheolop.Name = "datatkhstheolop";
            this.datatkhstheolop.RowHeadersWidth = 62;
            this.datatkhstheolop.RowTemplate.Height = 28;
            this.datatkhstheolop.Size = new System.Drawing.Size(352, 206);
            this.datatkhstheolop.TabIndex = 2;
            // 
            // DemSoHSTheoGT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datatkhstheolop);
            this.Controls.Add(this.datahstheogt);
            this.Controls.Add(this.label1);
            this.Name = "DemSoHSTheoGT";
            this.Text = "DemSoHSTheoGT";
            this.Load += new System.EventHandler(this.DemSoHSTheoGT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datahstheogt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatkhstheolop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datahstheogt;
        private System.Windows.Forms.DataGridView datatkhstheolop;
    }
}