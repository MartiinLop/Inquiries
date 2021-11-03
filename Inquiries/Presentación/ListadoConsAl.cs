using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquiries.Presentación
{
    public partial class ListadoConsAl : Form
    {

        protected int ejeX = 0;
        protected int ejeY = 0;

        protected static string[,] comparar = new string[0, 0];
        public ListadoConsAl()
        {
            InitializeComponent();
            ejeX = 0;
            ejeY = 0;
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminConsultaAl a = new AdminConsultaAl();
            a.ShowDialog();
            this.Show();
        }

        private void ListadoConsAl_Load(object sender, EventArgs e)
        {
            
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
                    
                        
                        RichTextBox alCI = new RichTextBox();
                        alCI.Visible = true;
                        alCI.BackColor = Color.FromArgb(196, 196, 196);
                        alCI.ForeColor = Color.Black;
                        alCI.Text = Convert.ToString(infoConsulta[x, 1]) + " - " + Convert.ToString(infoConsulta[x, 3]) + "\n" + Convert.ToString(infoConsulta[x, 6]);
                        alCI.Width = 185;
                        alCI.Height = 50;
                        alCI.ReadOnly = true;
                        consulta.Controls.Add(alCI);


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
                        
                        consulta.Location = new Point(ejeX, ejeY);
                        ejeY += 90;
                        ejeX = 0;
                    }

                    comparar = infoConsulta;
                }
            }
        }
    }
}
