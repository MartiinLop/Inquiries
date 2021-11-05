using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inquiries;

namespace TemplateParteAdmin
{
    public partial class CrearGrupoAdmin : Form
    {
        private string alumno;
        private string asig;
        private string doc;
        public CrearGrupoAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            string nombre = txtNom.Text;
            string ori = null;
            if (rbSoporte.Checked == true) { ori = rbSoporte.Text; };
            if (rbVideojuegos.Checked == true) { ori = rbVideojuegos.Text; };
            if (rbWeb.Checked == true) { ori = rbWeb.Text; };
            label7.Text = Admin.crearGrupo(nombre, ori);
        }

        private void click_paneles(object sender, EventArgs e)
        {
            if (txtAl.Text=="") { alumno = null; }
            if (txtAsig.Text == "") { asig = null; }
            if (txtDoc.Text == "") { doc = null; }
            Admin.argegarAGrupo(label7.Text,txtNom.Text, asig, doc, alumno);
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
