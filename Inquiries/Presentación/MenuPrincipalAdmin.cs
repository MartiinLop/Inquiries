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
    public partial class MenuPrincipalAdmin : Form
    {
        private static string[,] comparar = new string[0, 0];
        private static string[,] comparar2 = new string[0, 0];
        private int v = 0;
        protected int ejeX = 0;
        protected int ejeY = 0;
        int op = 0;
        Timer r = new Timer
        {
            Interval = 500
            
        };

        

        public MenuPrincipalAdmin()
        {
            InitializeComponent();
            op = 0;
            ejeX = 0;
            ejeY = 0;
           
            r.Enabled = true;

        }

        private void btnGruposAl_Click(object sender, EventArgs e)
        {

            if (v == 1)
            {
                panel2.Show();
                timer1.Enabled = true;
            }
            if (v == 0)
            {
                panel2.Hide();
                timer1.Enabled = false;
            }

            if (v == 1)
            {
                v = 0;
            }
            else
            {
                v = 1;
            }
        }

        private void btnConsultasAl_Click(object sender, EventArgs e)
        {

         
               
                r.Tick += new System.EventHandler(crearPaneles);
               

           
        }

        private void btnChatAl_Click(object sender, EventArgs e)
        {

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
            label1.Visible = true;
            label2.Visible = true;
            string[,] alumnos = (string[,])Admin.ObtenerUsuariosAl();

            if (alumnos.Length != comparar.Length)
            {
                for (int x = 0; x < alumnos.GetLength(0); x++)
                {
                    Panel lAlumnos = new Panel();
                    lAlumnos.Height = 50;
                    lAlumnos.Width = 200;
                    lAlumnos.BackColor = Color.FromArgb(196, 196, 196);
                    pnlAl.Controls.Add(lAlumnos);
                    lAlumnos.Dock = DockStyle.Left;

                    RichTextBox datosAl = new RichTextBox();
                    datosAl.Visible = true;
                    datosAl.BackColor = Color.FromArgb(143, 131, 131);
                    datosAl.ForeColor = Color.Black;
                    datosAl.Text = alumnos[x, 0] + " " + alumnos[x, 1] + "\n" + alumnos[x, 2] + " - Alumno";
                    datosAl.Width = 185;
                    datosAl.Height = 85;
                    datosAl.ReadOnly = true;
                    lAlumnos.Controls.Add(datosAl);

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


                    if (ejeX < 900)
                    {
                        lAlumnos.Location = new Point(ejeX, ejeY);
                        ejeX += 210;
                    }
                    else
                    {

                        lAlumnos.Location = new Point(ejeX, ejeY);
                        ejeY += 90;
                        ejeX = 0;
                    }

                    datosAl.Click += delegate (object enviar, EventArgs f)
                        {

                                VerUsuAdmin a = new VerUsuAdmin(alNom.Text, alApe.Text, alCi.Text, alGru.Text, "Alumno", alCon.Text);
                                a.ShowDialog();
                            
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
                    lDocentes.Height = 50;
                    lDocentes.Width = 200;
                    lDocentes.BackColor = Color.FromArgb(196, 196, 196);
                    pnlDoc.Controls.Add(lDocentes);
                    lDocentes.Dock = DockStyle.Left;

                    RichTextBox datosDoc = new RichTextBox();
                    datosDoc.Visible = true;
                    datosDoc.BackColor = Color.FromArgb(143, 131, 131);
                    datosDoc.ForeColor = Color.Black;
                    datosDoc.Text = docentes[x, 0] + " " + docentes[x, 1] + "\n" + docentes[x, 2] + " - Docente";
                    datosDoc.Width = 185;
                    datosDoc.Height = 85;
                    datosDoc.ReadOnly = true;
                    lDocentes.Controls.Add(datosDoc);

                    Label dCi = new Label();
                    dCi.Visible = false;
                    dCi.Text = Convert.ToString(docentes[x, 3]);
                    panel1.Controls.Add(dCi);

                    Label dNom = new Label();
                    dNom.Visible = false;
                    dNom.Text = Convert.ToString(docentes[x, 0]);
                    panel1.Controls.Add(dNom);

                    Label dApe = new Label();
                    dApe.Visible = false;
                    dApe.Text = Convert.ToString(docentes[x, 1]);
                    panel1.Controls.Add(dApe);

                    Label dGru = new Label();
                    dGru.Visible = false;
                    dGru.Text = Convert.ToString(docentes[x, 2]);
                    panel1.Controls.Add(dGru);

                    Label dCon = new Label();
                    dCon.Visible = false;
                    dCon.Text = Convert.ToString(docentes[x, 4]);
                    panel1.Controls.Add(dCon);


                    if (ejeX < 900)
                    {
                        lDocentes.Location = new Point(ejeX, ejeY);
                        ejeX += 210;
                    }
                    else
                    {

                        lDocentes.Location = new Point(ejeX, ejeY);
                        ejeY += 90;
                        ejeX = 0;
                    }

                    datosDoc.Click += delegate (object enviar, EventArgs f)
                    {
                          VerUsuAdmin a = new VerUsuAdmin(dNom.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dCon.Text);
                          a.ShowDialog();
                        
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
            label1.Visible = false;
            label2.Visible = false;
        }

        private void panelUsuarios_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnVerUsuarios_Click(object sender, EventArgs e)
        {

        }
    }

}

