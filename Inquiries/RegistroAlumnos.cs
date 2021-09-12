using System;
using System.Windows.Forms;

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

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnConfAl_Click(object sender, EventArgs e)
        {
            //try
            //{
                //Test de espacios vacíos
                if (txtCIAl.Text == "" || txtNomAl.Text == "" || txtApeAl.Text == "" || txtContraAl.Text == "" || txtNickAl.Text == "" || txtGrupoAl.Text == "" || txtContraConfAl.Text == "")
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    // Creación de alumno
                    if (txtContraAl.Text == txtContraConfAl.Text)
                    {
                        Boolean est = true, con = false;
                        ConBD.regal(Convert.ToInt32(txtCIAl.Text), txtNomAl.Text, txtApeAl.Text, txtContraAl.Text, txtGrupoAl.Text, txtNickAl.Text, con, est);

                        txtCIAl.Text = "";
                        txtNomAl.Text = "";
                        txtApeAl.Text = "";
                        txtContraAl.Text = "";
                        txtContraConfAl.Text = "";
                        txtGrupoAl.Text = "";
                        txtNickAl.Text = "";


                        MessageBox.Show("Usuario creado!");
                    }
                    else
                    {

                        MessageBox.Show("Las contraseñas no son iguales!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
           // }
            //catch (Exception)
           // {

              //  MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
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
    }
}
