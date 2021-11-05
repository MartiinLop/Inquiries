using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemplateParteAdmin
{
    public partial class FORPanelIntegrantesGrupo : Form
    {
        public FORPanelIntegrantesGrupo(string nomape, string cedula)
        {
            InitializeComponent();
            lblNombre.Text = nomape;
            lblCI.Text = cedula;

        }
    }
}
