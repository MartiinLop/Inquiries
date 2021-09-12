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
    public partial class AdminConsultaAl : Form
    {
        public AdminConsultaAl()
        {
            InitializeComponent();
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_RCons_Click(object sender, EventArgs e)
        {
            
            ConBD.Consulta(Convert.ToInt32(txtDocPrueba.Text), txtConsulta.Text);
            MessageBox.Show("Consulta Realizada Satisfactoriamente!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnChatAl_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultasAl_Click(object sender, EventArgs e)
        {

        }

        private void btnGruposAl_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrarAl_Click(object sender, EventArgs e)
        {
            MenuAlumnos a = (MenuAlumnos)Application.OpenForms["MenuAlumnos"];
            MenuConsultaAl b = (MenuConsultaAl)Application.OpenForms["MenuConsultaAl"];
            a.Close();
            b.Close();
            this.Dispose();
        }

        private void btnPerfilDoc_Click(object sender, EventArgs e)
        {

        }

        private void txtDocPrueba_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtConsulta_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerRespuesta_Click(object sender, EventArgs e)
        {
            txtRespuesta.Text = Consulta.LRes();
        }
    }
}
