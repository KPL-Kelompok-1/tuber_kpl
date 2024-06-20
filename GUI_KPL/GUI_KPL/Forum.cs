using FrontEnd;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace GUI_KPL
{
    public partial class Forum : Form
    {
        private User currentUser;
        public Forum(User user)
        {
            InitializeComponent();
            this.listForum();
            this.currentUser = user;
        }

        public Forum()
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            InputForum modelForm = new InputForum();
            modelForm.DiskusiSaved += InputForm_DiskusiSaved;
            modelForm.Show();
        }

        private void listForum()
        {
            client<Model.Forum> client = new client<Model.Forum>();
            List<Model.Forum> forums = client.Get("https://localhost:7238/api/Forum");
            listBox1.Items.Clear();
            foreach (var forum in forums)
            {
                listBox1.Items.Add(forum.id);
                listBox1.Items.Add(forum.title);
                listBox1.Items.Add(forum.content);
                listBox1.Items.Add("");
            }
        }

        private void InputForm_DiskusiSaved(string nama, string asalDesa, string pertanyaan)
        {
            this.listForum();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void Forum_Load(object sender, EventArgs e)
        {

        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            profile profileForm = new profile(this.currentUser);
            profileForm.Show();
            this.Hide();
        }

        private void btn_forum_Click(object sender, EventArgs e)
        {

        }

        private void btn_del_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}
