using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;
using System;



namespace QLHS_Winforms
{
    public partial class resource : Form
    {
        String connectingString;
        Monhoc Form1;
        public resource(Monhoc f)
        {
            InitializeComponent();
            Form1 = f;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.resource_FormClosing);

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }


        }
        public void getvalue(String ahref, String id, String name, String st)
        {
            textBox1.Text = id;
            textBox2.Text = name;
            textBox3.Text = st;
            connectingString = ahref;

        }
        private bool check(String connectingString, String name)
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
                            if (name == rd.GetString(1))
                                return true;
                        }
                        rd.Close();
                        cnn.Close();
                        return false;
                    }
                }
            }
        }
        private bool sua(String connectingString, String id, String name, String st)
        {
            using (SqlConnection conn = new SqlConnection(connectingString))
            {
                using (SqlCommand cmd = new SqlCommand("udtMh", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@st", st);
                    conn.Open();
                    var i = cmd.ExecuteNonQuery();
                    conn.Close();
                    return i > 0;
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String id = textBox1.Text;
            String name = CultureInfo.InvariantCulture.TextInfo.ToTitleCase(textBox2.Text.ToLower());
            String st = textBox3.Text;
            bool result0 = check(connectingString, name);

            try
            {

                bool result = sua(connectingString, id, name, st);
                if (result)
                {
                    MessageBox.Show("thanh cong", "thanh cong", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    this.Close();


                }
                else
                    MessageBox.Show("that bai", "that bai", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resource_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1.refersh();
        }

    }
}
