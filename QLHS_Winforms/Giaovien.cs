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
using System.Globalization;

namespace QLHS_Winforms
{
    public partial class Giaovien : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;

        public Giaovien()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadNhanvien();


        }
        void loadNhanvien()
        {
            using (SqlConnection cnn = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblGiaoVien", cnn))
                {
                    cmd.CommandType = CommandType.Text;
                    cnn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        dataGridView1.DataSource = tb;
                    }
                }
            }
        }
        private int kiemtraNV()
        {
            String k = textBox1.Text;
            string sql = "select *from tblGiaoVien where sMaGV = '" + k.ToString() + "'";
            using (SqlConnection cnn = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable tb = new DataTable();
                        da.Fill(tb);
                        if (tb.Rows.Count > 0) return 1;
                        else return 0;

                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1_Click(sender, e);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[2].Value.ToString().Equals("Nam"))
                radioButton1.Checked = true;
            else
                radioButton2.Checked = true;
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "" || textBox4.Text.Trim() == "" ||
                textBox3.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bạn có chắc muốn thêm ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    using (SqlConnection cnn = new SqlConnection(conn))
                    {
                        if (kiemtraNV() == 1)
                        {
                            MessageBox.Show(" Trùng khóa chính không thể thêm");
                            textBox1.Focus();
                        }
                        else
                        {
                            using (SqlCommand cmd = cnn.CreateCommand())
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "sp_addGV";
                                cmd.Parameters.AddWithValue("@idgv", textBox1.Text);
                                cmd.Parameters.AddWithValue("@name", textBox2.Text);


                                if (radioButton1.Checked)
                                    cmd.Parameters.AddWithValue("@gt", "Nam");
                                else
                                    cmd.Parameters.AddWithValue("@gt", "Nữ");
                                cmd.Parameters.AddWithValue("@addr", textBox4.Text);
                                cmd.Parameters.AddWithValue("@sdt", textBox3.Text);

                                cnn.Open();
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                {
                                    MessageBox.Show("Thêm thành công");
                                    cnn.Close();
                                    loadNhanvien();
                                }
                                else
                                    MessageBox.Show("Bạn thêm không thành công");
                            }
                        }
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Lỗi");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn sửa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    using (SqlConnection cnn = new SqlConnection(conn))
                    {

                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "update_tblGiaoVien";
                            cmd.Parameters.AddWithValue("@MaGV", textBox1.Text);
                            cmd.Parameters.AddWithValue("@TenGV", textBox2.Text);


                            if (radioButton1.Checked)
                                cmd.Parameters.AddWithValue("@gt", "Nam");
                            else
                                cmd.Parameters.AddWithValue("@gt", "Nữ");
                            cmd.Parameters.AddWithValue("@addr", textBox4.Text);
                            cmd.Parameters.AddWithValue("@sdt", textBox3.Text);

                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Sửa thành công");
                                cnn.Close();
                                loadNhanvien();
                            }
                            else
                                MessageBox.Show("Bạn sửa không thành công");
                        }

                    }
                }
            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Lỗi");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dl = MessageBox.Show("Bạn có chắc chắn muốn xóa không ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dl == DialogResult.Yes)
                {
                    using (SqlConnection cnn = new SqlConnection(conn))
                    {
                        using (SqlCommand cmd = cnn.CreateCommand())
                        {
                            cmd.CommandType = CommandType.StoredProcedure;
                            cmd.CommandText = "sp_XoaGV2";
                            cmd.Parameters.AddWithValue("@idgv", textBox1.Text);
                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                cnn.Close();
                                loadNhanvien();
                            }
                            else
                                MessageBox.Show("Bạn xóa không thành công");
                        }
                    }
                }
            }

            catch (Exception E)
            {
                MessageBox.Show(E.Message, "Lỗi");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox5.Text.ToLower());
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select sMaGV as[Mã Giáo Viên],sTenGV as [Tên Giáo Viên ],sGioiTinh as [Giới Tính], sSDT as [Số Điện Thoại], sDiaChi as[Địa Chỉ]  from tblGiaoVien Where sTenGV like N'%" + name + "%' ", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

    
    }

}


