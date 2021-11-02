using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Inquiries.RJControls;


namespace Inquiries
{
    public partial class ChatAl : Form
    {
        protected static string[,] comparar = new string[0, 0];
        protected static string[,] comparar0 = new string[0, 0];

        public ChatAl(string ci,string cod)
        {
            InitializeComponent();
            txtDCI.Text = ci;
            labelChCod.Text = cod;
            Timer r = new Timer
            {
                Interval = 500
            };
            r.Enabled = true;
            r.Tick += new System.EventHandler(AcMen);

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            try
            {
                Chat.EnviarMensaje(Convert.ToString(txtMensaje.Text));
                txtMensaje.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar mensaje", "Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AcMen(object source, EventArgs e)
        {
            string a = Chat.RecibirMensaje();
            if (a != null)
            {

                if (Chat.EmioRec())
                {
                    Panel mensajesEnviados = new Panel();
                    mensajesEnviados.Height = 59;
                    panel3.Controls.Add(mensajesEnviados);
                    mensajesEnviados.Dock = DockStyle.Bottom;

                    InquiriesTextBox txtE = new InquiriesTextBox();
                    txtE.BackColor = Color.FromArgb(236, 236, 236);
                    txtE.ForeColor = Color.Black;
                    txtE.BorderSize = 1;
                    txtE.Font = new Font("Roboto", 28);
                    txtE.BorderColor = Color.FromArgb(0,0,0);
                    txtE.BorderRadius = 10;
                    txtE.Texts = a;
                    
                    txtE.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    mensajesEnviados.Controls.Add(txtE);
                    txtE.Location = new Point(400, 7);



                }
                else
                {
                    Panel mensajesReceptor = new Panel();
                    mensajesReceptor.Height = 59;
                    panel3.Controls.Add(mensajesReceptor);
                    mensajesReceptor.Dock = DockStyle.Bottom;

                    InquiriesTextBox txtR = new InquiriesTextBox();
                    txtR.BackColor = Color.FromArgb(196,196,196);
                    txtR.BorderSize = 1;
                    txtR.Font = new Font("Roboto", 28);
                    txtR.ForeColor = Color.Black;
                    txtR.Texts = Convert.ToString(a);
                    txtR.BorderRadius = 10;
                    txtR.Texts = a;

                    txtR.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    mensajesReceptor.Controls.Add(txtR);
                    txtR.Location = new Point(69, 7);
                }
            }
            obtParticipantes(source,e);
        }

        private void obtParticipantes(object source, EventArgs e)
        {
            string[,] a = (string[,])Chat.alConectados(Convert.ToString(labelChCod.Text));
            if (a.Length != comparar.Length)
            {
                for (int x = 0; x < a.GetLength(0); x++)
                {
                    Panel AConectados = new Panel();
                    panelUsuarios.Controls.Add(AConectados);
                    AConectados.Dock = DockStyle.Top;

                    InquiriesTextBox usuariosA = new InquiriesTextBox();
                    usuariosA.BackColor = Color.FromArgb(236, 236, 236);
                    usuariosA.ForeColor = Color.Black;
                    usuariosA.BorderSize = 1;
                    usuariosA.Font = new Font("Roboto", 16);
                    usuariosA.BorderColor = Color.FromArgb(0, 0, 0);
                    usuariosA.BorderRadius = 10;
                    usuariosA.Texts = a[x,0] +" "+ a[x,1]+" - (Alumno)";

                    usuariosA.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    AConectados.Controls.Add(usuariosA);
                    usuariosA.Location = new Point(7, 7);
 
                }
                comparar = a;
            }

            string[,] b = (string[,])Chat.docConectados(Convert.ToString(labelChCod.Text));
            if (b.Length != comparar0.Length)
            {
                for (int x = 0; x < b.GetLength(0); x++)
                {
                    Panel DConectados = new Panel();
                    panelUsuarios.Controls.Add(DConectados);
                    DConectados.Dock = DockStyle.Top;

                    InquiriesTextBox usuariosD = new InquiriesTextBox();
                    usuariosD.BackColor = Color.FromArgb(236, 236, 236);
                    usuariosD.ForeColor = Color.Black;
                    usuariosD.BorderSize = 1;
                    usuariosD.Font = new Font("Roboto", 16);
                    usuariosD.BorderColor = Color.FromArgb(0, 0, 0);
                    usuariosD.BorderRadius = 10;
                    usuariosD.Texts = b[x, 0] + " " + b[x, 1]+" - (Docente)";

                    usuariosD.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    DConectados.Controls.Add(usuariosD);
                    usuariosD.Location = new Point(7, 7);

                }
                comparar0 = b;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            Chat.desactivarChat(Chat.obtcodChat());
            Chat.CreRes(Chat.obtcodChat());
            this.Dispose();
        }

        private void ChatAl_Load(object sender, EventArgs e)
        {
            txtDCI.Hide();
        }

        private void txtDCI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
