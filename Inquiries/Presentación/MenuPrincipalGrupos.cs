﻿using System;
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
    public partial class MenuPrincipalGrupos : Form
    {
        private static string[,] comparar = new string[0, 0];

        public MenuPrincipalGrupos()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[,] grupos = (string[,])Admin.obtGrupos();


            if (grupos.Length != comparar.Length)
            {
                for (int x = 0; x < grupos.GetLength(0); x++)
                {
                    Panel lGrupos = new Panel();
                    lGrupos.Height = 47;
                    lGrupos.Width = 892;
                    lGrupos.BackColor = Color.FromArgb(196, 196, 196);
                    panelGrupos.Controls.Add(lGrupos);
                    lGrupos.Dock = DockStyle.Top;

                    TemplateParteAdmin.FORPanelModGruposAdmin a = new TemplateParteAdmin.FORPanelModGruposAdmin(grupos[x, 1],Convert.ToInt32(grupos[x, 2])) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lGrupos.Controls.Add(a);
                    a.Show();

                    Label aNom = new Label();
                    aNom.Visible = false;
                    aNom.Text = Convert.ToString(grupos[x, 0]);
                    panel1.Controls.Add(aNom);

                    Label gNom = new Label();
                    gNom.Visible = false;
                    gNom.Text = Convert.ToString(grupos[x, 1]);
                    panel1.Controls.Add(gNom);

                    Label gCod = new Label();
                    gCod.Visible = false;
                    gCod.Text = Convert.ToString(grupos[x, 0]);
                    panel1.Controls.Add(gCod);



                    a.Click += delegate (object enviar, EventArgs f)
                    {

                        //VerUsuAdmin b = new VerUsuAdmin(alNom.Text, alApe.Text, alCi.Text, alGru.Text, "Alumno", alCon.Text);
                        //b.ShowDialog();

                    };

                }
            }
            comparar = grupos;
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            TemplateParteAdmin.CrearGrupoAdmin f = new TemplateParteAdmin.CrearGrupoAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnMod_Click(object sender, EventArgs e)
        {
            ListadoModAdmin f = new ListadoModAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnElim_Click(object sender, EventArgs e)
        {
            TemplateParteAdmin.ElimGruposAdmin f = new TemplateParteAdmin.ElimGruposAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
