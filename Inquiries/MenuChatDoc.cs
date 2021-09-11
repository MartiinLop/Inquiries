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
    public partial class MenuChatDoc : Form
    {
        public MenuChatDoc()
        {
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
            //Chat.EnviarMensaje(Convert.ToInt32(txtDCI.Text), Convert.ToString(txtMensaje.Text));
        }

        private void btnChatAl_Click(object sender, EventArgs e)
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
    }
}
