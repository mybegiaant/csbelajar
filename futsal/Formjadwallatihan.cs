using futsal.Database;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Formjadwallatihan : Form
    {
        Koneksi kon = new Koneksi();
        public Formjadwallatihan()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2.Rows[e.RowIndex];

        }
        public void tampil()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from peserta_latihan";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }
        public void tampil1()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from jadwal_latihan";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];
            conn.Close();
        }
        private void Formjadwallatihan_Load(object sender, EventArgs e)
        {
            tampil1();
            tampil();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formnavigasipelatih f = new Formnavigasipelatih();
            f.Show();
            this.Dispose();
        }
    }
}
