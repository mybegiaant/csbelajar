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
    public partial class ManagePeserta : Form
    {
        Koneksi kon = new Koneksi();
        public ManagePeserta()
        {
            InitializeComponent();
        }


        public void tampil()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from peserta";
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
            string query = "insert into peserta (id_peserta, nama_peserta, alamat, id_user) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "', '" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }
        public void ubah()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "update peserta set nama_peserta='" + textBox2.Text + "', alamat= '" + textBox3.Text + "', id_user= '" + textBox5.Text + "' where id_peserta='" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Navadmin form = new Navadmin();
            form.Show();
            this.Dispose();
        }

        private void ManagePeserta_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();
            textBox5.Text = row.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navadmin form = new Navadmin();
            form.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ubah();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "delete from peserta where id_peserta= '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah();
        }
    }
}
