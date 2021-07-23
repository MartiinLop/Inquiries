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
    public partial class Registro : Form
    {

        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void RegAl_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroAlumnos f1 = new RegistroAlumnos();
            f1.ShowDialog();
            this.Show();
        }

        private void RegDoc_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistroDocentes f1 = new RegistroDocentes();
            f1.ShowDialog();
            this.Show();
        }
    }
}
