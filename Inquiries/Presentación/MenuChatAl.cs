using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;



namespace Inquiries.Presentación
{
    public partial class MenuChatAl : Form
    {
        ArrayList lista = new ArrayList();
        private static string a;
        private static string[,] comparar = new string[0, 0];
        public MenuChatAl()
        {
            InitializeComponent();
        }

        private void panelChats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void MenuChatAl_Load(object sender, EventArgs e)
        {
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

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            string[,] datosProf = (string[,])Chat.ObtenerDoc();
            Boolean a = true;
            int test = 0;
            try
            {
                if (datosProf.Length <= comparar.Length)
                {
                    for (int i = 0; i < datosProf.Length; i++)
                    {
                        for (int j = 0; j < comparar.Length; j++)
                        {
                            if (datosProf[i, 0] == comparar[j, 0] && datosProf[i, 1] == comparar[j, 1])
                            {
                                test++;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                test++;
            }

            if (test == 0)
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
                        invChatAl(enviar, f, Convert.ToString(usuario.Text));
                        {
                            
                            chat.Controls.Add(nomprof);
                            
                        };

                    };
                }
                comparar = datosProf;
            }
        }
    }
}
