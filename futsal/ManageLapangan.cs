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
    public partial class ManageLapangan : Form
    {
        Koneksi kon = new Koneksi();
        public ManageLapangan()
        {
            InitializeComponent();
        }

        public void tampil()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from lapangan";
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
            string query = "insert into lapangan (id_lapangan, nama_lapangan) values ('" + textBox1.Text + "', '" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }

        public void ubah()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "update lapangan set nama_lapangan ='" + textBox2.Text + "' where id_lapangan ='" + textBox1.Text + "'";
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ubah();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "delete from lapangan where id_lapangan= '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }
    }
}
