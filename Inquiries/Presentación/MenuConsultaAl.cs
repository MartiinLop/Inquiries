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

namespace Inquiries
{
    public partial class MenuConsultaAl : Form
    {
        protected static string[,] comparar = new string[0, 0];
        
        public MenuConsultaAl()
        {
            InitializeComponent();
            comparar = new string[0, 0];
            
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarAl_Click(object sender, EventArgs e)
        {
            MenuAlumnos a = new MenuAlumnos();
            a.Dispose();
            this.Dispose();
        }

        private void MenuConsultaAl_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminConsultaAl a = new AdminConsultaAl();
            a.ShowDialog();
            this.Show();
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
            this.Hide();
            ListadoConsAl a = new ListadoConsAl();
            a.ShowDialog();
            this.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            string[,] infoConsulta = (string[,])c.obtCon();
            int i = 40;

            if (infoConsulta.Length != comparar.Length)
            {
                
                for (int x = 0; x < infoConsulta.GetLength(0); x++)
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
                    alCI.BackColor = Color.FromArgb(196, 196, 196);
                    alCI.ForeColor = Color.Black;
                    alCI.Text = Convert.ToString(infoConsulta[x, 0]) + " - " + Convert.ToString(infoConsulta[x, 1]) + " - " + Convert.ToString(infoConsulta[x, 6]) +  "\n" + Convert.ToString(infoConsulta[x, 2] + "\n" + Convert.ToString(infoConsulta[x, 3]) + " " + Convert.ToString(infoConsulta[x, 4]));
                    alCI.Width = 500;
                    alCI.ReadOnly = true;
                    consulta.Controls.Add(alCI);


                    Label lblEstado = new Label();
                    lblEstado.Text = "Estado:";
                    lblEstado.ForeColor = Color.Black;
                    lblEstado.BackColor = Color.FromArgb(196, 196, 196);
                    lblEstado.Location = new Point(300, i);
                    panelConsultas.Controls.Add(lblEstado);
                    lblEstado.Visible = true;
                    lblEstado.BringToFront();

                    Label ccod = new Label();
                    ccod.Visible = false;
                    consulta.Controls.Add(ccod);
                    ccod.Text = infoConsulta[x, 0];

                    Label dnom = new Label();
                    dnom.Visible = false;
                    consulta.Controls.Add(dnom);
                    dnom.Text = infoConsulta[x, 3];

                    Label dape = new Label();
                    dape.Visible = false;
                    consulta.Controls.Add(dape);
                    dape.Text = infoConsulta[x, 4];

                    Label dmate = new Label();
                    dmate.Visible = false;
                    consulta.Controls.Add(dmate);
                    dmate.Text = infoConsulta[x, 6];

                    Label titulo = new Label();
                    titulo.Visible = false;
                    consulta.Controls.Add(titulo);
                    titulo.Text = infoConsulta[x, 1];

                    Label contenido = new Label();
                    contenido.Visible = false;
                    consulta.Controls.Add(contenido);
                    contenido.Text = infoConsulta[x, 2];

                    alCI.Click += delegate (object enviar, EventArgs f)
                    {

                        VerConsultaAl a = new VerConsultaAl(dnom.Text, dape.Text, dmate.Text, titulo.Text, contenido.Text, Convert.ToInt32(ccod.Text));
                        a.ShowDialog();

                    };

                    switch (Convert.ToString(infoConsulta[x, 5])) {

                        case "contestada":
                            Label estadocon = new Label();
                            estadocon.Text = Convert.ToString(infoConsulta[x, 5].ToUpper());
                            estadocon.ForeColor = Color.Black;
                            estadocon.BackColor = Color.Green;
                            panelConsultas.Controls.Add(estadocon);
                            estadocon.Location = new Point(370, i);
                            estadocon.Visible = true;
                            estadocon.BringToFront();
                            i += 70;
                            break;

                        case "recibida":
                            Label estadore = new Label();
                            estadore.Text = Convert.ToString(infoConsulta[x, 5].ToUpper());
                            estadore.ForeColor = Color.Black;
                            estadore.BackColor = Color.Yellow;
                            panelConsultas.Controls.Add(estadore);
                            estadore.Location = new Point(370, i);
                            estadore.Visible = true;
                            estadore.BringToFront();
                            i += 70;
                            break;

                        case "realizada":
                            Label estador = new Label();
                            estador.Text = Convert.ToString(infoConsulta[x, 5].ToUpper());
                            estador.ForeColor = Color.Black;
                            estador.BackColor = Color.Red;
                            panelConsultas.Controls.Add(estador);
                            estador.Location = new Point(370, i);
                            estador.Visible = true;
                            estador.BringToFront();
                            i += 70;
                            break;

                            default:

                            break;
                    }

                    

                    comparar = infoConsulta;
                }
            }
    }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        

           

    }
}

