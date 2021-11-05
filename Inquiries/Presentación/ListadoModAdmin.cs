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
    public partial class ListadoModAdmin : Form
    {
        private static string[,] comparar = new string[0, 0];
        public ListadoModAdmin()
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
                    Panel lAlumnos = new Panel();
                    lAlumnos.Height = 50;
                    lAlumnos.Width = 908;
                    lAlumnos.BackColor = Color.FromArgb(196, 196, 196);
                    panelGrupos.Controls.Add(lAlumnos);
                    lAlumnos.Dock = DockStyle.Top;


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
                    gCod.Text = Convert.ToString(grupos[x, 1]);
                    panel1.Controls.Add(gNom);

                    TemplateParteAdmin.FORPanelModGruposAdmin a = new TemplateParteAdmin.FORPanelModGruposAdmin(gNom.Text,Convert.ToInt32(gCod.Text)) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
                    lAlumnos.Controls.Add(a);
                    a.Show();

                    a.Click += delegate (object enviar, EventArgs f)
                    {

                        TemplateParteAdmin.ModificarGrupoAdmin b = new TemplateParteAdmin.ModificarGrupoAdmin(gCod.Text, gNom.Text);
                        b.ShowDialog();

                    };

                }
            }
            comparar = grupos;

        }
    }
}
