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
    public partial class ModPerfilDocente : Form
    {
        public ModPerfilDocente()
        {
            InitializeComponent();
            panel5.Hide();
            label6.Hide();
            label8.Hide();
            btnEliminadoDoc.Hide();
            string sdatos;
            sdatos = Persona.Mdatos();
            String[] resultado = sdatos.Split('|');
            txtNombre.Text = resultado[0];
            txtContra.Text = resultado[1];
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ModPerfilDocente_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Click(object sender, EventArgs e)
        {
            txtNombre.ReadOnly = false;
            label6.Show();
        }

        private void panel6_Click(object sender, EventArgs e)
        {
            txtContra.ReadOnly = false;
            label8.Show();
        }

        private void btnGuardarAl_Click(object sender, EventArgs e)
        {
            Docente.ModPerfDoc(txtNombre.Text, txtContra.Text);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEliminarAl_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Docente.ElDoc();
            MessageBox.Show("Se ha eliminado su usuario correctamente!", "Eliminación usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            btnEliminadoDoc.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
