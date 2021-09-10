using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inquiries
{
    public partial class MenuAlumnos : Form
    {
        int v = 1;
        public MenuAlumnos()
        {
            InitializeComponent();
            panel3.Hide();
        }

        private void btnGrupos_Click(object sender, EventArgs e)
        {

            if (v == 1)
            {
                panel3.Show();
            }
            if (v == 0)
            {
                panel3.Hide();
            }

            if (v == 1)
            {
                v = 0;
            }
            else
            {
                v = 1;
            }


        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuConsultaAl f1 = new MenuConsultaAl();
            f1.ShowDialog();
        }

        private void btnCerrarAl_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnChatAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            MenuChatAl f1 = new MenuChatAl();
            f1.ShowDialog();
        }
    }
}
