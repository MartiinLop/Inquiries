 using MySql.Data.MySqlClient;
using System;
using System.Data;


namespace Inquiries
{
    class Chat
    {
        //Atributos
        protected int Codigo;
        protected int Docente;
        protected string Resumen;
        protected string Materia;

        //Constructor vacio
        public Chat()
        {
        }

        //Constructor
        public Chat(int Codigo, int Docente, string Resumen, string Materia)
        {
            this.Codigo = Codigo;
            this.Docente = Docente;
            this.Resumen = Resumen;
            this.Materia = Materia;
        }

        //Gets y sets
        //
        public int codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }
        public int docente
        {
            get { return Docente; }
            set { Docente = value; }
        }
        public string resumen
        {
            get { return Resumen; }
            set { Resumen = value; }
        }
        public string materia
        {
            get { return Materia; }
            set { Materia = value; }
        }
        //

        //Metodos
        public static string RecibirMensaje(int cod)
        {
            string text = ConBD.LeerMensaje(cod);
            return text;
        }
        
        public static void EnviarMensaje(string texto)
        {
            ConBD.CrearMensaje(texto);
        }

        public static int getCIact()
        {
            ConBD a = new ConBD();
            return a.obtci;
        }

        public static Boolean EmioRec()
        {
            Boolean a = ConBD.CIEmisor();
            return a;
        }

        public static Array ObtenerDoc()
        {
            
            MySqlDataAdapter docentes = new MySqlDataAdapter();
            
            docentes = ConBD.ObtDocentes();
            DataTable b = new DataTable();

            docentes.Fill(b);

            string[,] a = new string[b.Rows.Count, b.Columns.Count];
          
            for (int x = 0; x < b.Rows.Count ; x++)
            {
                for (int y = 0; y < b.Columns.Count; y++)
                {
                        a[x, y] = Convert.ToString(b.Rows[x][y]);
                }
            }

            return a;
        }

        public static int crearChat(int dci, int codMateria, string titulochat, Boolean cEstado)
        {
            int cod;
                if (ConBD.checkMatGru())
                {
                    cod = ConBD.CrearChat(dci, codMateria, titulochat, cEstado);
                }
                else
                {
                    throw new Exception();
                }
            return cod;
        }

        public static void crearParticipa(int codChat)
        {
            ConBD.crearParticipa(codChat);
        }

        public static int obtcodChat()
        {
            return ConBD.obtChatCod(); 
        }

        public static Array obtCodigosChatDoc()
        {
            MySqlDataAdapter chats = new MySqlDataAdapter();

            chats = ConBD.ObtenerCodigosChatDoc();
            DataTable b = new DataTable();

            chats.Fill(b);

            string[,] a = new string[b.Rows.Count, b.Columns.Count];

            for (int x = 0; x < b.Rows.Count; x++)
            {
                for (int y = 0; y < b.Columns.Count; y++)
                {
                    a[x, y] = Convert.ToString(b.Rows[x][y]);
                }
                
            }

            return a;
        }

        public static Array obtCodigosChatAl()
        {
            MySqlDataAdapter chats = new MySqlDataAdapter();

            chats = ConBD.ObtenerCodigosChatAl();
            DataTable b = new DataTable();

            chats.Fill(b);

            string[,] a = new string[b.Rows.Count, b.Columns.Count];

            for (int x = 0; x < b.Rows.Count; x++)
            {
                for (int y = 0; y < b.Columns.Count; y++)
                {
                    a[x, y] = Convert.ToString(b.Rows[x][y]);
                }

            }

            return a;
        }
        public static void desactivarChat(int chcod)
        {
            ConBD.desChat(chcod);
        }

        public static string ciAlumno(int codChat)
        {
            string a = ConBD.obtCIAl(codChat);
            return a;
        }

        public static void CreRes(int codchat)
        {
            ConBD.CrearResumen(codchat);
        }

        public static Array alConectados(string cod) 
        {
                DataTable b = ConBD.aChatConectados(cod);

                string[,] a = new string[b.Rows.Count, b.Columns.Count];

                for (int x = 0; x < b.Rows.Count; x++)
                {
                    for (int y = 0; y < b.Columns.Count; y++)
                    {
                        a[x, y] = Convert.ToString(b.Rows[x][y]);
                    }

                }

                return a;
        }

        public static Array docConectados(string cod)
        {
            DataTable b = ConBD.dChatConectados(cod);

            string[,] a = new string[b.Rows.Count, b.Columns.Count];

            for (int x = 0; x < b.Rows.Count; x++)
            {
                for (int y = 0; y < b.Columns.Count; y++)
                {
                    a[x, y] = Convert.ToString(b.Rows[x][y]);
                }

            }

            return a;
        }

       
    }
}

