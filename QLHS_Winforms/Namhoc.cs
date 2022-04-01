using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QLHS_Winforms
{
    public partial class Namhoc : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        public Namhoc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text.Trim() == "" || textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Bạn có chắc muốn thêm ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    using (SqlConnection cnn = new SqlConnection(conn))
                    {
                        if (kiemtramanam() == 1)
                        {
                            MessageBox.Show(" Trùng khóa chính không thể thêm");
                            textBox1.Focus();
                        }
                        else
                        {
                            using (SqlCommand cmd = cnn.CreateCommand())
                            {
                                cmd.CommandType = CommandType.StoredProcedure;
                                cmd.CommandText = "themnamhoc";
                                cmd.Parameters.AddWithValue("@idnam", textBox1.Text);
                                cmd.Parameters.AddWithValue("@ten", textBox2.Text);

                                cnn.Open();
                                int i = cmd.ExecuteNonQuery();
                                if (i > 0)
                                {
                                    MessageBox.Show("Thêm thành công");
                                    cnn.Close();
                                    loadNam();
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



        private void Form1_Load(object sender, EventArgs e)
        {

            loadNam();

        }
        void loadNam()
        {
            using (SqlConnection cnn = new SqlConnection(conn))
            {
                using (SqlCommand cmd = new SqlCommand("select * from tblNamHoc", cnn))
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
        private int kiemtramanam()
        {
            String k = textBox1.Text;
            string sql = "select *from tblNamHoc where sManam = '" + k.ToString() + "'";
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
            textBox1.Text = dataGridView1.CurrentRow.Cells["Mã năm"].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells["Tên năm học "].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
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
                            cmd.CommandText = "sp_XoaManam";
                            cmd.Parameters.AddWithValue("@idnam", textBox1.Text);
                            cnn.Open();
                            int i = cmd.ExecuteNonQuery();
                            if (i > 0)
                            {
                                MessageBox.Show("Xóa thành công");
                                cnn.Close();
                                loadNam();
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

        private void button4_Click(object sender, EventArgs e)
        {
            String name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox3.Text.ToLower());
            SqlConnection con = new SqlConnection(conn);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select sManam as[Mã Năm],sTennam as [Tên Năm Học ]  from tblNamHoc Where sManam like N'%" + name + "%' ", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
}
