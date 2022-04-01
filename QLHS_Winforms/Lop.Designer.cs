
namespace QLHS_Winforms
{
    partial class Lop
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmalop = new System.Windows.Forms.TextBox();
            this.txtlop = new System.Windows.Forms.TextBox();
            this.listmagv = new System.Windows.Forms.ComboBox();
            this.listlop = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txttim = new System.Windows.Forms.TextBox();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btntim = new System.Windows.Forms.Button();
            this.btnluulai = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listlop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(245, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Giáo viên";
            // 
            // txtmalop
            // 
            this.txtmalop.Enabled = false;
            this.txtmalop.Location = new System.Drawing.Point(98, 20);
            this.txtmalop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmalop.Name = "txtmalop";
            this.txtmalop.Size = new System.Drawing.Size(99, 20);
            this.txtmalop.TabIndex = 4;
            // 
            // txtlop
            // 
            this.txtlop.Enabled = false;
            this.txtlop.Location = new System.Drawing.Point(98, 57);
            this.txtlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtlop.Name = "txtlop";
            this.txtlop.Size = new System.Drawing.Size(99, 20);
            this.txtlop.TabIndex = 5;
            // 
            // listmagv
            // 
            this.listmagv.AllowDrop = true;
            this.listmagv.Enabled = false;
            this.listmagv.FormattingEnabled = true;
            this.listmagv.Location = new System.Drawing.Point(317, 19);
            this.listmagv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listmagv.Name = "listmagv";
            this.listmagv.Size = new System.Drawing.Size(109, 21);
            this.listmagv.TabIndex = 6;
            // 
            // listlop
            // 
            this.listlop.AllowUserToAddRows = false;
            this.listlop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listlop.Location = new System.Drawing.Point(64, 127);
            this.listlop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listlop.Name = "listlop";
            this.listlop.RowHeadersWidth = 62;
            this.listlop.RowTemplate.Height = 28;
            this.listlop.Size = new System.Drawing.Size(396, 97);
            this.listlop.TabIndex = 8;
            this.listlop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listlop_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 98);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nhập Mã lớp muốn tìm";
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(198, 96);
            this.txttim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(99, 20);
            this.txttim.TabIndex = 10;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(90, 242);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(47, 24);
            this.btnthem.TabIndex = 11;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(158, 242);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(47, 24);
            this.btnluu.TabIndex = 12;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Location = new System.Drawing.Point(363, 242);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(47, 24);
            this.btnhuy.TabIndex = 13;
            this.btnhuy.Text = "Hủy";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(221, 242);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(47, 24);
            this.btnxoa.TabIndex = 14;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btntim
            // 
            this.btntim.Location = new System.Drawing.Point(323, 92);
            this.btntim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntim.Name = "btntim";
            this.btntim.Size = new System.Drawing.Size(53, 27);
            this.btntim.TabIndex = 15;
            this.btntim.Text = "Tìm";
            this.btntim.UseVisualStyleBackColor = true;
            this.btntim.Click += new System.EventHandler(this.btntim_Click);
            // 
            // btnluulai
            // 
            this.btnluulai.Enabled = false;
            this.btnluulai.Location = new System.Drawing.Point(284, 242);
            this.btnluulai.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnluulai.Name = "btnluulai";
            this.btnluulai.Size = new System.Drawing.Size(61, 24);
            this.btnluulai.TabIndex = 16;
            this.btnluulai.Text = "Lưu lại";
            this.btnluulai.UseVisualStyleBackColor = true;
            this.btnluulai.Click += new System.EventHandler(this.btnluulai_Click);
            // 
            // Lop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btnluulai);
            this.Controls.Add(this.btntim);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listlop);
            this.Controls.Add(this.listmagv);
            this.Controls.Add(this.txtlop);
            this.Controls.Add(this.txtmalop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Lop";
            this.Text = "Lop";
            this.Load += new System.EventHandler(this.Lop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listlop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmalop;
        private System.Windows.Forms.TextBox txtlop;
        private System.Windows.Forms.ComboBox listmagv;
        private System.Windows.Forms.DataGridView listlop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btntim;
        private System.Windows.Forms.Button btnluulai;
    }
}