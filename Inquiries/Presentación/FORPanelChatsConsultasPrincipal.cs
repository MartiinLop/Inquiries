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
    public partial class FORPanelChatsConsultasPrincipal : Form
    {
        public FORPanelChatsConsultasPrincipal(string docente, string materia, string orientacion, string grupo, string alumno, string tipo)
        {
            InitializeComponent();
            lblDocente.Text = docente;
            lblMateria.Text = materia;
            lblOrientacion.Text = orientacion;
            lblGrupo.Text = grupo;
            lblAlumno.Text = alumno;
            lblTipo.Text = tipo;

        }

        private void FORPanelChatsConsultasPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
