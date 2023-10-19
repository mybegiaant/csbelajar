using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace futsal
{
    public partial class Formnavigasipelatih : Form
    {
        public Formnavigasipelatih()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formjadwallatihan jdl = new Formjadwallatihan();
            jdl.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formeditprofile prfl = new Formeditprofile();
            prfl.Show();
            this.Dispose();
        }
    }
}
