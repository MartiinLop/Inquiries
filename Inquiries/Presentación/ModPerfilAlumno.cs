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
    public partial class ModPerfilAlumno : Form
    {
        public ModPerfilAlumno(int ci, Boolean u)
        {
            InitializeComponent();
            panel7.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            btnEliminadoAl.Hide();
            string sdatos;
            sdatos = Persona.Mdatos();
            String[] resultado = sdatos.Split('|');
            txtNombre.Text = resultado[0];
            txtApodo.Text = resultado[1];
            txtContra.Text = resultado[2];

            if(Boolean )
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
                m.ModPerfAl(txtNombre.Text, txtApodo.Text, txtContra.Text, obtByte(pictureBox1.Image));
                MessageBox.Show("Modificaciones de perfil realizadas correctamente", "Modificación de perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
    }
    private void panel4_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            label6.Show();
        }
        
        private void panel5_Click(object sender, EventArgs e)
        {
            txtApodo.ReadOnly = false;
            label7.Show();
        }
        
        private void panel6_Click(object sender, EventArgs e)
        {
            txtContra.ReadOnly = false;
            label8.Show();
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
            Alumno a = new Alumno();
            Alumno.ElAl();
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

        public byte[] obtByte(System.Drawing.Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, img.RawFormat);
            return ms.ToArray();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtNomImg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
