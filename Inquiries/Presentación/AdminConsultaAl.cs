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
        protected static string[,] comparar = new string[0, 0];
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
            //try
            //{
            
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error al realizar consulta", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
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

        }

        private void AdminConsultaAl_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string grupAl = Consulta.gruAl();

            string[,] docCon = (string[,])Consulta.obtDocCon(grupAl);


            if (docCon.Length != comparar.Length)
            {
                for (int x = 0; x < docCon.GetLength(0); x++)
                {
                    Panel docente = new Panel();
                    docente.Height = 50;
                    docente.Width = 200;
                    panelDoc.Controls.Add(docente);

                    RichTextBox consultaDoc = new RichTextBox();
                    consultaDoc.Visible = true;
                    consultaDoc.BackColor = Color.FromArgb(196, 196, 196);
                    consultaDoc.ForeColor = Color.Black;
                    consultaDoc.Text = docCon[x, 2] + " " + docCon[x, 3] + "\n" + docCon[x, 4];
                    consultaDoc.Width = 200;
                    consultaDoc.Height = 50;
                    consultaDoc.ReadOnly = true;
                    docente.Controls.Add(consultaDoc);

                    consultaDoc.Click += delegate (object enviar, EventArgs f)
                    {

                        Consulta.CConsulta(Convert.ToInt32(docCon[x, 0]), txtConsulta.Text, txtTitulo.Text, Convert.ToInt32(docCon[x, 1]));
                        MessageBox.Show("Consulta Realizada Satisfactoriamente!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    };

                }
                comparar = docCon;
            }
        }

            
}
}
