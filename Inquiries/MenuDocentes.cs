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
    public partial class MenuDocentes : Form
    {
        int v = 1;
        public MenuDocentes()
        {
            InitializeComponent();
        }

        private void MenuDocentes_Load(object sender, EventArgs e)
        {
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCerrarDoc_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
