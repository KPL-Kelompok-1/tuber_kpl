using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrontEnd;

namespace GUI_KPL
{
    public partial class LoginForm : Form
    {
        private HttpClient _client;
        private User currentUser;

        public LoginForm()
        {
            InitializeComponent();
            _client = new HttpClient();
            this.currentUser = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Username dan password tidak boleh kosong!");
                return;
            }

            try
            {
                User result = Login(username, password);

                if (result != null)
                {
                    MessageBox.Show("Login berhasil. Selamat datang " + this.currentUser.username);
                    Forum forumForm = new Forum(this.currentUser);
                    forumForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login gagal. Periksa kembali username dan password Anda.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }

        }


        private User Login(String username, String password)
        {

            client<User> client = new client<User>();
            try
            {
                var rsult = client.Post("https://localhost:7238/api/User/Login", new User { username = username, password = password, role = "Admin" });
                //MessageBox.Show(rsult);
                this.currentUser = JsonConvert.DeserializeObject<User>(rsult);
                if (currentUser != null)
                { 
                    return currentUser;
                }
                else
                {
                    throw new Exception("Invalid credential");
                }
            }
            catch (Exception e)
            {
                throw new Exception("Error during login: " + e.Message);
            }

            return null;
        }


        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Dispose();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisForm regis = new RegisForm();
            regis.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
