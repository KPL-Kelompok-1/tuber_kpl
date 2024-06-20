using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KPL
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            Forum forum1 = new Forum();
            forum1.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Anda ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

                LoginForm form2 = new LoginForm();
                form2.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            profile profil = new profile();
            profil.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            profile profil = new profile();
            profil.Show();
            this.Hide();
        }
    }
}
