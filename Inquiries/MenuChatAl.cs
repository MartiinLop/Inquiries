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
            Chat.EnviarChat(Convert.ToInt32(txtDCI.Text), Convert.ToString(txtMensaje.Text));
            listBox1.Items.Clear();
            MySqlDataAdapter datos = new MySqlDataAdapter();
            Chat c = new Chat();
            datos = c.VerMensaje();

        }
    }
}
