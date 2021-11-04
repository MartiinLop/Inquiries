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
    public partial class ModPerfilDocente : Form
    {
        public ModPerfilDocente(int ci,Boolean u)
        {
            InitializeComponent();
            panel5.Hide();
            label6.Hide();
            label8.Hide();
            label10.Hide();
            btnEliminadoDoc.Hide();
            string sdatos;
            sdatos = Persona.Mdatos(ci);
            String[] resultado = sdatos.Split('|');
            txtNombre.Text = resultado[0];
            txtApe.Text = resultado[1];
            txtModContra.Text = resultado[2];
            txtModCI.Text = resultado[3];
            if (u == true)
            {
                panel4.Show();
            }
            else
            {
                panel4.Hide();
            }
        }

        private void panel4_Paint(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            label6.Show();
        }


        private void panel4_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            label6.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            txtModContra.ReadOnly = false;
            label8.Show();
        }

        private void btnGuardarAl_Click(object sender, EventArgs e)
        {
            Docente.ModPerfDoc(txtNombre.Text,txtApe.Text, txtModContra.Text, obtByte(pictureBox1.Image));
            MessageBox.Show("Modificaciones de perfil realizadas correctamente", "Modificación de perfil", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminarAl_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Docente.ElDoc();
            Docente.CSesionDoc();
            MessageBox.Show("Se ha eliminado su usuario correctamente!", "Eliminación usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnEliminadoDoc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                Properties.Resources.imagen_pdef.Save(ms, Properties.Resources.imagen_pdef.RawFormat);
                return ms.ToArray();
            }
        }

        private void panelModApe_Paint(object sender, EventArgs e)
        {
            txtApe.ReadOnly = false;
            label10.Show();
        }

        private void panel6_Paint(object sender, EventArgs e)
        {
            txtModContra.ReadOnly = false;
            label8.Show();
        }


        private void panelModCedula_CliCk(object sender, EventArgs e)
        {
            txtModCI.ReadOnly = false;
            label5.Show();
        }
    }
}
