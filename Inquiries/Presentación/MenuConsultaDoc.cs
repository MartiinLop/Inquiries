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


namespace Inquiries.Presentación
{
    public partial class MenuConsultaDoc : Form
    {
        protected static string[,] comparar = new string[0, 0];
        protected static Boolean mensaje = false;
        public MenuConsultaDoc()
        {
            InitializeComponent();
            comparar = new string[0, 0];
            mensaje = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            string[,] infoConsulta = (string[,])c.obtCon();
            int i = 40;
            int pto = 1;
               
            if (infoConsulta.Length != comparar.Length)
            {
                panelConsultas.Controls.Clear();

                for (int x = 0; x < infoConsulta.GetLength(0); x++)
                {


                    Panel consulta = new Panel();
                    consulta.Height = 73;
                    consulta.Width = 500;
                    panelConsultas.Controls.Add(consulta);
                    consulta.Location = new Point(1, pto);
                    pto+=73;

                    Label codConsulta = new Label();
                    codConsulta.Visible = false;
                    codConsulta.Text = Convert.ToString(infoConsulta[x, 0]);
                    panelConsultas.Controls.Add(codConsulta);

                    RichTextBox dCI = new RichTextBox();
                    dCI.Visible = true;
                    dCI.BackColor = Color.FromArgb(196, 196, 196);
                    dCI.ForeColor = Color.Black;
                    dCI.Text = Convert.ToString(infoConsulta[x, 0]) + " - " + Convert.ToString(infoConsulta[x, 1]) + " - " + Convert.ToString(infoConsulta[x, 6]) + "\n" + Convert.ToString(infoConsulta[x, 2] + "\n" + Convert.ToString(infoConsulta[x, 3]) + " " + Convert.ToString(infoConsulta[x, 4]));
                    dCI.Width = 500;
                    dCI.ReadOnly = true;
                    consulta.Controls.Add(dCI);


                    Label lblEstado = new Label();
                    lblEstado.Text = "Estado:";
                    lblEstado.ForeColor = Color.Black;
                    lblEstado.BackColor = Color.FromArgb(196, 196, 196);
                    lblEstado.Location = new Point(300, i);
                    panelConsultas.Controls.Add(lblEstado);
                    lblEstado.Visible = true;
                    lblEstado.BringToFront();

                    Label alnom = new Label();
                    alnom.Visible = false;
                    consulta.Controls.Add(alnom);
                    alnom.Text = infoConsulta[x, 3];

                    Label algrupo = new Label();
                    algrupo.Visible = false;
                    consulta.Controls.Add(algrupo);
                    algrupo.Text = infoConsulta[x, 4];

                    Label almate = new Label();
                    almate.Visible = false;
                    consulta.Controls.Add(almate);
                    almate.Text = infoConsulta[x, 6];

                    Label titulo = new Label();
                    titulo.Visible = false;
                    consulta.Controls.Add(titulo);
                    titulo.Text = infoConsulta[x, 1];

                    Label contenido = new Label();
                    contenido.Visible = false;
                    consulta.Controls.Add(contenido);
                    contenido.Text = infoConsulta[x, 2];

                    Label codconsulta = new Label();
                    codconsulta.Visible = false;
                    consulta.Controls.Add(codconsulta);
                    codconsulta.Text = infoConsulta[x, 0];

                    Label econsulta = new Label();
                    econsulta.Visible = false;
                    econsulta.Controls.Add(codconsulta);
                    econsulta.Text = infoConsulta[x, 5];

                    dCI.Click += delegate (object enviar, EventArgs f)
                    {

                        AdminConsultaDoc a = new AdminConsultaDoc(codconsulta.Text ,alnom.Text, algrupo.Text, almate.Text, titulo.Text, contenido.Text,econsulta.Text);
                        a.ShowDialog();
                        comparar = new string[0, 0];
                        mensaje = false;
                        infoConsulta = new string[0, 0];
                        panelConsultas.Controls.Clear();

                    };

                    switch (Convert.ToString(infoConsulta[x, 5]))
                    {

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


        private void MenuConsultaDoc_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListadoConsDoc f = new ListadoConsDoc();
            f.ShowDialog();
            this.Show();
        }
    }
}
