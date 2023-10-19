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
    public partial class ManagePelatih : Form
    {
        Koneksi kon = new Koneksi();
        public ManagePelatih()
        {
            InitializeComponent();
        }

        public void tampil()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from Pelatih";
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
            string query = "insert into Pelatih (id_pelatih, nama_pelatih, id_user) values ('" + textBox1.Text + "', '" + textBox2.Text + "', '" + textBox3.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }

        public void ubah()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "update Pelatih set nama_pelatih= '" + textBox2.Text + "' , id_user= '" + textBox3.Text + "' where id_pelatih='" + textBox1.Text + "'";
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

        private void button2_Click(object sender, EventArgs e)
        {
            Navadmin form = new Navadmin();
            form.Show();
            this.Dispose();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tambah();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ubah();
        }

        private void ManagePelatih_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "delete from Pelatih where id_Pelatih= '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }
    }
}
