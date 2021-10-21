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
                if (txtCIDoc.Text == "" || txtNomDoc.Text == "" || txtApeDoc.Text == "" || txtContraDoc.Text == "" || txtMateDoc.Text == "" || comboBox1.Text == "" || txtContraConfDoc.Text == "")
                {
                    throw new ArgumentNullException();
                }

                if (txtContraDoc.Text == txtContraConfDoc.Text)
                {

                    Boolean est = true, con = false;
                    ConBD.regdoc(Convert.ToInt32(txtCIDoc.Text), txtNomDoc.Text, txtApeDoc.Text, txtContraDoc.Text, Convert.ToInt32(a.grupo().Rows[comboBox1.SelectedIndex][0].ToString()), con, est);

                    txtCIDoc.Text = "";
                    txtNomDoc.Text = "";
                    txtApeDoc.Text = "";
                    txtContraDoc.Text = "";
                    txtContraConfDoc.Text = "";
                    comboBox1.Text = "";
                    txtMateDoc.Text = "";

                    MessageBox.Show("Usuario creado!");

                }
                else
                {

                    MessageBox.Show("Las contraseñas no son iguales!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
            }catch(Exception) {

                MessageBox.Show("Faltan datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
            Grupo a = new Grupo();
            for (int i = 0; i < 3; i++)
            {
                comboBox1.Items.Add(a.grupo().Rows[i]["gnom"]);
            }
        }
    }
}
