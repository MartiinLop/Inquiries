﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Inquiries.RJControls;

namespace Inquiries
{
    public partial class ChatAl : Form
    {
        
        
        public ChatAl(string ci)
        {
            InitializeComponent();
            txtDCI.Text = ci;
            Timer r = new Timer
            {
                Interval = 300
            };
            r.Enabled = true;
            r.Tick += new System.EventHandler(AcMen);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
            try
            {
                Chat.EnviarMensaje(Convert.ToString(txtMensaje.Text));
                txtMensaje.Text = "";
            }
            catch (Exception)
            {
                MessageBox.Show("Error al enviar mensaje", "Chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void AcMen(object source, EventArgs e)
        {
            string a = Chat.RecibirMensaje();
            if (a != null)
            {
                if (Chat.EmioRec())
                {
                    Panel mensajesEnviados = new Panel();
                    mensajesEnviados.Height = 59;
                    panel3.Controls.Add(mensajesEnviados);
                    mensajesEnviados.Dock = DockStyle.Bottom;

                    InquiriesTextBox txtE = new InquiriesTextBox();
                    txtE.BackColor = Color.FromArgb(236, 236, 236);
                    txtE.ForeColor = Color.Black;
                    txtE.BorderSize = 1;
                    txtE.Font = new Font("Roboto", 28);
                    txtE.BorderColor = Color.FromArgb(0,0,0);
                    txtE.Texts = a;
                    txtE.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    mensajesEnviados.Controls.Add(txtE);
                    txtE.Location = new Point(400, 7);



                }
                else
                {
                    Panel mensajesReceptor = new Panel();
                    mensajesReceptor.Height = 59;
                    panel3.Controls.Add(mensajesReceptor);
                    mensajesReceptor.Dock = DockStyle.Bottom;

                    InquiriesTextBox txtR = new InquiriesTextBox();
                    txtR.BackColor = Color.FromArgb(2,196,196,196);
                    txtR.BorderSize = 1;
                    txtR.Font = new Font("Roboto", 28);
                    txtR.ForeColor = Color.Black;
                    txtR.Texts = Convert.ToString(a);
                    txtR.BorderRadius = 5;
                    txtR.Texts = a;
                    txtR.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    mensajesReceptor.Controls.Add(txtR);
                    txtR.Location = new Point(69, 7);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            Chat.desactivarChat(Chat.obtcodChat());
            Chat.CreRes(Chat.obtcodChat());
            this.Dispose();
        }

        private void ChatAl_Load(object sender, EventArgs e)
        {
            txtDCI.Hide();
        }

        private void txtDCI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
