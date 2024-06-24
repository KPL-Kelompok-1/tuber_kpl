using FrontEnd;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace GUI_KPL
{
    public partial class Forum : Form
    {
        private User _currentUser;
        private string Url = "https://localhost:7238/api";
        private client<Model.Forum> client = new client<Model.Forum>();
        List<Model.Forum> forums = new List<Model.Forum>();
        public Forum(User user)
        {
            InitializeComponent();
            this.listForum();
            this._currentUser = user;
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

            if (btn_sub.Text == "Mulai Diskusi Baru")
            {
                InputForum modelForm = new InputForum();
                modelForm.DiskusiSaved += InputForm_DiskusiSaved;
                modelForm.Show();
            }
            else
            {
                try
                {
                    if (int.TryParse(list_forum.SelectedItem.ToString(), out int value))
                    {
                        int id = (int)list_forum.SelectedItem;
                        Model.Forum forum = forums.Where(x => x.id == id).FirstOrDefault();
                        InputForum modelForm = new InputForum(forum);
                        modelForm.DiskusiSaved += InputForm_DiskusiSaved;
                        modelForm.Show();
                    }
                    else
                    {
                        throw new Exception("Pilih forum yang akan di edit dengan id yang benar");    
                    }
                 
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }



        private void listForum()
        {
            forums = client.Get(Url + "/Forum");
            list_forum.Items.Clear();
            foreach (var forum in forums)
            {
                list_forum.Items.Add(forum.id);
                list_forum.Items.Add(forum.title);
                list_forum.Items.Add(forum.content);
                list_forum.Items.Add("");
            }
        }

        private void InputForm_DiskusiSaved(string nama, string asalDesa, string pertanyaan)
        {
            this.listForum();
            this.setNameButton();

            if (this.list_forum.SelectedIndex == 1)
            {
                this.list_forum.SelectedIndex = 0;
            }
        }

        private void btn_profile_Click(object sender, EventArgs e)
        {
            profile profileForm = new profile(this._currentUser);
            profileForm.Show();
            this.Hide();
        }

        private void btn_del_Click_1(object sender, EventArgs e)
        {
            if (list_forum.SelectedIndex == -1)
            {
                MessageBox.Show("Pilih forum yang akan dihapus");
                return;
            }

            try
            {
                if (int.TryParse(list_forum.SelectedItem.ToString(), out int value))
                {
                    int id = (int)list_forum.SelectedItem;
                    MessageBox.Show("Anda akan menghapus forum dengan id " + id);

                    string result = client.Delete(Url + "/Forum/" + id + "/delete");
                    if (result.Length > 0)
                    {
                        throw new Exception(result);
                    }
                    else
                    {
                        MessageBox.Show("Forum berhasil dihapus", "Sukses");
                        this.listForum();
                        this.setNameButton();
                    }
                }
                else
                {
                    throw new Exception("Pilih forum yang akan di hapus dengan id yang benar");
                }
              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi kesalahan: " + ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(this._currentUser);
            dashboard.Show();
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.setNameButton();
        }

        private void setNameButton()
        {
            if (list_forum.SelectedIndex == -1)
            {
                btn_sub.Text = "Mulai Diskusi Baru";
            }
            else
            {
                btn_sub.Text = "Edit Diskusi";
            }
        }
    }
}
