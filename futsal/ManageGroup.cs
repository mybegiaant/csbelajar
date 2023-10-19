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
    public partial class ManageGroup : Form
    {
        Koneksi kon = new Koneksi();

        public ManageGroup()
        {
            InitializeComponent();
        }
        public void tampil()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from [group]";
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
            string query = "insert into [group] (id_group, nama_group) values ('" + textBox1.Text + "', '" + textBox2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }

        public void ubah()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "update [group] set nama_group ='" + textBox2.Text + "' where id_group ='" + textBox1.Text + "'";
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

        private void ManageGroup_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "delete from [group] where id_group= '" + textBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            tampil();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ubah();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navadmin form = new Navadmin();
            form.Show();
            this.Dispose();
        }
    }
}
