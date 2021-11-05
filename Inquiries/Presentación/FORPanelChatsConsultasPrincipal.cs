using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inquiries.Presentación;

namespace TemplateParteAdmin
{
    public partial class FORPanelChatsConsultasPrincipal : Form
    {
        private string a = null;
        private int Cod;
        public FORPanelChatsConsultasPrincipal(string docente, string materia, string orientacion, string grupo, string alumno, string tipo, string textoparaWF,int cod)
        {
            InitializeComponent();
            lblDocente.Text = docente;
            lblMateria.Text = materia;
            lblOrientacion.Text = orientacion;
            lblGrupo.Text = grupo;
            lblAlumno.Text = alumno;
            lblTipo.Text = tipo;
            a = textoparaWF;
            Cod = cod;
        }

        private void FORPanelChatsConsultasPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void metodo_Click(object sender, EventArgs e)
        {
            HistorialChatConsulta z = new HistorialChatConsulta(a,lblTipo.Text,Cod);
            z.ShowDialog();
        }
    }
}
