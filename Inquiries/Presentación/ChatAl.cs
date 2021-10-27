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

namespace Inquiries
{
    public partial class ChatAl : Form
    {
        
        public ChatAl(string ci)
        {
            InitializeComponent();
            txtDCI.Text = ci;
            Timer r = new Timer
            {
                Interval = 300
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
                Chat.EnviarMensaje(Convert.ToInt32(txtDCI.Text), Chat.getCIact(), Convert.ToString(txtMensaje.Text));
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ChatAl_Load(object sender, EventArgs e)
        {

        }
    }
}
