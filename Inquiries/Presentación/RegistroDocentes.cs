using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using Inquiries.Properties;

namespace Inquiries
{
    public partial class RegistroDocentes : Form
    {

        public RegistroDocentes()
        {
            InitializeComponent();
        }

        private void btnConfDoc_Click(object sender, EventArgs e)
        {
            Grupo a = new Grupo();
            try
            {
                 // Test de espacios vacíos 
                if (txtCIDoc.Text == "" || txtNomDoc.Text == "" || txtApeDoc.Text == "" || txtContraDoc.Text == "" || comboBox1.Text == "" || txtContraConfDoc.Text == "")
                {
                    MessageBox.Show("Faltan datos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                if (txtContraDoc.Text == txtContraConfDoc.Text)
                {

                    Boolean est = true, con = false;
                    Docente.registrar(Convert.ToInt32(txtCIDoc.Text), txtNomDoc.Text, txtApeDoc.Text, txtContraDoc.Text, Convert.ToInt32(Grupo.grupo().Rows[comboBox1.SelectedIndex][0].ToString()), con, est, obtByte(pictureBox1.Image));

                    Docente.regEnseña(Convert.ToInt32(txtCIDoc.Text), Convert.ToInt32(Asignatura.devolverMaterias().Rows[comboBox1.SelectedIndex][0].ToString()));

                    txtCIDoc.Text = "";
                    txtNomDoc.Text = "";
                    txtApeDoc.Text = "";
                    txtContraDoc.Text = "";
                    txtContraConfDoc.Text = "";
                    comboBox1.Text = "";
           

                    MessageBox.Show("Usuario creado!");

                }
                else
                {

                    MessageBox.Show("Las contraseñas no son iguales!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }
            catch (Exception)
            {

                MessageBox.Show("La cédula debe contener números!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

    private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RegistroDocentes_Load(object sender, EventArgs e)
        {
            ConBD z = new ConBD();
            Grupo a = new Grupo();


            int b = z.contgrupos();
            for (int i = 0; i < b; i++)
            {
                comboBox1.Items.Add(Grupo.grupo().Rows[i]["gnom"]);
            }

            int c = Asignatura.cantMaterias();
            for (int i = 0; i < b; i++)
            {
                comboBox2.Items.Add(Asignatura.devolverMaterias().Rows[i]["anom"]);
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

        private void btnArch_Click(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (img.ShowDialog() == DialogResult.OK)
            {

                pictureBox1.Image = Image.FromFile(img.FileName);

            }

        }

        
    }
}
