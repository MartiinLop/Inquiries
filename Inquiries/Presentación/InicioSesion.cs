
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
            Alumno aAl = new Alumno();
            Docente aDoc = new Docente();
            Admin aAd = new Admin();
            try
            {
                try
                {
                    //Inicio sesión
                    if (aAl.inSesAl(Convert.ToInt32(txtUsuario.Text), txtContra.Text))
                    {
                        txtUsuario.Text = "Cédula de identidad";
                        txtContra.Text = "Contraseña";
                        this.Hide();
                        MenuAlumnos f = new MenuAlumnos();
                        f.ShowDialog();
                        this.Show();

                    }
                    else
                    {
                        if (aDoc.inSesDoc(Convert.ToInt32(txtUsuario.Text), txtContra.Text))
                        {
                            txtUsuario.Text = "Cédula de identidad";
                            txtContra.Text = "Contraseña";
                            this.Hide();
                            MenuDocentes f = new MenuDocentes();
                            f.ShowDialog();
                            this.Show();
                        }
                        else
                        {
                            if (aAd.inSesAd(Convert.ToInt32(txtUsuario.Text), txtContra.Text))
                            {
                                txtUsuario.Text = "Cédula de identidad";
                                txtContra.Text = "Contraseña";
                                this.Hide();
                                MenuPrincipalAdmin f = new MenuPrincipalAdmin();
                                f.ShowDialog();
                                this.Show();
                            }
                            else { MessageBox.Show("Este usuario no existe", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information); }

                        }

                    }

                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Datos erróneos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Ha ocurrido un error", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

            private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Cédula de identidad")
            {
                txtUsuario.Text = null;
            }
        }

        private void txtContra_Click(object sender, EventArgs e)
        {
            if (txtContra.Text == "Contraseña")
            {
                txtContra.Text = null;
            }
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void InicioSesion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
