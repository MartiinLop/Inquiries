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
    public partial class FORPanelMiniGrupAdmin : Form
    {
        private  string nombre;
        private  string apellido;
        private string cedula;

        public FORPanelMiniGrupAdmin(string grup,string asignatura)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            lblGrupo.Text = grup;
            lblAsignatura.Text = asignatura;

        }


        private void Clickeado(object sender, EventArgs e)
        {

        }

    }
}
