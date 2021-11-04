using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inquiries.Properties;
using Inquiries;

namespace TemplateParteAdmin
{
    public partial class MiniUsuExpandir : Form
    {
        private  string nombre;
        private  string apellido;
        private string cedula;
        private  string grupo;
        private  string Tipo;
        private  string Contra;

        public MiniUsuExpandir(string nom,string ape,string ci,string grup,string tipo, string contra)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            lblNA.Text = nom+" "+ape;
            lblTipoGrup.Text = tipo+" - "+grup;
            pictureBox1.Image = Resources.imagen_pdef;


            nombre = nom;
            apellido = ape;
            cedula = ci;
            grupo = grup;
            Tipo = tipo;
            Contra = contra;
        }


        private void Clickeado(object sender, EventArgs e)
        {
            VerUsuAdmin a = new VerUsuAdmin(nombre, apellido, cedula, grupo, Tipo, Contra);
            a.ShowDialog();
        }

        private void MiniUsuExpandir_Load(object sender, EventArgs e)
        {

        }
    }
}
