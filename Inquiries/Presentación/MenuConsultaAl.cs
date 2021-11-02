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
    public partial class MenuConsultaAl : Form
    {
        protected static string[,] comparar = new string[0, 0];
        protected static Boolean mensaje = false;
        public MenuConsultaAl()
        {
            InitializeComponent();
            comparar = new string[0, 0];
            mensaje = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarAl_Click(object sender, EventArgs e)
        {
            MenuAlumnos a = (MenuAlumnos)Application.OpenForms["MenuAlumnos"];
            a.Dispose();
            this.Dispose();
        }

        private void txtCodFiltro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodFiltro_Click(object sender, EventArgs e)
        {

            if (txtCodFiltro.Text == "Ingresar código")
            {
                txtCodFiltro.Text = "";
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void MenuConsultaAl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void btnConsultasAl_Click(object sender, EventArgs e)
        {

        }

        private void btnPerfilDoc_Click(object sender, EventArgs e)
        {

        }

        private void btnChatAl_Click(object sender, EventArgs e)
        {

        }

        private void btnGruposAl_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string[,] infoConsulta = (string[,])Chat.obtCodigosChatAl();


            if (infoConsulta.Length != comparar.Length)
            {
                for (int x = 0; x < infoConsulta.GetLength(0); x++)
                {

                    if (Convert.ToBoolean(infoConsulta[x, 1]) == true)
                    {

                        Panel consulta = new Panel();
                        consulta.Height = 73;
                        consulta.Width = 500;
                        panelConsultas.Controls.Add(consulta);
                        consulta.Dock = DockStyle.Top;


                        Label codConsulta = new Label();
                        codConsulta.Visible = false;
                        codConsulta.Text = Convert.ToString(infoConsulta[x, 0]);
                        panelConsultas.Controls.Add(codConsulta);

                        RichTextBox alCI = new RichTextBox();
                        alCI.Visible = true;
                        alCI.BackColor = Color.FromArgb(143, 131, 131);
                        alCI.ForeColor = Color.Black;
                        alCI.Text = Convert.ToString(infoConsulta[x, 2]);
                        alCI.Width = 500;
                        consulta.Controls.Add(alCI);


                        alCI.Click += delegate (object enviar, EventArgs f)
                        {

                            invConAl(Convert.ToInt32(alCI.Text), Convert.ToInt32(codConsulta.Text));

                        };

                    }
                    else
                    {
                        if (mensaje == false)
                        {
                            mensaje = true;
                            MessageBox.Show("xd");
                        }
                    }
                    comparar = infoConsulta;
                }
            }
    }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void invConAl(int dci,int cod)
        {
            this.Hide();
            AdminConsultaAl f = new AdminConsultaAl(dci,cod);
            f.ShowDialog();
            this.Show();
        }

           

    }
}

