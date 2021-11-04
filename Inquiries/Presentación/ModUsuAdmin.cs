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
    public partial class ModUsuAdmin : Form
    {
        private static string[,] comparar = new string[0, 0];
        private static string[,] comparar2 = new string[0, 0];
        private int v = 0;
        protected int ejeX = 0;
        protected int ejeY = 0;
        public ModUsuAdmin()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[,] alumnos = (string[,])Admin.ObtenerUsuariosAl();


            if (alumnos.Length != comparar.Length)
            {
                for (int x = 0; x < alumnos.GetLength(0); x++)
                {
                    Panel lAlumnos = new Panel();
                    lAlumnos.Height = 50;
                    lAlumnos.Width = 908;
                    lAlumnos.BackColor = Color.FromArgb(196, 196, 196);
                    panelUsuarios.Controls.Add(lAlumnos);
                    lAlumnos.Dock = DockStyle.Top;

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

                    TemplateParteAdmin.FORPanelModUsuAdmin a = new TemplateParteAdmin.FORPanelModUsuAdmin(alNom.Text, alApe.Text, alGru.Text, "Alumno", Convert.ToInt32(alCi.Text)) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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

            string[,] docentes = (string[,])Admin.ObtenerUsuariosDoc();


            if (docentes.Length != comparar2.Length)
            {
                for (int x = 0; x < docentes.GetLength(0); x++)
                {

                    Panel lDocentes = new Panel();
                    lDocentes.Height = 50;
                    lDocentes.Width = 908;
                    lDocentes.BackColor = Color.FromArgb(196, 196, 196);
                    panelUsuarios.Controls.Add(lDocentes);
                    lDocentes.Dock = DockStyle.Top;


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

                    TemplateParteAdmin.FORPanelModUsuAdmin a = new TemplateParteAdmin.FORPanelModUsuAdmin(dNom.Text, dApe.Text, dGru.Text, "Docente", Convert.ToInt32(dCi.Text)) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
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
    }
    
}
