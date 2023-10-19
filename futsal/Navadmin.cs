using futsal.Database;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futsal
{
    public partial class Navadmin : Form
    {
        Koneksi kon = new Koneksi();
        public Navadmin()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ManageIdentitasPunggung form = new ManageIdentitasPunggung();
            form.Show();
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ManagePeserta form = new ManagePeserta();
            form.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ManagePelatih form = new ManagePelatih();
            form.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManageGroup form = new ManageGroup();
            form.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ManagePesertaLatihan form = new ManagePesertaLatihan();
            form.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ManageLapangan form = new ManageLapangan();
            form.Show();
            this.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ManageWaktu form = new ManageWaktu();
            form.Show();
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ManageHari form = new ManageHari();
            form.Show();
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ManageJadwalLatihan form = new ManageJadwalLatihan();
            form.Show();
            this.Dispose();
        }

        private void Navadmin_Load(object sender, EventArgs e)
        {

        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = kon.Connection();
            conn.Open();
            conn.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
