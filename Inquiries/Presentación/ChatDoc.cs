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

namespace Inquiries
{
    public partial class ChatDoc : Form
    {
        public ChatDoc(string c)
        {
            txtAlCI.Text = c;
            InitializeComponent();
            Timer r = new Timer
            {
                Interval = 300
            };
            r.Enabled = true;
            r.Tick += new System.EventHandler(AcMen);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //try
            //{
                Chat.EnviarMensaje(Chat.getCIact(), Convert.ToInt32(txtAlCI.Text), Convert.ToString(txtMensaje.Text));
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
            string a = Chat.RecibirMensaje();
            if (a != null)
            {
                if (Chat.EmioRec())
                {
                    listBox1.Items.Add(a);
                    Panel mensajesEnviados = new Panel();
                    mensajesEnviados.Height = 59;
                    panel3.Controls.Add(mensajesEnviados);
                    mensajesEnviados.Dock = DockStyle.Bottom;

                    RichTextBox txtE = new RichTextBox();
                    txtE.BackColor = Color.Black;
                    txtE.Font = new Font("Roboto", 12);
                    txtE.ForeColor = Color.White;
                    txtE.Text = a;

                    mensajesEnviados.Controls.Add(txtE);
                    txtE.Location = new Point(600, 7);
                }
                else
                {
                    listBox1.Items.Add(a);
                    Panel mensajesReceptor = new Panel();
                    mensajesReceptor.Height = 59;
                    panel3.Controls.Add(mensajesReceptor);
                    mensajesReceptor.Dock = DockStyle.Bottom;

                    RichTextBox txtR = new RichTextBox();
                    txtR.BackColor = Color.Black;
                    txtR.Font = new Font("Roboto", 12);
                    txtR.ForeColor = Color.White;
                    txtR.Text = a;

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
