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


<<<<<<< HEAD
        private void label6_Click(object sender, EventArgs e)
=======
        private void label6_Click(object sender, EventArgs e) // ke page forum
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            Forum forum1 = new Forum(this.currentUser);
            forum1.Show();
            this.Hide();

        }

<<<<<<< HEAD
        private void button1_Click_1(object sender, EventArgs e)
=======
        private void button1_Click_1(object sender, EventArgs e) // button exit
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            var result = MessageBox.Show("Anda ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

                LoginForm form2 = new LoginForm();
                form2.Show();
            }
        }

<<<<<<< HEAD
        private void label5_Click(object sender, EventArgs e)
=======
        private void label5_Click(object sender, EventArgs e) // ke page profil
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            profile profil = new profile(this.currentUser);
            profil.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void pictureBox4_Click(object sender, EventArgs e)
=======
        private void pictureBox4_Click(object sender, EventArgs e) // ke page profil
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            profile profil = new profile(this.currentUser);
            profil.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

=======
            // event kontroller kosong
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD

        }

        private void pictureBox1_Click(object sender, EventArgs e)
=======
            // event kontroller kosong
        }

        private void pictureBox1_Click(object sender, EventArgs e) // ke page profil
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            profile profil = new profile(this.currentUser);
            profil.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void pictureBox4_Click_1(object sender, EventArgs e)
=======
        private void pictureBox4_Click_1(object sender, EventArgs e) // ke page forum
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            Forum forum1 = new Forum(this.currentUser);
            forum1.Show();
            this.Hide();
        }

<<<<<<< HEAD
        private void pictureBox14_Click(object sender, EventArgs e)
=======
        private void pictureBox14_Click(object sender, EventArgs e) // logout
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            var result = MessageBox.Show("Anda ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

                LoginForm form2 = new LoginForm();
                form2.Show();
            }

        }

<<<<<<< HEAD
        private void pictureBox6_Click(object sender, EventArgs e)
=======
        private void pictureBox6_Click(object sender, EventArgs e) // ke page profil
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            profile profil = new profile(this.currentUser);
            profil.Show();
            this.Hide();
        }
    }
}
