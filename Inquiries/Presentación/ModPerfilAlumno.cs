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
using Inquiries.Properties;

namespace Inquiries
{
    public partial class ModPerfilAlumno : Form
    {
        public ModPerfilAlumno(int ci, Boolean u)
        {
            InitializeComponent();
            
            panel7.Hide();
            
            btnEliminadoAl.Hide();
            string sdatos;
            sdatos = Persona.Mdatos(ci);
            String[] resultado = sdatos.Split('|');
            txtNombre.Text = resultado[0];
            txtApe.Text = resultado[1];
            txtApodo.Text = resultado[2];
            txtModContra.Text = resultado[3];
            txtModCI.Text = resultado[4];
            if(u == true)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardarAl_Click(object sender, EventArgs e)
        {
                Alumno m = new Alumno();
                m.ModPerfAl(txtNombre.Text,txtApe.Text, txtApodo.Text, txtModContra.Text, obtByte(pictureBox1.Image));
                MessageBox.Show("Modificaciones de perfil realizadas correctamente", "Modificación de perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
 
        
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void ModPerfilAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnEliminarAl_Click(object sender, EventArgs e)
        {
            panel7.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            Alumno a = new Alumno();
            Alumno.ElAl(p.obtCedulaActual());
            a.CSesionAl();
            MessageBox.Show("Se ha eliminado su usuario correctamente!", "Eliminación usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnEliminadoAl.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel7.Hide();
        }

        private void btnArch_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (img.ShowDialog() == DialogResult.OK)
            {
                txtNomImg.Text = img.FileName;

                pictureBox1.Image = Image.FromFile(img.FileName);

            }
        }

        public byte[] obtByte(Image img)
        {
            if (img != null)
            {
                MemoryStream ms = new MemoryStream();
                img.Save(ms, img.RawFormat);
                return ms.ToArray();
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                Resources.imagen_pdef.Save(ms, Resources.imagen_pdef.RawFormat);
                return ms.ToArray();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomImg_TextChanged(object sender, EventArgs e)
        {

        }

        private void panelModNick_Paint(object sender, EventArgs e)
        {
            txtApodo.ReadOnly = false;
            label7.Show();
        }

        private void panelModContra_Paint(object sender, EventArgs e)
        {
            txtModContra.ReadOnly = false;
            label12.Show();
        }

        private void panelModCI_Click(object sender, EventArgs e)
        {
            txtModCI.ReadOnly = false;
            label8.Show();
        }

        private void panelModApe_Paint(object sender, EventArgs e)
        {
            txtApe.ReadOnly = false;
            label5.Show();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void panelModNom_Paint(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            label6.Show();
        }
    }
}
