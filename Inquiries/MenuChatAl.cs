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
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Chat.EnviarMensaje(Convert.ToInt32(txtDCI.Text), Convert.ToString(txtMensaje.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(Chat.RecibirMensaje());
        }
    }
}
