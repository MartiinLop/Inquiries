using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        //Constructor vacio
        public Chat()
        {
        }

        //Constructor
        public Chat(int Codigo, int Docente, string Resumen, string Materia, string RolAlumno)
        {
            this.Codigo = Codigo;
            this.Docente = Docente;
            this.Resumen = Resumen;
            this.Materia = Materia;
            this.RolAlumno = RolAlumno;
        }

        //Gets y sets
        //
        //

        //Metodos
        public static MySqlDataAdapter VerMensaje()
        {
            MySqlDataAdapter datos = new MySqlDataAdapter();
            datos = ConBD.LeerMensaje();
            return datos;
        }
        
        public static void EnviarChat(int dci, string texto)
        {
            ConBD.CrearMensaje(dci, texto);
        }

    }
}
