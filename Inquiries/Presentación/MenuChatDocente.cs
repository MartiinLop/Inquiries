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

        private static string[,] comparar = new string[0,0];
        private static Boolean mensaje = false;
        public MenuChatDocente()
        {
            InitializeComponent();
            mensaje = false;
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
            string ci = Chat.ciAlumno(Convert.ToInt32(c));
            ChatDoc a = new ChatDoc(ci);
            a.ShowDialog();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Chat z = new Chat();
            string[,] codChat = (string[,])Chat.obtCodigosChatDoc();
            Console.WriteLine(codChat.Length);

            if (codChat.Length != comparar.Length)
            {
                for (int x = 0; x < codChat.GetLength(0); x++)
                {

                    if (Convert.ToBoolean(codChat[x, 1]) == true)
                    {

                        Panel chat = new Panel();
                        chat.Height = 73;
                        chat.Width = 500;
                        panelChats.Controls.Add(chat);
                        chat.Dock = DockStyle.Top;


                        Label cod = new Label();
                        cod.Visible = false;
                        cod.Text = Convert.ToString(codChat[x, 0]);
                        panelChats.Controls.Add(cod);

                        RichTextBox nomprof = new RichTextBox();
                        nomprof.BackColor = Color.FromArgb(143, 131, 131);
                        nomprof.ForeColor = Color.Black;
                        nomprof.Text = Chat.ciAlumno(Convert.ToInt32(codChat[x, 0]));
                        nomprof.Width = 500;
                        chat.Controls.Add(nomprof);


                        nomprof.Click += delegate (object enviar, EventArgs f)
                        {

                            invChatDoc(enviar, f, Convert.ToString(cod.Text));

                        };

                    }
                    else
                    {
                        if (mensaje == false)
                        {
                            mensaje = true;
                            MessageBox.Show("xd");
                        }
                    }
                    comparar = codChat;
                }
            }

        }

        private void panelChats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSalirPrincipal_Click_1(object sender, EventArgs e)
        {
            comparar = new string[0, 0];
            this.Dispose();
        }

        private void MenuChatDocente_Load_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
