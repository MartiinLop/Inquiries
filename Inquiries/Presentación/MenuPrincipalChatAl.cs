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
    public partial class MenuPrincipalChatAl : Form
    {
      
        protected static string[,] comparar = new string[0, 0];
        protected static Boolean mensaje = false;
     
        public MenuPrincipalChatAl()
        {
            InitializeComponent();
            mensaje = false;
            timer1.Enabled = true;

        }
        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void invChatAl(object sender, EventArgs e, string c)
        {

            ChatAl a = new ChatAl(c);
            a.ShowDialog();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {

            Chat z = new Chat();
            string[,] codChat = (string[,])Chat.obtCodigosChatAl();
            

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
                        nomprof.Visible = true;
                        nomprof.BackColor = Color.FromArgb(143, 131, 131);
                        nomprof.ForeColor = Color.Black;
                        nomprof.Text = Convert.ToString(codChat[x, 0]);
                        nomprof.Width = 500;
                        chat.Controls.Add(nomprof);


                        nomprof.Click += delegate (object enviar, EventArgs f)
                        {

                            invChatAl(enviar, f, Convert.ToString(cod.Text));
                            
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuChatAl f1 = new MenuChatAl();
            f1.ShowDialog();
        }

        private void MenuPrincipalChatAl_Load(object sender, EventArgs e)
        {

        }

        
    }
}
