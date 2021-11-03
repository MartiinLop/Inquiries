using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Inquiries
{
    class Asignatura
    {
        protected int cod;
        protected string nom;
        protected enum ori
        {
            Desarrollo_y_soporte,
            Videojuegos,
            Desarrollo_web
        }
        private string grupo;

        public Asignatura(int cod, string nom, string grupo)
        {
            this.cod = cod;
            this.nom = nom;
            this.grupo = grupo;
        }

        public Asignatura()
        {

        }
        public int Cod
        {
            get { return cod; }
            set { cod = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Grupo
        {
            get { return grupo; }
            set { grupo = value; }
        }

        public static DataTable devolverMaterias()
        {
            ConBD a = new ConBD();
            DataTable datos = a.materias();
            return datos;
        }
        public static int cantMaterias()
        {
            ConBD a = new ConBD();
            return a.contmaterias();
        }

        public static int obtenerCodigo(string nomAsg)
        {
            return ConBD.obtAsignatura(nomAsg);
        }
    }
}
