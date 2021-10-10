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
    public partial class MenuChatAl : Form
    {
        public MenuChatAl()
        {
            InitializeComponent();
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
                listBox1.Items.Add(a);
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
    }
}
