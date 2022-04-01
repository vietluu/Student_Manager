using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLHS_Winforms
{
    public partial class login : Form
    {
        string conn = ConfigurationManager.ConnectionStrings["qlhs"].ConnectionString;


        public login()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("") || textBox2.Text.Equals(""))
            {
                MessageBox.Show("Bạn chưa điền đủ thông tin", "Thông báo", MessageBoxButtons.OK);
                textBox1.Focus();
                textBox2.Focus();
            }
            else
            {
                SqlConnection cnn = new SqlConnection(conn);
                cnn.Open();
                string sql = "select * from tbldn_dk where semail='" + textBox1.Text.Trim() + "' and sMK ='" + textBox2.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(sql, cnn);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows.Count >= 1)
                {

                    this.Hide();
                    Main m = new Main();
                    m.Show();
                    //this.Show();
                }
                else
                {
                    MessageBox.Show("Tài Khoản chưa chính xác", "Thông báo", MessageBoxButtons.OK);
                }
                cnn.Close();
            }
        }


        private void button2_Click_1(object sender, EventArgs e)
        {
            //SuaMK dk = new SuaMK();
            //this.Hide();
            //dk.ShowDialog();
        }
        private void Dangnhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có thật sự muốn thoát khỏi ứng dụng ?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
                e.Cancel = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Dangki dn = new Dangki();
            //this.Hide();
            //dn.ShowDialog();
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {

            //Main m = new Main();
            //m.Enabled = true;
           
        }

        private void login_Load(object sender, EventArgs e)
        {
           // this.Enabled = true;
        }
    }
}

