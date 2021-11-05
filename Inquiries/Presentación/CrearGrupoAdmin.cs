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
                
                
                    if (rbSoporte.Checked == false && rbVideojuegos.Checked == false && rbWeb.Checked == false)
                    {
                        label7.Text = Admin.crearGrupoSinOri(nombre);
                        MessageBox.Show("Grupo creado correctamente", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        if (rbSoporte.Checked == true) { ori = rbSoporte.Text; };
                        if (rbVideojuegos.Checked == true) { ori = rbVideojuegos.Text; };
                        if (rbWeb.Checked == true) { ori = rbWeb.Text; };
                        label7.Text = Admin.crearGrupo(nombre, ori);
                        MessageBox.Show("Grupo creado correctamente", "Grupos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
          
            
        
    }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CrearGrupoAdmin_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (label7.Text == "label7")
                {
                    MessageBox.Show("No ha ingresado grupo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txtAl.Text == "") { alumno = null; }
                    if (txtAsig.Text == "") { asig = null; }
                    if (txtDoc.Text == "") { doc = null; }
                    Admin.argegarAGrupo(label7.Text, txtAsig.Text, txtDoc.Text, txtAl.Text, txtNom.Text);
                }
            //}
            //catch(Exception)
            //{
            //    MessageBox.Show("Debe llenar los 3 campos!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
