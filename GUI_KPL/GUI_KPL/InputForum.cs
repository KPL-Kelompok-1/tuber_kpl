using FrontEnd;
using Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_KPL
{
    public partial class InputForum : Form
    {
        public event Action<string, string, string> DiskusiSaved;
        private string Url = "https://localhost:7238/api"; 
        public InputForum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nama = textBox1.Text;
            String asalDesa = textBox2.Text;
            String pertanyaan = textBox3.Text;
            try
            {
                Random rnd = new Random();
                Model.Forum forum = new Model.Forum()

                {
                    id = rnd.Next(10,10000),
                    title = "Asal Desa   : " + asalDesa + "  Nama : " + nama,
                    content = "Pertanyaan : " + pertanyaan,
                    created_at = DateTime.Now.ToString()
                };

                client<Model.Forum> client = new client<Model.Forum>();
                string result = client.Post(Url +"/Forum", forum);

                if (result.Length > 0)
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Berhasil membuat diskusi baru", "Sukses");
                    DiskusiSaved?.Invoke(nama, asalDesa, pertanyaan);
                    this.Close();
                }
            }
            catch (Exception ez)
            {
                MessageBox.Show("Terjadi kesalahan: " + ez.Message);
            }
        }

        private void InputForum_Load(object sender, EventArgs e)
        {

        }
    }
}
