using Inquiries.Presentación;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;


namespace Inquiries
{
    public partial class MenuAlumnos : Form
    {
        int v = 1;
        public MenuAlumnos()
        {
            InitializeComponent();
            panel3.Hide();
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

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuConsultaAl a = new MenuConsultaAl();
            a.ShowDialog();
            this.Show();

        }

        private void btnCerrarAl_Click(object sender, EventArgs e)
        {
            Alumno a = new Alumno();
            a.CSesionAl();
            this.Dispose();
        }

        private void btnChatAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuPrincipalChatAl m1 = new MenuPrincipalChatAl();
            m1.ShowDialog();
            this.Show();
        }

        private void btnPerfilDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            ModPerfilAlumno f1 = new ModPerfilAlumno();
            f1.ShowDialog();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenuAlumnos_Load(object sender, EventArgs e)
        {
            //    pictureBox1.Image = ByteArrayToImage(Alumno.obtImgAl());
        }


    //////de byte a imagen
    //public Image obtImagen(byte[] img)
    //{
    //    MemoryStream ms = new MemoryStream(img);
    //    return Image.FromStream(ms);
    //}

    //public Image ByteArrayToImage(byte[] byteArrayIn)
    //{


    //        MemoryStream ms = new MemoryStream(byteArrayIn);
    //        return Image.FromStream(ms);

    //}
        
    }
}
