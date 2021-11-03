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

        //Obtener Consultas
        public Array obtCon()
        {
            MySqlDataAdapter cons = new MySqlDataAdapter();
            cons = ConBD.obtConsultas();
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
            
        }

        public static string LRes()
        {
            string text = ConBD.LeerRespuesta();
            return text;
        }

        //Crear consulta
        public static void CConsulta(int dci, string contenido, string titulo, int codasignatura)
        {
            ConBD.Consulta(dci, contenido, titulo, codasignatura);
        }

        //Obtener docentes para consulta

        public static Array obtDocCon(string grupo)
        {
            MySqlDataAdapter cons = new MySqlDataAdapter();
            cons = ConBD.docCons(grupo);
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
        }

        public static string gruAl()
        {
            return ConBD.alGrupo();
        }
    }
}
