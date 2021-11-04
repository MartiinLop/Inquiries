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

namespace Inquiries
{
    public partial class VerUsuAdmin : Form
    {
        public VerUsuAdmin(string alnom, string alape, string ci, string grupo, string tipo, string contra)
        {
            InitializeComponent();
            try
            {
                byte[] imgAl = Admin.obtImagenAlParaAdmin(Convert.ToInt32(ci));
                byte[] imgDoc = Admin.obtImagenDocParaAdmin(Convert.ToInt32(ci));


                if (tipo == "Alumno") { 
            lblNombre.Text = "Nombre: " + alnom + " " + alape;
            lblCédula.Text = "Cédula: " + ci;
            lblContra.Text = "Contraseña: " + contra;
            lblGrupo.Text = "Grupo: " + grupo;
            lblAlDoc.Text = tipo;
                    pictureBox1.Image = obtImagen(imgAl);


                }
            else
            {
                lblNombre.Text = "Nombre: " + alnom + " " + alape;
                lblCédula.Text = "Cédula: " + ci;
                lblContra.Text = "Contraseña: " + contra;
                lblGrupo.Text = "Grupo: " + grupo;
                lblAlDoc.Text = tipo;
                    pictureBox1.Image = obtImagen(imgDoc);


                }
            }
            catch (Exception)
            {
                
                if (tipo == "Alumno")
                {
                    lblNombre.Text = "Nombre: " + alnom + " " + alape;
                    lblCédula.Text = "Cédula: " + ci;
                    lblContra.Text = "Contraseña: " + contra;
                    lblGrupo.Text = "Grupo: " + grupo;
                    lblAlDoc.Text = tipo;
                    pictureBox1.Image = Properties.Resources.imgPerf;


                }
                else
                {
                    lblNombre.Text = "Nombre: " + alnom + " " + alape;
                    lblCédula.Text = "Cédula: " + ci;
                    lblContra.Text = "Contraseña: " + contra;
                    lblGrupo.Text = "Grupo: " + grupo;
                    lblAlDoc.Text = tipo;
                    pictureBox1.Image = Properties.Resources.imgPerf;


                }
            }
            
            }

        

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //de byte a imagen
        public Image obtImagen(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img);
            return Image.FromStream(ms);
        }

        private void VerUsuAdmin_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
    
}
