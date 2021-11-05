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
    public partial class MenuPrincipalAdmin : Form
    {
        private static string[,] comparar = new string[0, 0];
        private static string[,] comparar2 = new string[0, 0];
        private static string[,] comparar3 = new string[0, 0];
        private static string[,] comparar4 = new string[0, 0];

        private bool v = false;
        private bool b = false;
        protected int ejeX = 0;
        protected int ejeY = 0;
        Timer r = new Timer
        {
            Interval = 600
            
        };

        

        public MenuPrincipalAdmin()
        {
            InitializeComponent();
            ejeX = 0;
            ejeY = 0;
            panelUsuarios.Hide();

            r.Enabled = false;
            r.Tick += new System.EventHandler(crearPaneles);

        }

        private void btnGruposAl_Click(object sender, EventArgs e)
        {



        }

        private void btnConsultasAl_Click(object sender, EventArgs e)
        {

            if (v == false)
            {
                b = false;
                timer2.Enabled = false;
                panelHistorialMain.Hide();
                panelHistorial.Controls.Clear();
                comparar3 = new string[0, 0];
                comparar4 = new string[0, 0];
                ejeX = 0;
                ejeY = 0;
                /////////////////////
                v = true;
                r.Enabled = true;
                pnlUsu.Show();
                panelUsuarios.Show();
                timer1.Enabled = true;
 
            }
            else
            {
                v = false;
                r.Enabled = false;
                pnlUsu.Hide();
                panelUsuarios.Hide();
                timer1.Enabled = false;
                comparar = new string[0, 0];
                comparar2 = new string[0, 0];
                ejeX = 0;
                ejeY = 0;

            } 
           
        }

        private void btnHistorial_Click(object sender, EventArgs e)
        {
            if (b == false)
            {
                v = false;
                r.Enabled = false;
                timer1.Enabled = false;
                pnlUsu.Controls.Clear();
                panelUsuarios.Hide();
                comparar = new string[0, 0];
                comparar2 = new string[0, 0];
                /////////////////////////
                b = true;
                timer2.Enabled = true;
                panelHistorial.Show();
                panelHistorialMain.Show();
                ejeX = 0;
                ejeY = 0;
            }
            else
            {
                b = false;
                timer2.Enabled = false;
                panelHistorial.Hide();
                panelHistorialMain.Hide();
                comparar3 = new string[0, 0];
                comparar4 = new string[0, 0];
                ejeX = 0;
                ejeY = 0;

            }

        }

        private void btnCerrarAl_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
     

        private void crearPaneles(object sender, EventArgs e)
        {
            string[,] alumnos = (string[,])Admin.ObtenerUsuariosAl();

            if (alumnos.Length != comparar.Length)
            {
                for (int x = 0; x < alumnos.GetLength(0); x++)
                {
                    Panel lAlumnos = new Panel();
                    lAlumnos.Height = 111;
                    lAlumnos.Width = 209;
                    lAlumnos.BackColor = Color.FromArgb(196, 196, 196);
                    pnlUsu.Controls.Add(lAlumnos);
                    if (ejeX < 800)
                    {
                        lAlumnos.Location = new Point(ejeX, ejeY);
                        ejeX += 219;
                    }
                    else
                    {
                        ejeY += 121;
                        ejeX = 0;
                        lAlumnos.Location = new Point(ejeX, ejeY);
                        ejeX += 219;
                    }


                    Label alCi = new Label();
                    alCi.Visible = false;
                    alCi.Text = Convert.ToString(alumnos[x, 3]);
                    panel1.Controls.Add(alCi);

                    Label alNom = new Label();
                    alNom.Visible = false;
                    alNom.Text = Convert.ToString(alumnos[x, 0]);
                    panel1.Controls.Add(alNom);

                    Label alApe = new Label();
                    alApe.Visible = false;
                    alApe.Text = Convert.ToString(alumnos[x, 1]);
                    panel1.Controls.Add(alApe);

                    Label alGru = new Label();
                    alGru.Visible = false;
                    alGru.Text = Convert.ToString(alumnos[x, 2]);
                    panel1.Controls.Add(alGru);

                    Label alCon = new Label();
                    alCon.Visible = false;
                    alCon.Text = Convert.ToString(alumnos[x, 4]);
                    panel1.Controls.Add(alCon);


                    TemplateParteAdmin.MiniUsuExpandir a = new TemplateParteAdmin.MiniUsuExpandir(alNom.Text, alApe.Text, alCi.Text, alGru.Text, "Alumno", alCon.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lAlumnos.Controls.Add(a);
                    a.Show();

                    a.Click += delegate (object enviar, EventArgs f)
                        {

                                VerUsuAdmin b = new VerUsuAdmin(alNom.Text, alApe.Text, alCi.Text, alGru.Text, "Alumno", alCon.Text);
                                b.ShowDialog();
                            
                        };

                }
            }
            comparar = alumnos;


            ///////////////////////////////////////////////////////////////////
            ///
            string[,] docentes = (string[,])Admin.ObtenerUsuariosDoc();


            if (docentes.Length != comparar2.Length)
            {
                for (int x = 0; x < docentes.GetLength(0); x++)
                {
                    
                    Panel lDocentes = new Panel();
                    lDocentes.Height = 111;
                    lDocentes.Width = 209;
                    lDocentes.BackColor = Color.FromArgb(196, 196, 196);
                    pnlUsu.Controls.Add(lDocentes);
                    if (ejeX < 800)
                    {
                        lDocentes.Location = new Point(ejeX, ejeY);
                        ejeX += 219;
                    }
                    else
                    {
                        ejeY += 121;
                        ejeX = 0;
                        lDocentes.Location = new Point(ejeX, ejeY);
                        ejeX += 219;
                    }

                    Label dCi = new Label();
                    dCi.Visible = false;
                    dCi.Text = Convert.ToString(docentes[x, 3]);
                    panel1.Controls.Add(dCi);

                    Label cod = new Label();
                    cod.Visible = false;
                    cod.Text = Convert.ToString(docentes[x, 0]);
                    panel1.Controls.Add(cod);

                    Label dApe = new Label();
                    dApe.Visible = false;
                    dApe.Text = Convert.ToString(docentes[x, 1]);
                    panel1.Controls.Add(dApe);

                    Label dGru = new Label();
                    dGru.Visible = false;
                    dGru.Text = Convert.ToString(docentes[x, 2]);
                    panel1.Controls.Add(dGru);

                    Label dNom = new Label();
                    dNom.Visible = false;
                    dNom.Text = Convert.ToString(docentes[x, 4]);
                    panel1.Controls.Add(dNom);




                    TemplateParteAdmin.MiniUsuExpandir a = new TemplateParteAdmin.MiniUsuExpandir(cod.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dNom.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lDocentes.Controls.Add(a);
                    a.Show();


                    a.Click += delegate (object enviar, EventArgs f)
                    {
                          VerUsuAdmin b = new VerUsuAdmin(cod.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dNom.Text);
                          b.ShowDialog();
                        
                    };
                }
            }
            comparar2 = docentes;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                
        }

        private void MenuPrincipalAdmin_Load(object sender, EventArgs e)
        {


        }

        private void panelUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {
            MenuUsuAdminCompleto f = new MenuUsuAdminCompleto();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlUsu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string[,] historialCon = (string[,])Admin.HistorialCon();

            if (historialCon.Length != comparar3.Length)
            {
                for (int x = 0; x < historialCon.GetLength(0); x++)
                {
                    Panel lHistorial = new Panel();
                    lHistorial.Height = 49;
                    lHistorial.Width = 850;
                    lHistorial.BackColor = Color.FromArgb(196, 196, 196);
                    panelHistorial.Controls.Add(lHistorial);
                        lHistorial.Location = new Point(0, ejeY);
                        ejeY += 49;


                    Label cod = new Label();
                    cod.Visible = false;
                    cod.Text = Convert.ToString(historialCon[x, 0]);
                    panel1.Controls.Add(cod);

                    Label ali = new Label();
                    ali.Visible = false;
                    ali.Text = Convert.ToString(historialCon[x, 1]);
                    panel1.Controls.Add(ali);

                    Label dCi = new Label();
                    dCi.Visible = false;
                    dCi.Text = Convert.ToString(historialCon[x, 2]);
                    panel1.Controls.Add(dCi);

                    Label dNom = new Label();
                    dNom.Visible = false;
                    dNom.Text = Convert.ToString(historialCon[x, 3]);
                    panel1.Controls.Add(dNom);

                    Label dApe = new Label();
                    dApe.Visible = false;
                    dApe.Text = Convert.ToString(historialCon[x, 4]);
                    panel1.Controls.Add(dApe);

                    Label aNom = new Label();
                    aNom.Visible = false;
                    aNom.Text = Convert.ToString(historialCon[x, 5]);
                    panel1.Controls.Add(aNom);

                    Label gOri = new Label();
                    gOri.Visible = false;
                    gOri.Text = Convert.ToString(historialCon[x, 6]);
                    panel1.Controls.Add(gOri);

                    Label gNom = new Label();
                    gNom.Visible = false;
                    gNom.Text = Convert.ToString(historialCon[x, 7]);
                    panel1.Controls.Add(gNom);

                    Label alNom = new Label();
                    alNom.Visible = false;
                    alNom.Text = Convert.ToString(historialCon[x, 8]);
                    panel1.Controls.Add(alNom);

                    Label alApe = new Label();
                    alApe.Visible = false;
                    alApe.Text = Convert.ToString(historialCon[x, 9]);
                    panel1.Controls.Add(alApe);

                    Label tCon = new Label();
                    tCon.Visible = false;
                    tCon.Text = Convert.ToString(historialCon[x, 10]);
                    panel1.Controls.Add(alApe);

                    TemplateParteAdmin.FORPanelChatsConsultasPrincipal a = new TemplateParteAdmin.FORPanelChatsConsultasPrincipal(dNom.Text+" "+dApe.Text, aNom.Text, gOri.Text, gNom.Text, alNom.Text+" "+alApe.Text, "Consulta") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lHistorial.Controls.Add(a);
                    a.Show();

                    a.Click += delegate (object enviar, EventArgs f)
                    {
                        string[,] b = (string[,])(Admin.HistorialCon());

                        string texto = alNom.Text + " " + alApe.Text +" - "+aNom.Text+" - "+tCon.Text+"\n";
                        texto += Consulta.Texto(Convert.ToInt32(cod.Text))+"\n";
                        texto += "-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------" + "\n";
                        texto += dNom.Text + " " + dApe.Text + "\n";
                        texto += Consulta.TextoRespuesta(Convert.ToInt32(cod.Text));
                        HistorialChatConsulta c = new HistorialChatConsulta(texto);
                        c.ShowDialog();

                    };

                }
            }
            comparar3 = historialCon;

            string[,] historialChat = (string[,])Admin.HistorialChat();

            if (historialChat.Length != comparar4.Length)
            {
                for (int x = 0; x < historialChat.GetLength(0); x++)
                {
                    Panel lHistorial = new Panel();
                    lHistorial.Height = 49;
                    lHistorial.Width = 850;
                    lHistorial.BackColor = Color.FromArgb(196, 196, 196);
                    panelHistorial.Controls.Add(lHistorial);
                    lHistorial.Location = new Point(0, ejeY);
                    ejeY += 49;


                    Label chCod = new Label();
                    chCod.Visible = false;
                    chCod.Text = Convert.ToString(historialChat[x, 0]);
                    panel1.Controls.Add(chCod);

                    Label docente = new Label();
                    docente.Visible = false;
                    docente.Text = Convert.ToString(historialChat[x, 1]);
                    panel1.Controls.Add(docente);

                    Label AlCi = new Label();
                    AlCi.Visible = false;
                    AlCi.Text = Convert.ToString(historialChat[x, 2]);
                    panel1.Controls.Add(AlCi);

                    Label ANom = new Label();
                    ANom.Visible = false;
                    ANom.Text = Convert.ToString(historialChat[x, 3]);
                    panel1.Controls.Add(ANom);

                    Label AlNom = new Label();
                    AlNom.Visible = false;
                    AlNom.Text = Convert.ToString(historialChat[x, 4]);
                    panel1.Controls.Add(AlNom);

                    Label AlApe = new Label();
                    AlApe.Visible = false;
                    AlApe.Text = Convert.ToString(historialChat[x, 5]);
                    panel1.Controls.Add(AlApe);

                    Label DNom = new Label();
                    DNom.Visible = false;
                    DNom.Text = Convert.ToString(historialChat[x, 6]);
                    panel1.Controls.Add(DNom);

                    Label DApe = new Label();
                    DApe.Visible = false;
                    DApe.Text = Convert.ToString(historialChat[x, 7]);
                    panel1.Controls.Add(DApe);

                    Label GNom = new Label();
                    GNom.Visible = false;
                    GNom.Text = Convert.ToString(historialChat[x, 8]);
                    panel1.Controls.Add(GNom);

                    Label GOri = new Label();
                    GOri.Visible = false;
                    GOri.Text = Convert.ToString(historialChat[x, 9]);
                    panel1.Controls.Add(GOri);

                    TemplateParteAdmin.FORPanelChatsConsultasPrincipal a = new TemplateParteAdmin.FORPanelChatsConsultasPrincipal(DNom.Text + " " + DApe.Text, ANom.Text, GOri.Text, GNom.Text, AlNom.Text + " " + AlApe.Text, "Chat") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lHistorial.Controls.Add(a);
                    a.Show();

                    a.Click += delegate (object enviar, EventArgs f)
                    {
                        string[,] b = (string[,])(Admin.HistorialCon());

                        string texto = Chat.obtHisChat(Convert.ToInt32(chCod.Text));
                        HistorialChatConsulta c = new HistorialChatConsulta(texto);
                        c.ShowDialog();

                    };

                }
            }
            comparar4 = historialChat;
        }


    }
    }

    



