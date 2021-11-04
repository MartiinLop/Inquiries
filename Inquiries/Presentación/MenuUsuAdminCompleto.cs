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
    public partial class MenuUsuAdminCompleto : Form
    {
        private static string[,] comparar = new string[0, 0];
        private static string[,] comparar2 = new string[0, 0];
        private int v = 0;
        protected int ejeX = 0;
        protected int ejeY = 0;
        public MenuUsuAdminCompleto()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            CrearUsuAdmin f = new CrearUsuAdmin();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditarUsuAdmin f = new EditarUsuAdmin();
            f.ShowDialog();
            this.Show();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
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

                    TemplateParteAdmin.FORPanelDatosUsuAdmin a = new TemplateParteAdmin.FORPanelDatosUsuAdmin(alumnos[x, 0]+" "+ alumnos[x, 1], alumnos[x, 2],"Alumno") { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
                    lAlumnos.Controls.Add(a);
                    a.Show();


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

                    TemplateParteAdmin.FORPanelDatosUsuAdmin a = new TemplateParteAdmin.FORPanelDatosUsuAdmin(docentes[x, 0] + " " + docentes[x, 1], docentes[x, 2], "Docente") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lDocentes.Controls.Add(a);
                    a.Show();


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


                    a.Click += delegate (object enviar, EventArgs f)
                    {
                        VerUsuAdmin b = new VerUsuAdmin(dNom.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dCon.Text);
                        b.ShowDialog();

                    };
                }
            }
            comparar2 = docentes;
        }

        private void btnFCedula_Click(object sender, EventArgs e)
        {
            if (txtFCedula.Text != "") {
                string[,] FDataAl = (string[,])(Admin.FiltrarDatosAlumno(txtFCedula.Text, null));
                string[,] FDataDoc = (string[,])(Admin.FiltrarDatosDocente(txtFCedula.Text, null));
                
                panelUsuarios.Controls.Clear();
                if (FDataAl.Length != comparar.Length)
                {
                    
                    for (int x = 0; x < FDataAl.GetLength(0); x++)
                     {
                    Panel lAlumnos = new Panel();
                    lAlumnos.Height = 50;
                    lAlumnos.Width = 908;
                    lAlumnos.BackColor = Color.FromArgb(196, 196, 196);
                    panelUsuarios.Controls.Add(lAlumnos);
                    lAlumnos.Dock = DockStyle.Top;

                    TemplateParteAdmin.FORPanelDatosUsuAdmin a = new TemplateParteAdmin.FORPanelDatosUsuAdmin(FDataAl[x, 0]+" "+ FDataAl[x, 1], FDataAl[x, 2],"Alumno") { Dock = DockStyle.Fill, TopLevel = false, TopMost= true };
                    lAlumnos.Controls.Add(a);
                    a.Show();


                    Label alCi = new Label();
                    alCi.Visible = false;
                    alCi.Text = Convert.ToString(FDataAl[x, 3]);
                    panel1.Controls.Add(alCi);

                    Label alNom = new Label();
                    alNom.Visible = false;
                    alNom.Text = Convert.ToString(FDataAl[x, 0]);
                    panel1.Controls.Add(alNom);

                    Label alApe = new Label();
                    alApe.Visible = false;
                    alApe.Text = Convert.ToString(FDataAl[x, 1]);
                    panel1.Controls.Add(alApe);

                    Label alGru = new Label();
                    alGru.Visible = false;
                    alGru.Text = Convert.ToString(FDataAl[x, 2]);
                    panel1.Controls.Add(alGru);

                    Label alCon = new Label();
                    alCon.Visible = false;
                    alCon.Text = Convert.ToString(FDataAl[x, 4]);
                    panel1.Controls.Add(alCon);


                    a.Click += delegate (object enviar, EventArgs f)
                    {

                        VerUsuAdmin b = new VerUsuAdmin(alNom.Text, alApe.Text, alCi.Text, alGru.Text, "Alumno", alCon.Text);
                        b.ShowDialog();

                    };

                }
            }
                if (FDataDoc.Length != comparar.Length)
                {
                    for (int x = 0; x < FDataDoc.GetLength(0); x++)
                    {

                        Panel lDocentes = new Panel();
                        lDocentes.Height = 50;
                        lDocentes.Width = 908;
                        lDocentes.BackColor = Color.FromArgb(196, 196, 196);
                        panelUsuarios.Controls.Add(lDocentes);
                        lDocentes.Dock = DockStyle.Top;

                        TemplateParteAdmin.FORPanelDatosUsuAdmin a = new TemplateParteAdmin.FORPanelDatosUsuAdmin(FDataDoc[x, 0] + " " + FDataDoc[x, 1], FDataDoc[x, 2], "Docente") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        lDocentes.Controls.Add(a);
                        a.Show();


                        Label dCi = new Label();
                        dCi.Visible = false;
                        dCi.Text = Convert.ToString(FDataDoc[x, 3]);
                        panel1.Controls.Add(dCi);

                        Label dNom = new Label();
                        dNom.Visible = false;
                        dNom.Text = Convert.ToString(FDataDoc[x, 0]);
                        panel1.Controls.Add(dNom);

                        Label dApe = new Label();
                        dApe.Visible = false;
                        dApe.Text = Convert.ToString(FDataDoc[x, 1]);
                        panel1.Controls.Add(dApe);

                        Label dGru = new Label();
                        dGru.Visible = false;
                        dGru.Text = Convert.ToString(FDataDoc[x, 2]);
                        panel1.Controls.Add(dGru);

                        Label dCon = new Label();
                        dCon.Visible = false;
                        dCon.Text = Convert.ToString(FDataDoc[x, 4]);
                        panel1.Controls.Add(dCon);


                        a.Click += delegate (object enviar, EventArgs f)
                        {
                            VerUsuAdmin b = new VerUsuAdmin(dNom.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dCon.Text);
                            b.ShowDialog();

                        };
                    }
                }
            }


        }

        private void btnEFiltros_Click(object sender, EventArgs e)
        {
            panelUsuarios.Controls.Clear();
            comparar = new string[0, 0];
            comparar2 = new string[0, 0];
        }

        private void btnFNom_Click(object sender, EventArgs e)
        {
            if (txtFNom.Text != "")
            {
                string[,] FDataAl = (string[,])(Admin.FiltrarDatosAlumno(null, txtFNom.Text));
                string[,] FDataDoc = (string[,])(Admin.FiltrarDatosDocente(null, txtFNom.Text));

                panelUsuarios.Controls.Clear();
                if (FDataAl.Length != comparar.Length)
                {

                    for (int x = 0; x < FDataAl.GetLength(0); x++)
                    {
                        Panel lAlumnos = new Panel();
                        lAlumnos.Height = 50;
                        lAlumnos.Width = 908;
                        lAlumnos.BackColor = Color.FromArgb(196, 196, 196);
                        panelUsuarios.Controls.Add(lAlumnos);
                        lAlumnos.Dock = DockStyle.Top;

                        TemplateParteAdmin.FORPanelDatosUsuAdmin a = new TemplateParteAdmin.FORPanelDatosUsuAdmin(FDataAl[x, 0] + " " + FDataAl[x, 1], FDataAl[x, 2], "Alumno") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        lAlumnos.Controls.Add(a);
                        a.Show();


                        Label alCi = new Label();
                        alCi.Visible = false;
                        alCi.Text = Convert.ToString(FDataAl[x, 3]);
                        panel1.Controls.Add(alCi);

                        Label alNom = new Label();
                        alNom.Visible = false;
                        alNom.Text = Convert.ToString(FDataAl[x, 0]);
                        panel1.Controls.Add(alNom);

                        Label alApe = new Label();
                        alApe.Visible = false;
                        alApe.Text = Convert.ToString(FDataAl[x, 1]);
                        panel1.Controls.Add(alApe);

                        Label alGru = new Label();
                        alGru.Visible = false;
                        alGru.Text = Convert.ToString(FDataAl[x, 2]);
                        panel1.Controls.Add(alGru);

                        Label alCon = new Label();
                        alCon.Visible = false;
                        alCon.Text = Convert.ToString(FDataAl[x, 4]);
                        panel1.Controls.Add(alCon);


                        a.Click += delegate (object enviar, EventArgs f)
                        {

                            VerUsuAdmin b = new VerUsuAdmin(alNom.Text, alApe.Text, alCi.Text, alGru.Text, "Alumno", alCon.Text);
                            b.ShowDialog();

                        };

                    }
                }
                if (FDataDoc.Length != comparar.Length)
                {
                    for (int x = 0; x < FDataDoc.GetLength(0); x++)
                    {

                        Panel lDocentes = new Panel();
                        lDocentes.Height = 50;
                        lDocentes.Width = 908;
                        lDocentes.BackColor = Color.FromArgb(196, 196, 196);
                        panelUsuarios.Controls.Add(lDocentes);
                        lDocentes.Dock = DockStyle.Top;

                        TemplateParteAdmin.FORPanelDatosUsuAdmin a = new TemplateParteAdmin.FORPanelDatosUsuAdmin(FDataDoc[x, 0] + " " + FDataDoc[x, 1], FDataDoc[x, 2], "Docente") { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        lDocentes.Controls.Add(a);
                        a.Show();


                        Label dCi = new Label();
                        dCi.Visible = false;
                        dCi.Text = Convert.ToString(FDataDoc[x, 3]);
                        panel1.Controls.Add(dCi);

                        Label dNom = new Label();
                        dNom.Visible = false;
                        dNom.Text = Convert.ToString(FDataDoc[x, 0]);
                        panel1.Controls.Add(dNom);

                        Label dApe = new Label();
                        dApe.Visible = false;
                        dApe.Text = Convert.ToString(FDataDoc[x, 1]);
                        panel1.Controls.Add(dApe);

                        Label dGru = new Label();
                        dGru.Visible = false;
                        dGru.Text = Convert.ToString(FDataDoc[x, 2]);
                        panel1.Controls.Add(dGru);

                        Label dCon = new Label();
                        dCon.Visible = false;
                        dCon.Text = Convert.ToString(FDataDoc[x, 4]);
                        panel1.Controls.Add(dCon);


                        a.Click += delegate (object enviar, EventArgs f)
                        {
                            VerUsuAdmin b = new VerUsuAdmin(dNom.Text, dApe.Text, dCi.Text, dGru.Text, "Docente", dCon.Text);
                            b.ShowDialog();

                        };
                    }
                }
            }

        }
    }
}
