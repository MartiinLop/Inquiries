﻿using System;
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
    }
}
