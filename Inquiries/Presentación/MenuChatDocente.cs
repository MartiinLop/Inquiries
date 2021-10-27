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
    public partial class MenuChatDocente : Form
    {
        private static string a;
        private static string[,] comparar = new string[0, 0];
        public MenuChatDocente()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void MenuChatDocente_Load(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void invChatDoc(object sender, EventArgs e, string c)
        {

            ChatDoc a = new ChatDoc(c);
            a.ShowDialog();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string[,] datosProf = (string[,])Chat.ObtenerDoc();
            int test = 0;

            if (datosProf.Length != comparar.Length)
            {
                for (int x = 0; x < datosProf.GetLength(0); x++)
                {
                    Chat z = new Chat();

                    Panel chat = new Panel();
                    chat.Height = 73;
                    chat.Width = 500;
                    panelChats.Controls.Add(chat);
                    chat.Dock = DockStyle.Top;


                    Label usuario = new Label();
                    usuario.Visible = false;
                    usuario.Text = Convert.ToString(datosProf[x, 0]);
                    panelChats.Controls.Add(usuario);

                    RichTextBox nomprof = new RichTextBox();
                    nomprof.BackColor = Color.FromArgb(143, 131, 131);
                    nomprof.ForeColor = Color.Black;
                    nomprof.Text = Convert.ToString(datosProf[x, 1] + " " + datosProf[x, 2]);
                    nomprof.Width = 500;
                    chat.Controls.Add(nomprof);


                    nomprof.Click += delegate (object enviar, EventArgs f)
                    {
                        if (comboBox1.Text == "")
                        {

                            MessageBox.Show("Debe seleccionar materia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            invChatDoc(enviar, f, Convert.ToString(usuario.Text));
                            {

                                chat.Controls.Add(nomprof);
                                Chat.crearChat(Chat.obtcodChat(), Convert.ToInt32(usuario.Text), Asignatura.obtenerCodigo(comboBox1.Text), true);


                            };
                        }
                    };

                }
                comparar = datosProf;
            }

        }
    }
}
