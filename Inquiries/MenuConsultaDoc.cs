﻿using System;
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
    public partial class MenuConsultaDoc : Form
    {
        public MenuConsultaDoc()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            MenuDocentes a = (MenuDocentes)Application.OpenForms["MenuDocentes"];
            a.Close();
            this.Dispose();
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Crear objeto vacio alumnos
            Consulta f = new Consulta();

            //Llamar al metodo para obtener consultas docente
        }
    }
}
