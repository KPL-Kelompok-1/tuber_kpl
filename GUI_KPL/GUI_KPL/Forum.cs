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
    public partial class Forum : Form
    {
        public Forum()
        {
            InitializeComponent();
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

        private void InputForm_DiskusiSaved(string nama, string asalDesa, string pertanyaan)
        {
            listBox1.Items.Add("Asal Desa   : " + asalDesa +"Nama          :" + nama);
            listBox1.Items.Add("Pertanyaan : " + pertanyaan);
            listBox1.Items.Add("");
        }
    }
}
