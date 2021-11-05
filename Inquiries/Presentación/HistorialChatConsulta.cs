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
    public partial class HistorialChatConsulta : Form
    {
        private string Tipo;
        private int Cod;
        public HistorialChatConsulta(string texto,string tipo,int cod)
        {
            InitializeComponent();
            rtxtHistorial.Text = texto;
            label1.Text = "Infomración de " + tipo;
            Tipo = tipo;
            Cod = cod;

        }


        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tipo == "Consulta")
            {
                Admin.ElimConsulta(Cod);
            }
            else
            {
                Admin.ElimChat(Cod);
            }

            MessageBox.Show("Se ha eliminado " + Tipo + " correctamente");
        }
    }
}
