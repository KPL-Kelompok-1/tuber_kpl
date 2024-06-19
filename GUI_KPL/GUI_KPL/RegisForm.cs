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
using FrontEnd;

namespace GUI_KPL
{
    public partial class RegisForm : Form
    {
        private HttpClient _client;
        private User currentUser;

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

            try
            {
                User user = Register(username, password, "user");
                if (user != null)
                {    
                    MessageBox.Show("Registrasi berhasil!");
                    Forum forumForm = new Forum(this.currentUser);
                    forumForm.Show();
                    this.Hide();

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

        private User Register(String username, String password, String role)
        {
            client<User> client = new client<User>();
            string rsult = client.Post("https://localhost:7238/api/User/Register", new User { username = username, password = password, role = role }); // fetch in clinet
            try
            {
                if (rsult != null)
                {
                    this.currentUser = JsonConvert.DeserializeObject<User>(rsult);
                    return currentUser;
                }
            }
            catch (Exception e)
            {
                return null;
            }
            return null;
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
