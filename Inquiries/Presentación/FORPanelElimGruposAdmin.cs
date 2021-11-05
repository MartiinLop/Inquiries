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
    public partial class FORPanelElimGruposAdmin : Form
    {
        public FORPanelElimGruposAdmin(string grupo, int cod)
        {
            InitializeComponent();
            lblGrupo.Text = grupo;
        }
    }
}
