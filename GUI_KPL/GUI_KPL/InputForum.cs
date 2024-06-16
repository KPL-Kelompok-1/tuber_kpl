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
    public partial class InputForum : Form
    {
        public event Action<string, string, string> DiskusiSaved;
        public InputForum()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nama = textBox1.Text;
            String asalDesa = textBox2.Text;
            String pertanyaan = textBox3.Text;

            DiskusiSaved?.Invoke(nama, asalDesa, pertanyaan);

            MessageBox.Show("Berhasil membuat diskusi baru", "Sukses");
            this.Close();

        }
    }
}
