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
    public partial class CrearUsuAdmin : Form
    {
        public CrearUsuAdmin()
        {
            InitializeComponent();
            int b = Grupo.cantGrupos();
            Grupo a = new Grupo();
            for (int i = 0; i < b; i++)
            {
                comboBox1.Items.Add(Grupo.grupo().Rows[i]["gnom"]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbAlumno.Checked == true)
                {
                    Alumno.regAlumno(Convert.ToInt32(txtCI.Text), txtNom.Text, txtApe.Text, txtCon.Text, Grupo.grupo().Rows[comboBox1.SelectedIndex][0].ToString(), txtNick.Text, false, true, obtByte(pictureBox1.Image));
                    MessageBox.Show("Se registró correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Docente.registrar(Convert.ToInt32(txtCI.Text), txtNom.Text, txtApe.Text, txtCon.Text, Convert.ToInt32(Grupo.grupo().Rows[comboBox1.SelectedIndex][0].ToString()), false, true, obtByte(pictureBox1.Image));
                    MessageBox.Show("Se registró correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEditarImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (img.ShowDialog() == DialogResult.OK)
            {
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
                Image.FromFile(Path.Combine(Environment.CurrentDirectory, "imgPerf.jpg")).Save(ms, Image.FromFile(Path.Combine(Environment.CurrentDirectory, "imgPerf.jpg")).RawFormat);
                return ms.ToArray();
            }

        }
    }
}
