using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using Inquiries;
namespace Inquiries
{
    public partial class RegistroAlumnos : Form
    {


        public RegistroAlumnos()
        {
            InitializeComponent();
        }

        private void RegistroAlumnos_Load(object sender, EventArgs e)
        {
            
            int b = Grupo.cantGrupos();
            Grupo a = new Grupo();
            for(int i=0; i<b; i++)
            {
                comboBox1.Items.Add(Grupo.grupo().Rows[i]["gnom"]);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfAl_Click(object sender, EventArgs e)
        { Grupo a = new Grupo();
            try
            {
                //Test de espacios vacíos
                if (txtCIAl.Text == "" || txtNomAl.Text == "" || txtApeAl.Text == "" || txtContraAl.Text == "" || txtNickAl.Text == "" || comboBox1.Text == "" || txtContraConfAl.Text == "")
                {
                    MessageBox.Show("Faltan datos!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    // Creación de alumno
                    if (txtContraAl.Text == txtContraConfAl.Text)
                    {
                        Boolean est = true, con = false;
                        Alumno.regAlumno(Convert.ToInt32(txtCIAl.Text), txtNomAl.Text, txtApeAl.Text, txtContraAl.Text, Grupo.grupo().Rows[comboBox1.SelectedIndex][0].ToString(), txtNickAl.Text, con, est, obtByte(pictureBox1.Image));

                        txtCIAl.Text = "";
                        txtNomAl.Text = "";
                        txtApeAl.Text = "";
                        txtContraAl.Text = "";
                        txtContraConfAl.Text = "";
                        comboBox1.Text = "";    
                        txtNickAl.Text = "";


                        MessageBox.Show("Usuario creado!");
                    }
                    else
                    {

                        MessageBox.Show("Las contraseñas no son iguales!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch (System.FormatException)
            {

                MessageBox.Show("La cédula debe contener números!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btnArch_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog img = new OpenFileDialog();
            img.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png) | *.jpg; *.jpeg; *.gif; *.bmp; *.png";

            if (img.ShowDialog() == DialogResult.OK)
            {
                txtNomImg.Text = img.FileName;

                pictureBox1.Image = Image.FromFile(img.FileName);

            }
        }

        //de imagen a byte
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNickAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGrupoAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraConfAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNomAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtApeAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCIAl_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        


    }
}
