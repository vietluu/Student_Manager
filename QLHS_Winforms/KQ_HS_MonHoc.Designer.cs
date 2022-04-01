
namespace QLHS_Winforms
{
    partial class KQ_HS_MonHoc
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
            this.cbmamon = new System.Windows.Forms.ComboBox();
            this.cbmalop = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmanam = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbmaky = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdmieng = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt15 = new System.Windows.Forms.TextBox();
            this.txt45 = new System.Windows.Forms.TextBox();
            this.txtdthi = new System.Windows.Forms.TextBox();
            this.txtdtb = new System.Windows.Forms.TextBox();
            this.datalistkqhs = new System.Windows.Forms.DataGridView();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datalistkqhs)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "lớp";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "môn";
            // 
            // cbmamon
            // 
            this.cbmamon.FormattingEnabled = true;
            this.cbmamon.Location = new System.Drawing.Point(72, 103);
            this.cbmamon.Margin = new System.Windows.Forms.Padding(2);
            this.cbmamon.Name = "cbmamon";
            this.cbmamon.Size = new System.Drawing.Size(82, 21);
            this.cbmamon.TabIndex = 4;
            // 
            // cbmalop
            // 
            this.cbmalop.FormattingEnabled = true;
            this.cbmalop.Location = new System.Drawing.Point(72, 69);
            this.cbmalop.Margin = new System.Windows.Forms.Padding(2);
            this.cbmalop.Name = "cbmalop";
            this.cbmalop.Size = new System.Drawing.Size(82, 21);
            this.cbmalop.TabIndex = 5;
            this.cbmalop.SelectedIndexChanged += new System.EventHandler(this.cbmalop_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 148);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = " năm";
            // 
            // cbmanam
            // 
            this.cbmanam.FormattingEnabled = true;
            this.cbmanam.Location = new System.Drawing.Point(72, 140);
            this.cbmanam.Margin = new System.Windows.Forms.Padding(2);
            this.cbmanam.Name = "cbmanam";
            this.cbmanam.Size = new System.Drawing.Size(82, 21);
            this.cbmanam.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 185);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(21, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = " kỳ";
            // 
            // cbmaky
            // 
            this.cbmaky.FormattingEnabled = true;
            this.cbmaky.Location = new System.Drawing.Point(72, 177);
            this.cbmaky.Margin = new System.Windows.Forms.Padding(2);
            this.cbmaky.Name = "cbmaky";
            this.cbmaky.Size = new System.Drawing.Size(82, 21);
            this.cbmaky.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 216);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điểm miệng";
            // 
            // txtdmieng
            // 
            this.txtdmieng.Location = new System.Drawing.Point(86, 212);
            this.txtdmieng.Margin = new System.Windows.Forms.Padding(2);
            this.txtdmieng.Name = "txtdmieng";
            this.txtdmieng.Size = new System.Drawing.Size(68, 20);
            this.txtdmieng.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 251);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Điểm 15";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 288);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Điểm 45";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 324);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Điểm thi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 359);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "DTB";
            // 
            // txt15
            // 
            this.txt15.Location = new System.Drawing.Point(86, 251);
            this.txt15.Margin = new System.Windows.Forms.Padding(2);
            this.txt15.Name = "txt15";
            this.txt15.Size = new System.Drawing.Size(68, 20);
            this.txt15.TabIndex = 16;
            // 
            // txt45
            // 
            this.txt45.Location = new System.Drawing.Point(86, 284);
            this.txt45.Margin = new System.Windows.Forms.Padding(2);
            this.txt45.Name = "txt45";
            this.txt45.Size = new System.Drawing.Size(68, 20);
            this.txt45.TabIndex = 17;
            // 
            // txtdthi
            // 
            this.txtdthi.Location = new System.Drawing.Point(86, 320);
            this.txtdthi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdthi.Name = "txtdthi";
            this.txtdthi.Size = new System.Drawing.Size(68, 20);
            this.txtdthi.TabIndex = 18;
            // 
            // txtdtb
            // 
            this.txtdtb.Location = new System.Drawing.Point(86, 356);
            this.txtdtb.Margin = new System.Windows.Forms.Padding(2);
            this.txtdtb.Name = "txtdtb";
            this.txtdtb.ReadOnly = true;
            this.txtdtb.Size = new System.Drawing.Size(68, 20);
            this.txtdtb.TabIndex = 19;
            // 
            // datalistkqhs
            // 
            this.datalistkqhs.AllowUserToAddRows = false;
            this.datalistkqhs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datalistkqhs.Location = new System.Drawing.Point(189, 23);
            this.datalistkqhs.Margin = new System.Windows.Forms.Padding(2);
            this.datalistkqhs.Name = "datalistkqhs";
            this.datalistkqhs.RowHeadersVisible = false;
            this.datalistkqhs.RowHeadersWidth = 62;
            this.datalistkqhs.RowTemplate.Height = 28;
            this.datalistkqhs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datalistkqhs.Size = new System.Drawing.Size(440, 350);
            this.datalistkqhs.TabIndex = 20;
            this.datalistkqhs.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datalistkqhs_CellClick);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(653, 44);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(79, 21);
            this.btnthem.TabIndex = 21;
            this.btnthem.Text = "Sửa điểm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(653, 97);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(79, 24);
            this.btnluu.TabIndex = 22;
            this.btnluu.Text = "thêm điểm";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(653, 153);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(79, 23);
            this.btnxoa.TabIndex = 23;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.Enabled = false;
            this.btnboqua.Location = new System.Drawing.Point(653, 204);
            this.btnboqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(79, 25);
            this.btnboqua.TabIndex = 24;
            this.btnboqua.Text = "hủy";
            this.btnboqua.UseVisualStyleBackColor = true;
            this.btnboqua.Click += new System.EventHandler(this.btnboqua_Click);
            // 
            // txtmahs
            // 
            this.txtmahs.Enabled = false;
            this.txtmahs.Location = new System.Drawing.Point(72, 16);
            this.txtmahs.Margin = new System.Windows.Forms.Padding(2);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(68, 20);
            this.txtmahs.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "tên";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(57, 44);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(112, 20);
            this.txtName.TabIndex = 27;
            // 
            // KQ_HS_MonHoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 387);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtmahs);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.datalistkqhs);
            this.Controls.Add(this.txtdtb);
            this.Controls.Add(this.txtdthi);
            this.Controls.Add(this.txt45);
            this.Controls.Add(this.txt15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdmieng);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbmaky);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbmanam);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbmalop);
            this.Controls.Add(this.cbmamon);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "KQ_HS_MonHoc";
            this.Text = "kết quả của học sinh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KQ_HS_MonHoc_FormClosing);
            this.Load += new System.EventHandler(this.KQ_HS_MonHoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datalistkqhs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbmamon;
        private System.Windows.Forms.ComboBox cbmalop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmanam;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbmaky;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdmieng;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt15;
        private System.Windows.Forms.TextBox txt45;
        private System.Windows.Forms.TextBox txtdthi;
        private System.Windows.Forms.TextBox txtdtb;
        private System.Windows.Forms.DataGridView datalistkqhs;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtName;
    }
}