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

namespace GUI_KPL
{
    public partial class LoginForm : Form
    {
        private HttpClient _client;

        public LoginForm()
        {
            InitializeComponent();
            _client = new HttpClient();
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

            var loginData = new User
            {
                id = 0,
                username = username,
                password = password,
                role = ""
            };

            try
            {
                var jsonContent = JsonConvert.SerializeObject(loginData);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("https://localhost:7238/api/User/Login", content);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var loggedInUser = JsonConvert.DeserializeObject<User>(responseData);

                    MessageBox.Show("Login berhasil!");

                    Forum forumForm = new Forum();
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
    }
}
