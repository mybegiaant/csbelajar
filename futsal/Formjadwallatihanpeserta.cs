﻿using futsal.Database;
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
    public partial class Formjadwallatihanpeserta : Form
    {
        Koneksi kon = new Koneksi();
        public Formjadwallatihanpeserta()
        {
            InitializeComponent();
        }

        public void tampil()
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            string query = "select * from jadwal_latihan_peserta";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            conn.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
        }

        private void Formjadwallatihanpeserta_Load(object sender, EventArgs e)
        {
            tampil();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formnavigasipeserta f =  new Formnavigasipeserta();
            f.Show();
            this.Dispose();
        }
    }
}
