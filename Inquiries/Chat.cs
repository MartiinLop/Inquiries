using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Inquiries
{
    class Chat
    {
        //Atributos
        protected int Codigo;
        protected int Docente;
        protected string Resumen;
        protected string Materia;
        protected string RolAlumno;
        protected int enviar;

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
            this.RolAlumno = RolAlumno;
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
        public static string RecibirMensaje()
        {
            string text = ConBD.LeerMensaje();
            return text;
        }
        
        public static void EnviarMensaje(int dci,int alci, string texto)
        {
            ConBD.CrearMensaje(dci, alci, texto);
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

            Console.WriteLine(Convert.ToString(b.Columns.Count), b.Rows.Count);
          
            for (int x = 0; x < b.Rows.Count ; x++)
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
