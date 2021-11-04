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
    public partial class FORPanelModifUsuAdmin : Form
    {
        
        public FORPanelModifUsuAdmin(string nom,string ape, string grup, string tipo, int ci)
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            labelNA.Text = nom +" "+ape;
            labelG.Text = grup;
            labelTipo.Text = tipo;
            pictureBox1.Image = Resources.imgPerf;
            lblCedula.Text = Convert.ToString(ci);
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            if (labelTipo.Text == "Alumno")
            {
                ModPerfilAlumno a = new ModPerfilAlumno(Convert.ToInt32(lblCedula.Text), true);
                this.Hide();
                a.ShowDialog();
                this.Show();
            }
            else
            {
                ModPerfilDocente a = new ModPerfilDocente(Convert.ToInt32(lblCedula.Text), true);
                this.Hide();
                a.ShowDialog();
                this.Show();
            }

        }

        private void FORPanelElimUsuAdmin_Load(object sender, EventArgs e)
        {

        }
    }
}
    