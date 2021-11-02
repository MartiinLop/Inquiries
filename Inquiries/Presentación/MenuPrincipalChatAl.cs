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
            comparar = new string[0, 0];
            timer1.Enabled = false;
            this.Dispose();
        }
        private void invChatAl(object sender, EventArgs e, string c,string z)
        {

            ChatAl a = new ChatAl(c,z);
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


                        Label CIProf = new Label();
                        CIProf.Visible = false;
                        CIProf.Text = Convert.ToString(codChat[x, 0]);
                        panelChats.Controls.Add(CIProf);

                        RichTextBox codCh = new RichTextBox();
                        codCh.Visible = true;
                        codCh.BackColor = Color.FromArgb(143, 131, 131);
                        codCh.ForeColor = Color.Black;
                        codCh.Text = Convert.ToString(codChat[x, 0]);
                        codCh.Width = 500;
                        chat.Controls.Add(codCh);


                        codCh.Click += delegate (object enviar, EventArgs f)
                        {

                            invChatAl(enviar, f, Convert.ToString(CIProf.Text),Convert.ToString(codCh.Text));
                            
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
            comparar = new string[0, 0];
            timer1.Enabled = false;
            this.Hide();
            MenuChatAl f1 = new MenuChatAl();
            f1.ShowDialog();
        }

        private void MenuPrincipalChatAl_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void panelChats_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
