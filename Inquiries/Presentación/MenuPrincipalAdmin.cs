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
        private static string a;
        private static string[,] comparar = new string[0, 0];
        private static Boolean mensaje = false;
        private int v = 0;
        public MenuPrincipalAdmin()
        {
            InitializeComponent();

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
            this.Hide();
            MenuUsuAdminCompleto f = new MenuUsuAdminCompleto();
            f.ShowDialog();
            this.Show();
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
        private void invInfoUsu(object sender, EventArgs e, string a)
        {

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
                Admin z = new Admin();
                string[,] usuario = (string[,])Admin.ObtenerUsuarios();
                int test = 0;

            if (usuario.Length != comparar.Length)
            {
                for (int x = 0; x < usuario.GetLength(0); x++)
                {
                    for (int y = 0; y < usuario.GetLength(1); y++)
                    {
                        Panel lusuarios = new Panel();
                        lusuarios.Height = 80;
                        lusuarios.Width = 80;
                        //if (lusuarios.)
                        panel2.Controls.Add(lusuarios);
                        lusuarios.Dock = DockStyle.Left;
                        

                        Label usuCI = new Label();
                        usuCI.Visible = false;
                        usuCI.Text = Convert.ToString(usuario[x, 0]);
                        panel2.Controls.Add(usuCI);

                        RichTextBox datosUsu = new RichTextBox();
                        datosUsu.BackColor = Color.FromArgb(143, 131, 131);
                        datosUsu.ForeColor = Color.Black;
                        datosUsu.Text = Chat.ciAlumno(Convert.ToInt32(usuario[x, 0]));
                        datosUsu.Width = 500;
                        lusuarios.Controls.Add(datosUsu);


                        datosUsu.Click += delegate (object enviar, EventArgs f)
                        {

                            invInfoUsu(enviar, f, Convert.ToString(usuCI.Text));
                            {

                            }
                        };
                    }
                }
            }
            else
            {
                if (mensaje == false)
                {
                    mensaje = true;
                    MessageBox.Show("xd");
                }
            }
                        comparar = usuario;
                    
                    }
                }

            }

