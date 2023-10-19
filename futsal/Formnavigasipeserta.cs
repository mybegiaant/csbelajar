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
    public partial class Formnavigasipeserta : Form
    {
        public Formnavigasipeserta()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginForm form = new loginForm();
            form.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formeditprofile prfl = new Formeditprofile();
            prfl.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Formpesertalatihan ps = new Formpesertalatihan();
            ps.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formjadwallatihanpeserta jdwl = new Formjadwallatihanpeserta();
            jdwl.Show();
            this.Dispose();
        }
    }
}
