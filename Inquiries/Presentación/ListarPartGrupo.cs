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
    public partial class ListarPartGrupo : Form
    {
        private string Gcod;
        public ListarPartGrupo(string gcod)
        {
            InitializeComponent();
            Gcod = gcod;
        }

        private void ListarPartGrupo_Load(object sender, EventArgs e)
        {

        }
    }
}
