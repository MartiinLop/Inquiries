using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Inquiries
{
    public partial class AdminConsultaDoc : Form
    {
        public AdminConsultaDoc(string codcon,string alnom, string alape, string materia, string titulo, string contenido,string estado)
        {
            InitializeComponent();
            lblCon.Text = alnom + " " + alape + " - " + materia;
            txtConsulta.Text = contenido;
            lblTCon.Text = titulo;
            lblCodCon.Text = codcon;

            if(estado == "contestada")
            {
                txtRespuesta.Text = Consulta.LRes(Convert.ToInt32(codcon));
                button3.Visible = false;
                txtRespuesta.ReadOnly = true;
            }
            else
            {
                button3.Visible = true;
                txtRespuesta.ReadOnly = false;
            }

        }

        public AdminConsultaDoc()
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MenuDocentes a = (MenuDocentes)Application.OpenForms["MenuDocentes"];
            a.Close();
            this.Dispose();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


         //Llamar al metodo para obtener consultas docente
    }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consulta.RCDocente(lblCodCon.Text, txtRespuesta.Text);
            MessageBox.Show("Respuesta Enviada Satisfactoriamente!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lblCon_Click(object sender, EventArgs e)
        {

        }
    }
}
