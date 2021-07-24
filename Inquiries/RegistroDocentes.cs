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
    public partial class RegistroDocentes : Form
    {

        ArrayList docentes = new ArrayList();

        public RegistroDocentes()
        {
            InitializeComponent();
        }

        private void btnConfDoc_Click(object sender, EventArgs e)
        {
            try
            {
                // Test de espacios vacíos 
                if (txtCIDoc.Text == "" || txtNomDoc.Text == "" || txtApeDoc.Text == "" || txtContraDoc.Text == "" || txtMateDoc.Text == "" || txtGrupoDoc.Text == "" || txtContraConfDoc.Text == "")
                {
                    throw new ArgumentNullException();
                }

                if (txtContraDoc.Text == txtContraConfDoc.Text)
                {

                    Docente doc1 = new Docente(Convert.ToInt32(txtCIDoc.Text), txtNomDoc.Text, txtApeDoc.Text, txtContraDoc.Text, txtGrupoDoc.Text, txtMateDoc.Text);
                    MessageBox.Show("Usuario creado!");

                    txtCIDoc.Text = "";
                    txtNomDoc.Text = "";
                    txtApeDoc.Text = "";
                    txtContraDoc.Text = "";
                    txtContraConfDoc.Text = "";
                    txtGrupoDoc.Text = "";
                    txtMateDoc.Text = "";

                    docentes.Add(doc1);
                }
                else
                {

                    MessageBox.Show("Las contraseñas no son iguales!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }catch(Exception) {

                MessageBox.Show("Faltan datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
