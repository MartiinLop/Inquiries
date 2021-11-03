using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inquiries.Presentación;
using System.IO;

namespace Inquiries
{
    public partial class MenuDocentes : Form
    {
        int v = 1;
        public MenuDocentes()
        {
            InitializeComponent();
        }

        private void MenuDocentes_Load(object sender, EventArgs e)
        {
            panel3.Hide();
            try
            {
                pictureBox1.Image = obtImagen(Docente.obtImgDoc());
            }
            catch (Exception)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine(Environment.CurrentDirectory, "imgPerf.jpg"));
            }

        }

        public Image obtImagen(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {


            if (v == 1)
            {
                panel3.Show();
            }
            if (v == 0)
            {
                panel3.Hide();
            }

            if (v == 1)
            {
                v = 0;
            }
            else
            {
                v = 1;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarDoc_Click(object sender, EventArgs e)
        {
            Docente.CSesionDoc();
            this.Dispose();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnConsultasDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuConsultaDoc m = new MenuConsultaDoc();
            m.ShowDialog();
            this.Show();
        }

        private void btnChatDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuChatDocente f1 = new MenuChatDocente();
            f1.ShowDialog();
            this.Show();
        }

        private void btnPerfilAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModPerfilDocente f1 = new ModPerfilDocente();
            f1.ShowDialog();
            this.Show();
        }
    }
}
