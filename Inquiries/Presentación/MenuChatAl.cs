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
    public partial class MenuChatAl : Form
    {
        public MenuChatAl()
        {
            InitializeComponent();
        }

        private void panelChats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //Crear metodo que selecione a todos los docentes que devuelva MySqlDataAdapter
            //Agarrar el data adapter y meterlo en un array, y crear otro array auxiliar
            //Con un if, comparar los arrays, si el array que viene de la base de datos y el auxiliar son iguales,
            //no hacer nada, pero si no son iguales:
            //Con un for each, recorrer los valores del array y cargarlos en panelChats

            Panel chat = new Panel();
            chat.Height = 73;
            chat.Width = 800;
            panelChats.Controls.Add(chat);
            chat.Dock = DockStyle.Top;


            RichTextBox nomprof = new RichTextBox();
            nomprof.BackColor = Color.FromArgb(143,131,131);
            nomprof.ForeColor = Color.Black;
            nomprof.Text = "nooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooooo";

            chat.Controls.Add(nomprof);
            nomprof.Location = new Point(60, 7);


        }

        private void MenuChatAl_Load(object sender, EventArgs e)
        {

        }
    }
}
