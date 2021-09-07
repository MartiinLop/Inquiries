
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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicio sesión 
                if (ConBD.Inseal(Convert.ToInt32(txtUsuario.Text), txtContra.Text))
                {
                    txtContra.Text = "Cédula de identidad";
                    txtUsuario.Text = "Contraseña";
                    this.Hide();
                    MenuAlumnos f = new MenuAlumnos();
                    f.ShowDialog();
                    this.Show();
                }

                else
                {
                    if (ConBD.Insedoc(Convert.ToInt32(txtUsuario.Text), txtContra.Text))
                    {
                    txtContra.Text = "Cédula de identidad";
                    txtUsuario.Text = "Contraseña";
                    this.Hide();
                    MenuDocentes f = new MenuDocentes();
                    f.ShowDialog();
                    this.Show();
                    }
                        else
                        {
                            MessageBox.Show("Este usuario no existe", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
    
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Faltan datos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Cédula de Identidad")
            {
                txtUsuario.Text = "";
            }
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = "";
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
