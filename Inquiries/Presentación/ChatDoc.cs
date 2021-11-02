using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Inquiries.RJControls;

namespace Inquiries
{
    public partial class ChatDoc : Form
    {
        public ChatDoc(string c)
        {

            InitializeComponent();
            txtAlCI.Hide();
            Timer r = new Timer
            {
                Interval = 300
            };
            r.Enabled = true;
            r.Tick += new System.EventHandler(AcMen);
            txtAlCI.Text = c;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                Chat.EnviarMensaje(Convert.ToString(txtMensaje.Text));
                txtMensaje.Text = "";
            //}catch (Exception)
            //{
            //    MessageBox.Show("Error al enviar mensaje", "Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}   
        }

        private void btnChatAl_Click(object sender, EventArgs e)
        {

        }

        private void AcMen(object source, EventArgs e)
        {
            string a = Chat.RecibirMensaje(Convert.ToInt32(txtAlCI.Text));
            if (a != null)
            {

                string[] dividir = a.Split(':');
                string nomEm = dividir[0];
                string menEm = dividir[1];

                if (Chat.EmioRec())
                {
                    Panel mensajesEnviados = new Panel();
                    mensajesEnviados.Height = 59;
                    panel3.Controls.Add(mensajesEnviados);
                    mensajesEnviados.Dock = DockStyle.Bottom;

                    Label nomemisor = new Label();
                    mensajesEnviados.Controls.Add(nomemisor);
                    nomemisor.Location = new Point(660, 20);
                    nomemisor.Text = nomEm;
                    nomemisor.ForeColor = Color.Black;
                    nomemisor.BackColor = Color.FromArgb(236, 236, 236);
                    nomemisor.Font = new Font("Roboto", 16);
                    nomemisor.Visible = true;

                    InquiriesTextBox txtE = new InquiriesTextBox();
                    txtE.BackColor = Color.FromArgb(236, 236, 236);
                    txtE.ForeColor = Color.Black;
                    txtE.BorderSize = 1;
                    txtE.Font = new Font("Roboto", 28);
                    txtE.BorderColor = Color.FromArgb(0, 0, 0);
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

                    Label nomemisor = new Label();
                    mensajesReceptor.Controls.Add(nomemisor);
                    nomemisor.Location = new Point(660, 20);
                    nomemisor.Text = nomEm;
                    nomemisor.ForeColor = Color.Black;
                    nomemisor.BackColor = Color.FromArgb(236, 236, 236);
                    nomemisor.Font = new Font("Roboto", 16);
                    nomemisor.Visible = true;

                    InquiriesTextBox txtR = new InquiriesTextBox();
                    txtR.BackColor = Color.FromArgb(2, 196, 196, 196);
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
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ChatDoc_Load(object sender, EventArgs e)
        {

        }
    }
}
