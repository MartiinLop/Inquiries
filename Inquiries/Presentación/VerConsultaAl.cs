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
    public partial class VerConsultaAl : Form
    {
        public VerConsultaAl(string dnom, string dape, string materia, string titulo, string contenido, int ccod)
        {
            InitializeComponent();
            lblNomAsig.Text = dnom + " " + dape + " - " + materia;
            txtConsulta.Text = contenido;
            txtTitulo.Text = titulo;
            txtRespuesta.Text = Consulta.LRes(ccod);
            
        }

        private void VerConsultaAl_Load(object sender, EventArgs e)
        {
           
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
