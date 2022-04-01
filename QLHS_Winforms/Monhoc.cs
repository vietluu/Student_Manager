
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using System;

namespace QLHS_Winforms
{
    public partial class Monhoc : Form
    {
        String ahref = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;
        String id;
        String name;
        String st;
        public Monhoc()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        public void refersh()
        {
            SqlConnection con = new SqlConnection(ahref);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select sMaMH as[mã môn],sMon as [tên môn ],iTongtiet as [Tổng số tiết]  from tblMonHoc where iTT = 'false' ", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {


            dataGridView1.RowHeadersVisible = false;


            SqlConnection con = new SqlConnection(ahref);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select sMaMH as[mã môn],sMon as [tên môn ],iTongtiet as [Tổng số tiết]  from tblMonHoc where iTT = 'false' ", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private bool check(String connectingString, String id, String name)
        {
            string q = "select* from tblMonHoc";
            using (SqlConnection cnn = new SqlConnection(connectingString))
            {
                using (SqlCommand cmd = new SqlCommand(q, cnn))
                {
                    cnn.Open();
                    using (SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            if (id == rd.GetString(0) || name == rd.GetString(1))
                                return true;
                        }
                        rd.Close();
                        cnn.Close();
                        return false;
                    }
                }
            }
        }
        private bool insertBook(String cnnString, String id, String name, String sub)
        {
            using (SqlConnection conn = new SqlConnection(ahref))
            {
                using (SqlCommand cmd = new SqlCommand("addmonhoc", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@idmon", id);
                    cmd.Parameters.AddWithValue("@ten", name);
                    cmd.Parameters.AddWithValue("@sotiet", sub);
                    conn.Open();
                    var i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;


                }

            }
        }


        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text.ToUpper();
            String name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox2.Text.ToLower());
            String sub = textBox3.Text;

            if (id == "" || name == "" || sub == "")
            {
                MessageBox.Show("có ô chưa nhập dữ liệu", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else
            {


                if (check(ahref, id, name) == true)
                {
                    MessageBox.Show("mã hoặc tên môn đã tồn tại", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {
                    try
                    {

                        bool result = insertBook(ahref, id, name, sub);
                        if (result)
                        {
                            MessageBox.Show("thanh cong", "thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Form1_Load(sender, e);

                            textBox1.ResetText(); textBox2.ResetText();
                            textBox3.ResetText();

                        }
                        else
                            MessageBox.Show("that bai", "that bai", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK);
                    }
                }

            }



        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

             button2.Enabled = true;
            button3.Enabled = true;
            if (e.RowIndex >= 0)
            {

                int indexR = e.RowIndex;

                id = dataGridView1.Rows[indexR].Cells[0].Value.ToString();
                name = dataGridView1.Rows[indexR].Cells[1].Value.ToString();
                st = dataGridView1.Rows[indexR].Cells[2].Value.ToString();
            }


        }

        private bool updateStatus(String cnnString, String id, bool tt)
        {
            using (SqlConnection conn = new SqlConnection(ahref))
            {
                using (SqlCommand cmd = new SqlCommand("uptTT", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@TT", tt);
                    cmd.Parameters.AddWithValue("@id", id);

                    conn.Open();
                    var i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;


                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {

            try
            {
                bool result = updateStatus(ahref, id, true);

                if (result)
                {
                    MessageBox.Show("thanh cong", "thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form1_Load(sender, e);
                }
                else
                    MessageBox.Show("that bai", "that bai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK);
            }
        }



        private void button4_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
            button2.Enabled = false;
            button3.Enabled = false;

            textBox1.ResetText(); textBox2.ResetText();
            textBox3.ResetText();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            String name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
            SqlConnection con = new SqlConnection(ahref);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select sMaMH as[mã môn],sMon as [tên môn ],iTongtiet as [Tổng số tiết]  from tblMonHoc where iTT = 'false' and sMon like N'%" + name + "%' or sMaMH like '%" + name + "%' or Convert(varchar(4),iTongtiet )= '" + name + "'", con);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        private void enter_keypress(object sender, KeyPressEventArgs e)
        {
            if (Convert.ToInt32(e.KeyChar) == 13)
            {
                String name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox4.Text.ToLower());
                SqlConnection con = new SqlConnection(ahref);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("select sMaMH as[mã môn],sMon as [tên môn ],iTongtiet as [Tổng số tiết]  from tblMonHoc where iTT = 'false' and sMon like N'%" + name + "%' or sMaMH like '%" + name + "%' or Convert(varchar(4),iTongtiet )= '" + name + "'", con);
                DataTable dt = new DataTable();
                sqlDataAdapter.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                Form1_Load(sender, e);
                button2.Enabled = false;
                button3.Enabled = false;

                textBox1.ResetText(); textBox2.ResetText();
                textBox3.ResetText();
                textBox4.Clear();
            }
        }


        private void button2_click(object sender, EventArgs e)
        {
            resource f2 = new  resource(this);

            f2.getvalue(ahref, id, name, st);

            f2.Show();
        }

        //private void button6_click(object sender, EventArgs e)
        //{
        //    form2 f2 = new form2();

        //    f2.show();
        //}



        private void datagridview1_celldoubleclick(object sender, DataGridViewCellEventArgs e)
        {
            resource f2 = new resource(this);

            f2.getvalue(ahref, id, name, st);

            f2.Show();
        }
    }
}
