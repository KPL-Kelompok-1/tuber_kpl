using FrontEnd;
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
    public partial class profile : Form
    {
        private User currentUser;
        public profile(User users)
        {
            InitializeComponent();
            this.currentUser = users;
            this.setData();
        }

        private void setData()
        {
            this.input_username.Text = this.currentUser.username;
            String password = "";
            for (int i = 0; i < this.currentUser.password.Length; i++)
            {
                password += "*";
            }
            this.input_password.Text = password;
        }

        private void profile_Load(object sender, EventArgs e)
        {

        }

        private void btn_forum_Click(object sender, EventArgs e)
        {
            Forum forumForm = new Forum(this.currentUser);
            forumForm.Show();
            this.Hide();
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Apakah anda ingin menghapus account?", "Konfirmasi Hapus account", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

                client<User> client = new client<User>();
                string result2 = client.Delete("https://localhost:7238/api/User/" + this.currentUser.id);
                if (result2 != null)
                {
                    if (result2 == "")
                    {
                        MessageBox.Show("Anda akan logout secara otomatis");
                        LoginForm form2 = new LoginForm();
                        form2.Show();
                    }
                }

                
            }

        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (btn_update.Text == "Edit Profile")
            {
                btn_update.Text = "Update Profile";
                input_username.Enabled = true;
                input_password.Enabled = true;
            }
            else if (btn_update.Text == "Update Profile")
            {
               String username = this.input_username.Text;
               String password = this.input_password.Text;
                if (password.Contains("*"))
                {
                    password = this.currentUser.password;
                }

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Username dan password tidak boleh kosong!");
                    return;
                }

                try
                {
                    User user = new User()
                    {
                        id = this.currentUser.id,
                        username = username,
                        password = password,
                        role = "User"
                    };

                    client<User> client = new client<User>();
                    string result = client.Put("https://localhost:7238/api/User", user);

                    if (result != null)
                    {
                        MessageBox.Show(result);
                    }

                    MessageBox.Show("Berhasil update data user", "Sukses");
                    this.currentUser = user;
                    this.setData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message);
                }

                btn_update.Text = "Edit Profile";
                input_username.Enabled = false;
                input_password.Enabled = false;
            }

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Anda ingin keluar dari aplikasi?", "Konfirmasi Keluar", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();

                LoginForm form2 = new LoginForm();
                form2.Show();
            }
        }
    }
}
