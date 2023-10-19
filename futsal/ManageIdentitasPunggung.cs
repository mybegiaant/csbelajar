using futsal.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futsal
{
    public partial class ManageIdentitasPunggung : Form
    {
        Koneksi kon = new Koneksi();
        public ManageIdentitasPunggung()
        {
            InitializeComponent();
        }
        public void tampil()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from identitas_punggung";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void tambah()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "insert into identitas_punggung (id_no_punggung, nama_posisi) values ('" + textBox1.Text + "', '" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }
        public void ubah()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "update identitas_punggung  set nama_posisi='" + textBox2.Text + "' where id_no_punggung='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Navadmin form = new Navadmin();
            form.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah();
        }

        private void ManageIdentitasPunggung_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ubah();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "delete from identitas_punggung where id_no_punggung= '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }
    }
}
