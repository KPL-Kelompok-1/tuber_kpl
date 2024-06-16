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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI_KPL
{
    public partial class RegisForm : Form
    {
        private HttpClient _client;

        public RegisForm()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private void label2_Click(object sender, EventArgs e)
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

            var newUser = new User
            {
                id = 0,
                username = username,
                password = password,
                role = "user"
            };

            try
            {
                var jsonContent = JsonConvert.SerializeObject(newUser);
                var content = new StringContent(jsonContent, System.Text.Encoding.UTF8, "application/json");

                var response = await _client.PostAsync("https://localhost:7238/api/User/Register", content);
         

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    var registeredUser = JsonConvert.DeserializeObject<User>(responseData);
                    
                    MessageBox.Show("Registrasi berhasil!");

                }
                else
                {
                    MessageBox.Show("Registrasi gagal. Silakan coba lagi.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void RegisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _client.Dispose();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
