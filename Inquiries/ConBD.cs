using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace Inquiries
{
    class ConBD
    {

        static int obtCI;
        //Contraseña a base de datos
        private static string contrabd = "26134075sql";

        public static void regal(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick)
        {
            Alumno bd = new Alumno(alCI, alNom, alApe, alCon, alGrupo, alNick);

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= " + contrabd + ";");
            conectar.Open();

            MySqlCommand nual = new MySqlCommand("INSERT INTO alumno (alci, alnom, alape, alcon, algrupo, alnick) VALUES ('" + alCI + "','" + alNom + "','" + alApe + "','" + alCon + "','" + alGrupo + "','" + alNick + "');", conectar);
            nual.ExecuteNonQuery();
            conectar.Close();
        }

        public static void regdoc(int dCI, string dNom, string dApe, string dCon, int año)
        {

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= " + contrabd + ";");
            conectar.Open();

            MySqlCommand nudoc = new MySqlCommand("INSERT INTO docente (dci, dnom, dape, dcon, año) VALUES ('" + dCI + "','" + dNom + "','" + dApe + "','" + dCon + "','" + año + "');", conectar);
            nudoc.ExecuteNonQuery();
            conectar.Close();
        }

        public static Boolean Inseal(int alCI, string alCon)
        {
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= " + contrabd + ";");
            conectar.Open();
            MySqlDataReader com;
            int op;
            int vCI;
            String vCon;
            string a = "select alci,alcon from alumno";
            MySqlCommand seleccionar = new MySqlCommand(string.Format(a), conectar);

            com = seleccionar.ExecuteReader();

            while (com.Read())
            {
                vCI = com.GetInt32("alci");
                vCon = com.GetString("alcon");
                if (vCI == alCI && vCon == alCon)
                {
                    op = 1;
                    obtCI = vCI;
                }
                else
                {
                    op = 0;
                }



                if (op == 1)
                {
                    op = 0;
                    conectar.Close();
                    return true;
                }
            }
            conectar.Close();
            return false;

        }

        public static Boolean Insedoc(int dCI, string dCon)
        {
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= " + contrabd + ";");
            conectar.Open();
            MySqlDataReader com;
            int op;
            int vCI;
            String vCon;
            string a = "select dci,dcon from docente";
            MySqlCommand seleccionar = new MySqlCommand(string.Format(a), conectar);

            com = seleccionar.ExecuteReader();

            while (com.Read())
            {
                vCI = com.GetInt32("dci");
                vCon = com.GetString("dcon");
                if (vCI == dCI && vCon == dCon)
                {
                    op = 1;
                }
                else
                {
                    op = 0;
                }

                if (op == 1)
                {
                    op = 0;
                    conectar.Close();
                    return true;
                }
            }
            conectar.Close();
            return false;

        }

        public static void Consulta(int dci, string contenido)
        {             
            MySqlConnection conexion = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
            conexion.Open();
            MySqlConnection datos = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= " + contrabd + ";");
            datos.Open();

            MySqlCommand con = new MySqlCommand("insert into consulta (estado, fecharealizada, alci, dci) values ('realizada', now(), " + obtCI + ", " + dci + "); ", conexion);
            con.ExecuteNonQuery();

            string obtCod = "select cod from consulta where alci = " + obtCI + " && " + "dci = " + dci + " order by cod desc limit 1;";
            MySqlCommand obtenCod = new MySqlCommand(string.Format(obtCod), datos);
            MySqlDataReader cod = obtenCod.ExecuteReader();

            int codigo = 0;

            if (cod.Read())
            {
                codigo = cod.GetInt32("cod");
            }

            MySqlCommand conCont = new MySqlCommand("insert into contenidoconsulta (cod, contenido) values ('" + codigo + "', '" + contenido + "');", conexion);

            conCont.ExecuteNonQuery();

            conexion.Close();

        }
    }


}
