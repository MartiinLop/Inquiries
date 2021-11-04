﻿using System;
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
            panelUsuarios.Hide();

            r.Enabled = true;

        }

        private void btnGruposAl_Click(object sender, EventArgs e)
        {



        }

        private void btnConsultasAl_Click(object sender, EventArgs e)
        {

            if (v == 0)
            {
                v = 1;
                r.Tick += new System.EventHandler(crearPaneles);
                pnlUsu.Show();
                panelUsuarios.Show();
                timer1.Enabled = true;
            }
            else
            {
                v = 0;
                pnlUsu.Hide();
                panelUsuarios.Hide();
                timer1.Enabled = false;
            }


               

           
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


                    TemplateParteAdmin.MiniUsuExpandir a = new TemplateParteAdmin.MiniUsuExpandir(dNom.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dCon.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lDocentes.Controls.Add(a);
                    a.Show();


                    a.Click += delegate (object enviar, EventArgs f)
                    {
                          VerUsuAdmin b = new VerUsuAdmin(dNom.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dCon.Text);
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
    }

}

