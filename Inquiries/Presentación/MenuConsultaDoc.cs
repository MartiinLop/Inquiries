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
    public partial class MenuConsultaDoc : Form
    {
        protected static string[,] comparar = new string[0, 0];
        protected static Boolean mensaje = false;
        public MenuConsultaDoc()
        {
            InitializeComponent();
            comparar = new string[0, 0];
            mensaje = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[,] infoConsulta = (string[,])Chat.obtCodigosChatAl();


            if (infoConsulta.Length != comparar.Length)
            {
                for (int x = 0; x < infoConsulta.GetLength(0); x++)
                {

                    if (Convert.ToBoolean(infoConsulta[x, 1]) == true)
                    {

                        Panel consulta = new Panel();
                        consulta.Height = 73;
                        consulta.Width = 500;
                        panelConsultas.Controls.Add(consulta);
                        consulta.Dock = DockStyle.Top;


                        Label codConsulta = new Label();
                        codConsulta.Visible = false;
                        codConsulta.Text = Convert.ToString(infoConsulta[x, 0]);
                        panelConsultas.Controls.Add(codConsulta);

                        RichTextBox alCI = new RichTextBox();
                        alCI.Visible = true;
                        alCI.BackColor = Color.FromArgb(143, 131, 131);
                        alCI.ForeColor = Color.Black;
                        alCI.Text = Convert.ToString(infoConsulta[x, 2]);
                        alCI.Width = 500;
                        consulta.Controls.Add(alCI);


                        alCI.Click += delegate (object enviar, EventArgs f)
                        {

                            invConDoc(Convert.ToInt32(alCI.Text), Convert.ToInt32(codConsulta.Text));

                        };

                    }
                    else
                    {
                        if (mensaje == false)
                        {
                            mensaje = true;
                            MessageBox.Show("xd");
                        }
                    }
                    comparar = infoConsulta;
                }
            }

        }

        public void invConDoc(int alci, int cod)
        {
            this.Hide();
            AdminConsultaAl f = new AdminConsultaAl(alci, cod);
            f.ShowDialog();
            this.Show();
        }
    }
}
