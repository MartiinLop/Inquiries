using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inquiries.Properties;
using Inquiries;

namespace TemplateParteAdmin
{
    public partial class FORPanelElimUsuAdmin : Form
    {
        
        public FORPanelElimUsuAdmin(string nom,string ape, string grup, string tipo, int ci)
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            labelNA.Text = nom +" "+ape;
            labelG.Text = grup;
            labelTipo.Text = tipo;
            pictureBox1.Image = Resources.imagen_pdef;
            lblCedula.Text = Convert.ToString(ci);
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            if (labelTipo.Text == "Alumno") {
                Admin.EliminarAl(Convert.ToInt32(lblCedula.Text));
                MessageBox.Show("Se ha eliminado al alumno");
            }
            else
            {
                Admin.EliminarDoc(Convert.ToInt32(lblCedula.Text));
                MessageBox.Show("Se ha eliminado al docente");
            }

        }

        private void FORPanelElimUsuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
    