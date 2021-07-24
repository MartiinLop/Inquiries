
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


        Alumno alumnoEjemplo = new Alumno(543, "juan", "diaz", "123", "3°BA", "JuanDiaz");

        Docente docenteEjemplo = new Docente(54, "juan", "diaz", "12", "3°BA, 3°BB", "BD, Programación");

        private void button1_Click(object sender, EventArgs e)
        {
            try

            {
                // Inicio sesión 
                if (Convert.ToInt32(txtUsuario.Text) == alumnoEjemplo.alci && txtContra.Text == alumnoEjemplo.alcon)
                {
                    this.Hide();
                    MenuAlumnos f = new MenuAlumnos();
                    f.ShowDialog();
                    this.Show();
                }
                else
                {
                    if (Convert.ToInt32(txtUsuario.Text) == docenteEjemplo.docci && txtContra.Text == docenteEjemplo.doccon)
                    {
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

            } catch (Exception)
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
    }
}
