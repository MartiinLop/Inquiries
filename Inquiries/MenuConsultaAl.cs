using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquiries
{
    public partial class MenuConsultaAl : Form
    {
        public MenuConsultaAl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarAl_Click(object sender, EventArgs e)
        {
            MenuAlumnos a = (MenuAlumnos)Application.OpenForms["MenuAlumnos"];
            a.Close();
            this.Dispose();
        }

        private void txtCodFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodFiltro_Click(object sender, EventArgs e)
        {

            if (txtCodFiltro.Text == "Ingresar código")
            {
                txtCodFiltro.Text = "";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MenuConsultaAl_Load(object sender, EventArgs e)
        {

        }
    }
}
