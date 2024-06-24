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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using GUI_KPL.Validation;

namespace GUI_KPL
{
    public partial class InputForum : Form
    {
        public event Action<string, string, string> DiskusiSaved;
<<<<<<< HEAD
        private string Url = "https://localhost:7238/api";
        private Model.Forum Forum;
        private string asalDesa;
        private string name;
        private string pertanyaan;

        public InputForum(Model.Forum f = null)
=======
        private string Url = "https://localhost:7238/api"; 
        public InputForum()
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
        {
            InitializeComponent();
            this.Forum = f;

            if (this.Forum != null)
            {
                this.ExtractAsalDesaAndName();
                this.ExtractPertanyaanFromContent();
                this.SetValue();
            }
        }

        public void SetValue()
        {
            if (this.Forum != null)
            {
                try
                {
                    input_nama.Text = this.name;
                    input_desa.Text = this.asalDesa;
                    input_pertanyaan.Text = this.pertanyaan;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Terjadi kesalahan: " + e.Message);
                }
            }
        }

        public void ExtractAsalDesaAndName()
        {
            string pattern = @"Asal Desa: (?<AsalDesa>.+?) Nama: (?<name>.+)";
            Match match = Regex.Match(this.Forum.title, pattern);

            if (match.Success)
            {
                this.asalDesa = match.Groups["AsalDesa"].Value.Trim();
                this.name = match.Groups["name"].Value.Trim();
                //MessageBox.Show("Extracted AsalDesa: " + this.asalDesa + " Name: " + this.name);
            }
            else
            {
                MessageBox.Show("No match found in title: " + this.Forum.title);
            }
        }

        public void ExtractPertanyaanFromContent()
        {
            string pattern = @"Pertanyaan: (?<pertanyaan>.+)";
            Match match = Regex.Match(this.Forum.content, pattern);

            if (match.Success)
            {
                this.pertanyaan = match.Groups["pertanyaan"].Value.Trim();
                //MessageBox.Show("Extracted Pertanyaan: " + this.pertanyaan);
            }
            else
            {
                MessageBox.Show("No match found in content: " + this.Forum.content);
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            string nama = input_nama.Text;
            string asalDesa = input_desa.Text;
            string pertanyaan = input_pertanyaan.Text;

            try
            {
                String result = ForumValidation.ValidateForum(asalDesa, nama, pertanyaan);
                if (result != "true")
                {
                    throw new Exception(result);
                }

                Random rnd = new Random();
                Model.Forum forum = new Model.Forum
                {
                    id = rnd.Next(10, 10000),
                    title = "Asal Desa: " + asalDesa + " Nama: " + nama,
                    content = "Pertanyaan: " + pertanyaan,
=======
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
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
                    created_at = DateTime.Now.ToString()
                };

                if (this.Forum != null)
                {
                    forum.id = this.Forum.id;
                }

                client<Model.Forum> client = new client<Model.Forum>();
<<<<<<< HEAD
                String message = "";
                if (this.Forum != null)
                {
                    result = client.Put(Url + "/Forum/" + forum.id +"/update", forum);
                    message = "mengubah diskusi";
                }else
                {
                    result = client.Post(Url + "/Forum", forum);
                    message = "menambah diskusi";
                }
                 
=======
                string result = client.Post(Url +"/Forum", forum);
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2

                if (result.Length > 0)
                {
                    MessageBox.Show(result);
                }
                else
                {
<<<<<<< HEAD
                    MessageBox.Show("Berhasil "+message, "Sukses");
=======
                    MessageBox.Show("Berhasil membuat diskusi baru", "Sukses");
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
                    DiskusiSaved?.Invoke(nama, asalDesa, pertanyaan);
                    this.Close();
                }
            }
            catch (Exception ez)
            {
                MessageBox.Show( ez.Message);
            }
        }

        private void InputForum_Load(object sender, EventArgs e)
        {

        }
<<<<<<< HEAD

        private void btn_kembali_Click(object sender, EventArgs e)
        {
            DiskusiSaved?.Invoke("", "", "");
            this.Close();
        }
=======
>>>>>>> 0825a43f8dbff7975783c84dfb55d272e1253ae2
    }
}
