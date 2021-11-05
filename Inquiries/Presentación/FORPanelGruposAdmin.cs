using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquiries.Presentación
{
    public partial class FORPanelGruposAdmin : Form
    {
        public FORPanelGruposAdmin(string grupo, int cantidadEnGrupo)
        {
            InitializeComponent();
            lblGrupo.Text = grupo;
            lblCant.Text = Convert.ToString(cantidadEnGrupo);
        }
    }
}
