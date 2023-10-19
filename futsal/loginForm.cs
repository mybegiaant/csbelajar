using futsal.Database;
using System.Data;
using System.Data.SqlClient;

namespace futsal
{
    public partial class loginForm : Form
    {
        Koneksi kon = new Koneksi();
        public loginForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;

            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from [user] where username = '" + user.Trim() + "' and password = '" + password.Trim() + "' ";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (user == "" || password == "")
            {
                MessageBox.Show("Masukkan Username dan/atau Password Terlebih Dahulu");
            }
            else
            {
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        if (dr["role"].ToString() == "admin")
                        {
                            Navadmin f = new Navadmin();
                            this.Hide();
                            f.Show();
                        }
                        else if (dr["role"].ToString() == "coach")
                        {
                            Formnavigasipelatih f = new Formnavigasipelatih();
                            this.Hide();
                            f.Show();
                        }
                        else if (dr["role"].ToString() == "peserta")
                        {
                            Formnavigasipeserta f = new Formnavigasipeserta();
                            this.Hide();
                            f.Show();
                        }
                        else
                        {
                            MessageBox.Show("error");

                        }
                    }

                }
                else
                {
                    MessageBox.Show("Username dan/atau Password Salah");
                }
            }

            conn.Close();




        }
    }
}