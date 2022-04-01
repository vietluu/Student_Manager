
namespace QLHS_Winforms
{
    partial class HocSinh
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmahs = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtns = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.txtdt = new System.Windows.Forms.TextBox();
            this.txthp = new System.Windows.Forms.TextBox();
            this.txttrangthaihp = new System.Windows.Forms.TextBox();
            this.lisths = new System.Windows.Forms.DataGridView();
            this.age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnhuy = new System.Windows.Forms.Button();
            this.txtgt = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.lisths)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Học sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 79);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Giới tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 19);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Địa chỉ";
            // 
            // txtmahs
            // 
            this.txtmahs.Enabled = false;
            this.txtmahs.Location = new System.Drawing.Point(101, 18);
            this.txtmahs.Margin = new System.Windows.Forms.Padding(2);
            this.txtmahs.Name = "txtmahs";
            this.txtmahs.Size = new System.Drawing.Size(109, 20);
            this.txtmahs.TabIndex = 5;
            // 
            // txthoten
            // 
            this.txthoten.Enabled = false;
            this.txthoten.Location = new System.Drawing.Point(101, 50);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(175, 20);
            this.txthoten.TabIndex = 6;
            // 
            // txtns
            // 
            this.txtns.Enabled = false;
            this.txtns.Location = new System.Drawing.Point(101, 77);
            this.txtns.Margin = new System.Windows.Forms.Padding(2);
            this.txtns.Mask = "00/00/0000";
            this.txtns.Name = "txtns";
            this.txtns.Size = new System.Drawing.Size(109, 20);
            this.txtns.TabIndex = 9;
            this.txtns.ValidatingType = typeof(System.DateTime);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(301, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Điện thoại";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 81);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Học phí";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(301, 107);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Trạng thái";
            // 
            // txtdc
            // 
            this.txtdc.Enabled = false;
            this.txtdc.Location = new System.Drawing.Point(357, 16);
            this.txtdc.Margin = new System.Windows.Forms.Padding(2);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(207, 20);
            this.txtdc.TabIndex = 13;
            // 
            // txtdt
            // 
            this.txtdt.Enabled = false;
            this.txtdt.Location = new System.Drawing.Point(357, 46);
            this.txtdt.Margin = new System.Windows.Forms.Padding(2);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(123, 20);
            this.txtdt.TabIndex = 14;
            // 
            // txthp
            // 
            this.txthp.Enabled = false;
            this.txthp.Location = new System.Drawing.Point(357, 77);
            this.txthp.Margin = new System.Windows.Forms.Padding(2);
            this.txthp.Name = "txthp";
            this.txthp.Size = new System.Drawing.Size(123, 20);
            this.txthp.TabIndex = 15;
            // 
            // txttrangthaihp
            // 
            this.txttrangthaihp.Enabled = false;
            this.txttrangthaihp.Location = new System.Drawing.Point(357, 107);
            this.txttrangthaihp.Margin = new System.Windows.Forms.Padding(2);
            this.txttrangthaihp.Name = "txttrangthaihp";
            this.txttrangthaihp.Size = new System.Drawing.Size(123, 20);
            this.txttrangthaihp.TabIndex = 16;
            // 
            // lisths
            // 
            this.lisths.AllowUserToAddRows = false;
            this.lisths.AllowUserToOrderColumns = true;
            this.lisths.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lisths.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.lisths.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lisths.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.age});
            this.lisths.Enabled = false;
            this.lisths.Location = new System.Drawing.Point(11, 131);
            this.lisths.Margin = new System.Windows.Forms.Padding(2);
            this.lisths.Name = "lisths";
            this.lisths.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.lisths.RowHeadersVisible = false;
            this.lisths.RowHeadersWidth = 62;
            this.lisths.RowTemplate.Height = 28;
            this.lisths.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lisths.Size = new System.Drawing.Size(606, 122);
            this.lisths.TabIndex = 17;
            this.lisths.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lisths_CellClick);
            this.lisths.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lisths_CellContentClick);
            this.lisths.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.lisths_CellDoubleClick);
            // 
            // age
            // 
            this.age.HeaderText = "tuoi";
            this.age.Name = "age";
            this.age.Width = 49;
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(110, 257);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(62, 23);
            this.btnthem.TabIndex = 18;
            this.btnthem.Text = "Thêm mới";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnluu
            // 
            this.btnluu.Enabled = false;
            this.btnluu.Location = new System.Drawing.Point(202, 257);
            this.btnluu.Margin = new System.Windows.Forms.Padding(2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(53, 23);
            this.btnluu.TabIndex = 19;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Enabled = false;
            this.btnxoa.Location = new System.Drawing.Point(288, 257);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(55, 23);
            this.btnxoa.TabIndex = 21;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnhuy
            // 
            this.btnhuy.Enabled = false;
            this.btnhuy.Location = new System.Drawing.Point(372, 257);
            this.btnhuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnhuy.Name = "btnhuy";
            this.btnhuy.Size = new System.Drawing.Size(53, 23);
            this.btnhuy.TabIndex = 22;
            this.btnhuy.Text = "Hủy bỏ";
            this.btnhuy.UseVisualStyleBackColor = true;
            this.btnhuy.Click += new System.EventHandler(this.btnhuy_Click);
            // 
            // txtgt
            // 
            this.txtgt.FormattingEnabled = true;
            this.txtgt.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.txtgt.Location = new System.Drawing.Point(101, 105);
            this.txtgt.Name = "txtgt";
            this.txtgt.Size = new System.Drawing.Size(109, 21);
            this.txtgt.TabIndex = 23;
            // 
            // HocSinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(634, 298);
            this.Controls.Add(this.lisths);
            this.Controls.Add(this.txtgt);
            this.Controls.Add(this.btnhuy);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.txttrangthaihp);
            this.Controls.Add(this.txthp);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtns);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.txtmahs);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HocSinh";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lisths)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmahs;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.MaskedTextBox txtns;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.TextBox txthp;
        private System.Windows.Forms.TextBox txttrangthaihp;
        private System.Windows.Forms.DataGridView lisths;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnhuy;
        private System.Windows.Forms.ComboBox txtgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn age;
    }
}