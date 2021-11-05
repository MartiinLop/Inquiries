using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inquiries;

namespace TemplateParteAdmin
{
    public partial class ListarPartGrupo : Form
    {
        private string Gcod;
        private static string[,] comparar = new string[0, 0];
        private static string[,] comparar2 = new string[0, 0];
        public ListarPartGrupo(string gcod)
        {
            InitializeComponent();
            Gcod = gcod;
        }

        private void ListarPartGrupo_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string[,] integrantesAl = (string[,])Admin.obtAlumnosGrup(Gcod);
            if (integrantesAl.Length != comparar2.Length)
                {
                    for (int x = 0; x < integrantesAl.GetLength(0); x++)
                    {
                        Panel lGrupos = new Panel();
                        lGrupos.Height = 45;
                        lGrupos.Width = 619;
                        lGrupos.BackColor = Color.FromArgb(196, 196, 196);
                        panelPartGrupo.Controls.Add(lGrupos);
                        lGrupos.Dock = DockStyle.Top;

                        Label alci = new Label();
                        alci.Visible = false;
                        alci.Text = Convert.ToString(integrantesAl[x, 1]);
                        panel1.Controls.Add(alci);

                        Label alnom = new Label();
                        alnom.Visible = false;
                        alnom.Text = Convert.ToString(integrantesAl[x, 2]);
                        panel1.Controls.Add(alnom);

                        Label alape = new Label();
                        alape.Visible = false;
                        alape.Text = Convert.ToString(integrantesAl[x, 3]);
                        panel1.Controls.Add(alape);
                    
                        TemplateParteAdmin.FORPanelIntegrantesGrupo a = new TemplateParteAdmin.FORPanelIntegrantesGrupo(alnom.Text + " " + alape.Text, alci.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        lGrupos.Controls.Add(a);
                        a.Show();

                }
                    comparar2 = integrantesAl;



            }

            string[,] integrantesDoc = (string[,])Admin.obtDocentesGrup(Gcod);
            if (integrantesDoc.Length != comparar.Length)
                {
                    for (int x = 0; x < integrantesDoc.GetLength(0); x++)
                    {
                        Panel lGrupos = new Panel();
                        lGrupos.Height = 45;
                        lGrupos.Width = 619;
                        lGrupos.BackColor = Color.FromArgb(196, 196, 196);
                        panelPartGrupo.Controls.Add(lGrupos);
                        lGrupos.Dock = DockStyle.Top;



                        Label dci = new Label();
                        dci.Visible = false;
                        dci.Text = Convert.ToString(integrantesDoc[x, 1]);
                        panel1.Controls.Add(dci);

                        Label dNom = new Label();
                        dNom.Visible = false;
                        dNom.Text = Convert.ToString(integrantesDoc[x, 2]);
                        panel1.Controls.Add(dNom);

                        Label dApe = new Label();
                        dApe.Visible = false;
                        dApe.Text = Convert.ToString(integrantesDoc[x, 3]);
                        panel1.Controls.Add(dApe);

                        TemplateParteAdmin.FORPanelIntegrantesGrupo a = new TemplateParteAdmin.FORPanelIntegrantesGrupo(dNom.Text + " " + dApe.Text, dci.Text) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                        lGrupos.Controls.Add(a);
                        a.Show();

                    }
                    comparar = integrantesDoc;



            }
        }
    }
}
