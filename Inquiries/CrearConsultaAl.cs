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
    public partial class CrearConsultaAl : Form
    {
        public CrearConsultaAl()
        {
            InitializeComponent();
        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_RCons_Click(object sender, EventArgs e)
        {
            ConBD.Consulta(Convert.ToInt32(txtDocPrueba.Text), txtConsulta.Text);
            MessageBox.Show("Consulta Realizada Satisfactoriamente!", "Consulta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
