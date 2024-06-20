using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using FrontEnd;
using System.Threading.Tasks;

namespace GUI_KPL
{
    public partial class LoginForm : Form
    {
        private const string Url = "https://localhost:7238/api";
        private readonly HttpClient _client;
        private User _currentUser;

        public LoginForm()
        {
            InitializeComponent();
            _client = new HttpClient();
            _currentUser = null;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Event handler kosong
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
                User result = await LoginAsync(username, password);

                if (result != null)
                {
                    if(_currentUser.role == "admin")
                    {
                        MessageBox.Show("Login berhasil. Selamat datang " + _currentUser.username);
                        Dashboard dash = new Dashboard(_currentUser);
                        dash.Show();
                        this.Hide();
                    }
                    else if (_currentUser.role == "user")
                    {
                        MessageBox.Show("Login berhasil. Selamat datang " + _currentUser.username);
                        Dashboard dash = new Dashboard(_currentUser);
                        dash.Show();
                        this.Hide();
                    }
                  
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

        private  Task<User> LoginAsync(string username, string password)
        {
            var client = new client<User>();
            try
            {
                string response =  client.Post(Url+ "/User/Login", new User { username = username, password = password, role = "Admin" });
                _currentUser = JsonConvert.DeserializeObject<User>(response);

                if (_currentUser != null)
                {
                    return Task.FromResult(_currentUser);
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
            // Event handler kosong
        }
    }
}
