using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;




namespace Inquiries.Presentación
{
    public partial class MenuChatAl : Form
    {
        protected static string a;
        protected static string[,] comparar = new string[0, 0];
     
        protected static string[,] datosProf = (string[,])Chat.ObtenerDoc();
        protected string[] vector = new string[datosProf.GetLength(0)];
        public MenuChatAl()
        {
            InitializeComponent();
        }

        private void panelChats_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void MenuChatAl_Load(object sender, EventArgs e)
        {
         
            int b = Asignatura.cantMaterias();
            for (int i = 0; i < b; i++)
            {
                comboBox1.Items.Add(Asignatura.devolverMaterias().Rows[i]["anom"]);
            }

        }

        private void btnSalirPrincipal_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void invChatAl(object sender, EventArgs e, string c)
        {

            ChatAl a = new ChatAl(c);
            a.ShowDialog();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            
                int test = 0;
            
               if (datosProf.Length != comparar.Length)
               {
                    for (int x = 0; x < datosProf.GetLength(0); x++)
                    {
                        Chat z = new Chat();

                        Panel chat = new Panel();
                        chat.Height = 73;
                        chat.Width = 500;
                        panelChats.Controls.Add(chat);
                        chat.Dock = DockStyle.Top;
                        chat.Cursor = Cursors.Default;

                        Panel color = new Panel();
                        Label estado = new Label();

                    if (Convert.ToBoolean(datosProf[x, 3]) == true) {

                        estado.Visible = true;
                        chat.Controls.Add(estado);
                        estado.Location = new Point(370, 25);
                        estado.BackColor = Color.FromArgb(143, 131, 131);

                        color.Height = 10;
                        color.Width = 10;
                        chat.Controls.Add(color);
                        color.Location = new Point(450, 22);

                        estado.Text = "En línea";
                        color.BackColor = Color.Green;

                    }
                    else
                    {
                        estado.Visible = true;
                        chat.Controls.Add(estado);
                        estado.Location = new Point(370, 25);
                        estado.BackColor = Color.FromArgb(143, 131, 131);

                        color.Height = 10;
                        color.Width = 10;
                        chat.Controls.Add(color);
                        color.Location = new Point(450, 22);
                       
                        estado.Text = "Desconectado";
                        color.BackColor = Color.Red;
                    }


                    Label usuario = new Label();
                        usuario.Visible = false;
                        usuario.Text = Convert.ToString(datosProf[x, 0]);
                        panelChats.Controls.Add(usuario);

                        RichTextBox nomprof = new RichTextBox();
                        nomprof.BackColor = Color.FromArgb(143, 131, 131);
                        nomprof.ForeColor = Color.Black;
                        nomprof.Text = Convert.ToString(datosProf[x, 1] + " " + datosProf[x, 2]);
                        nomprof.Width = 500;
                        nomprof.Cursor = Cursors.Hand;
                        chat.Controls.Add(nomprof);



                    nomprof.Click += delegate (object enviar, EventArgs f)
                        {
                            if (comboBox1.Text == ""){

                                MessageBox.Show("Debe seleccionar materia!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }else{

                                    if (txtTitulo.Text != "") {
                                        if (estado.Text == "En línea")
                                        {

                                            Chat.crearChat(Chat.obtcodChat(), Convert.ToInt32(usuario.Text), Asignatura.obtenerCodigo(comboBox1.Text), txtTitulo.Text, true);
                                            invChatAl(enviar, f, Convert.ToString(usuario.Text));

                                        }
                                        else
                                        {
                                            MessageBox.Show("Este docente no está conectado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                    {
                                        MessageBox.Show("Debe ingresar título!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                    }
                                
                            
                           
                            
                                    
                                
                                
                            }
                        };

                    }
                    comparar = datosProf;
               }

        }
    }
}
