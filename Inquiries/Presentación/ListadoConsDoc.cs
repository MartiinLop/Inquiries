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
    public partial class ListadoConsDoc : Form
    {

        protected int ejeX = 0;
        protected int ejeY = 0;
        protected static string[,] comparar = new string[0, 0];
        public ListadoConsDoc()
        {
            InitializeComponent();
            ejeX = 0;
            ejeY = 0;
        }

        private void ListadoConsDoc_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Consulta c = new Consulta();
            string[,] infoConsulta = (string[,])c.obtCon();
            int i = 40;
            int y = 20;

            if (infoConsulta.Length != comparar.Length)
            {
                for (int x = 0; x < infoConsulta.GetLength(0); x++)
                {
                    Panel consulta = new Panel();
                    consulta.Height = 50;
                    consulta.Width = 200;
                    panelConsultas.Controls.Add(consulta);


                    RichTextBox consultaAl = new RichTextBox();
                    consultaAl.Visible = true;
                    consultaAl.BackColor = Color.FromArgb(196, 196, 196);
                    consultaAl.ForeColor = Color.Black;
                    consultaAl.Text = Convert.ToString(infoConsulta[x, 1]) + " - " + Convert.ToString(infoConsulta[x, 6]) + "\n" + Convert.ToString(infoConsulta[x, 3] + " " + Convert.ToString(infoConsulta[x, 4]) + " - " + Convert.ToString(infoConsulta[x, 7]));
                    consultaAl.Width = 185;
                    consultaAl.Height = 50;
                    consultaAl.ReadOnly = true;
                    consulta.Controls.Add(consultaAl);

                    Label ccod = new Label();
                    ccod.Visible = false;
                    consulta.Controls.Add(ccod);
                    ccod.Text = infoConsulta[x, 0];

                    Label alnom = new Label();
                    alnom.Visible = false;
                    consulta.Controls.Add(alnom);
                    alnom.Text = infoConsulta[x, 3];

                    Label alape = new Label();
                    alape.Visible = false;
                    consulta.Controls.Add(alape);
                    alape.Text = infoConsulta[x, 4];

                    Label consMat = new Label();
                    consMat.Visible = false;
                    consulta.Controls.Add(consMat);
                    consMat.Text = infoConsulta[x, 6];

                    Label titulo = new Label();
                    titulo.Visible = false;
                    consulta.Controls.Add(titulo);
                    titulo.Text = infoConsulta[x, 1];

                    Label contenido = new Label();
                    contenido.Visible = false;
                    consulta.Controls.Add(contenido);
                    contenido.Text = infoConsulta[x, 2];

                    Label estado = new Label();
                    estado.Visible = false;
                    consulta.Controls.Add(estado);
                    estado.Text = infoConsulta[x, 5];

                    switch (Convert.ToString(infoConsulta[x, 5]))
                    {

                        case "contestada":
                            Label estadocon = new Label();

                            estadocon.Text = Convert.ToString(infoConsulta[x, 5].ToUpper());
                            estadocon.ForeColor = Color.Black;
                            estadocon.BackColor = Color.Green;
                            estadocon.Location = new Point(ejeX + 83, ejeY + 24);
                            panelConsultas.Controls.Add(estadocon);
                            estadocon.Visible = true;
                            estadocon.BringToFront();
                            y += 100;
                            i += 210;
                            break;

                        case "recibida":
                            Label estadore = new Label();

                            estadore.Text = Convert.ToString(infoConsulta[x, 5].ToUpper());
                            estadore.ForeColor = Color.Black;
                            estadore.BackColor = Color.Yellow;
                            estadore.Location = new Point(ejeX + 83, ejeY + 24);
                            panelConsultas.Controls.Add(estadore);
                            estadore.Visible = true;
                            estadore.BringToFront();
                            y += 100;
                            i += 210;
                            break;

                        case "realizada":
                            Label estador = new Label();

                            estador.Text = Convert.ToString(infoConsulta[x, 5].ToUpper());
                            estador.ForeColor = Color.Black;
                            estador.BackColor = Color.Red;
                            estador.Location = new Point(ejeX + 83, ejeY + 24);
                            panelConsultas.Controls.Add(estador);
                            estador.Visible = true;
                            estador.BringToFront();
                            y += 100;
                            i += 210;
                            break;
                    }

                    if (ejeX < 900)
                    {
                        consulta.Location = new Point(ejeX, ejeY);
                        ejeX += 210;
                    }
                    else
                    {
                        ejeY += 90;
                        ejeX = 0;
                        consulta.Location = new Point(ejeX, ejeY);
                        ejeX += 210;
                    }

                    consultaAl.Click += delegate (object enviar, EventArgs f)
                    {

                        AdminConsultaDoc a = new AdminConsultaDoc(ccod.Text, alnom.Text, alape.Text, consMat.Text, titulo.Text, contenido.Text, estado.Text);
                        a.ShowDialog();

                    };

                    comparar = infoConsulta;
                }
            }
        }
    }
}
