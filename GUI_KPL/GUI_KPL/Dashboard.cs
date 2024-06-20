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
        private User currentUser;
        public Dashboard(User u)
        {
            InitializeComponent();
            this.currentUser = u;
        }


        private void label6_Click(object sender, EventArgs e)
        {
            Forum forum1 = new Forum(this.currentUser);
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

        private void label5_Click(object sender, EventArgs e)
        {
            profile profil = new profile(this.currentUser);
            profil.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            profile profil = new profile(this.currentUser);
            profil.Show();
            this.Hide();
        }
    }
}
