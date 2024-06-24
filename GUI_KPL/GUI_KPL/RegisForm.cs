using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Windows.Forms;
using FrontEnd;
using System.Threading.Tasks;

namespace GUI_KPL
{
    public partial class RegisForm : Form
    {
        private User _currentUser;
        private string Url = "https://localhost:7238/api";

        public RegisForm()
        {
            InitializeComponent();
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
                if (RegisterAsync(username, password, "user") != null)
                {
                    if (_currentUser.role == "admin")
                    {
                        MessageBox.Show("Registrasi berhasil!");
                        Dashboard dash = new Dashboard(_currentUser);
                        dash.Show();
                        this.Hide();
                    }
                    else if (_currentUser.role == "user")
                    {
                        MessageBox.Show("Registrasi berhasil!");
                        Forum forumForm = new Forum(_currentUser);
                        forumForm.Show();
                        this.Hide();
                    }
                    
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

        private Task<User> RegisterAsync(string username, string password, string role)
        {
            var client = new client<User>();
            try
            {
                Random rnd = new Random();
                string result =  client.Post(this.Url + "/User/Register", new User { id= rnd.Next(10,10000) , username = username, password = password, role = role });
                if (result != null)
                {
                    _currentUser = JsonConvert.DeserializeObject<User>(result);
                    return Task.FromResult(_currentUser);
                }
            }
            catch (Exception e)
            {
<<<<<<< HEAD
                MessageBox.Show("Register gagal");
=======
                MessageBox.Show("Error during registration: " + e.Message);
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
            }
            return null;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            login.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
