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
        public Array LCon()
        {
            MySqlDataAdapter cons = new MySqlDataAdapter();
            cons = ConBD.LeerConsulta();
            DataTable b = new DataTable();

            cons.Fill(b);

            string[,] a = new string[b.Rows.Count, b.Columns.Count];

            for (int x = 0; x < b.Rows.Count; x++)
            {
                for (int y = 0; y < b.Columns.Count; y++)
                {
                    a[x, y] = Convert.ToString(b.Rows[x][y]);
                }
            }

            return a;
            // Mandar cedula docente a ConBD y recibir todas las consultas que esten a nombre del profe
        }

        public static string LRes()
        {
            string text = ConBD.LeerRespuesta();
            return text;
        }

        //Crear consulta
        public static void CConsulta(int dci, string contenido, string nasignatura)
        {
            ConBD.Consulta(dci, contenido, nasignatura);
        }
    }
}
