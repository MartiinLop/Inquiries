using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Inquiries
{
    class Consulta
    {
        protected int cod;
        protected string est;
        protected string cont;
        protected string res;
        protected string fere;
        protected int alci;
        protected int dci;

        public Consulta()
        {

        }

        public Consulta(int cod, string est, string cont, string res, string fere, int alci, int dci)
        {
            this.cod = cod;
            this.est = est;
            this.cont = cont;
            this.res = res;
            this.fere = fere;
            this.alci = alci;
            this.dci = dci;
        }

        //Leer consultas
        public MySqlDataAdapter LCon()
        {
            MySqlDataAdapter cons = new MySqlDataAdapter();
            cons = ConBD.LeerConsulta();

            return cons;
            // Mandar cedula docente a ConBD y recibir todas las consultas que esten a nombre del profe
        }

        public static string LRes()
        {
            string text = ConBD.LeerRespuesta();
            return text;
        }

    }
}
