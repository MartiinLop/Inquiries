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

namespace Inquiries
{
    public partial class RegistroAlumnos : Form
    {

        ArrayList alumnos = new ArrayList();

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

            try
            {

                if (txtContraAl.Text == txtContraConfAl.Text) {

                Alumno al1 = new Alumno(Convert.ToInt32(txtCIAl.Text), txtNomAl.Text, txtApeAl.Text, txtContraAl.Text, txtGrupoAl.Text, txtNickAl.Text);
                MessageBox.Show("Usuario creado!");

                txtCIAl.Text = "";
                txtNomAl.Text = "";
                txtApeAl.Text = "";
                txtContraAl.Text = "";
                txtContraConfAl.Text = "";
                txtGrupoAl.Text = "";
                txtNickAl.Text = "";

                alumnos.Add(al1);
            } else {

                MessageBox.Show("Las contraseñas no son iguales!");

            }
            }catch(Exception) {

                MessageBox.Show("Faltan datos");

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
    }
}
