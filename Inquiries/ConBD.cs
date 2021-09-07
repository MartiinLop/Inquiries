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

        public static void bd(){

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= 1234;");
            conectar.Open();

        }

        public static void regal(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick)
        {
            Alumno bd = new Alumno(alCI, alNom, alApe, alCon, alGrupo, alNick);

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= 1234;");
            conectar.Open();

            MySqlCommand nual = new MySqlCommand("INSERT INTO alumno (alci, alnom, alape, alcon, algrupo, alnick) VALUES ('"+alCI+"','"+alNom+"','"+alApe+"','"+alCon+"','"+alGrupo+ "','"+alNick+"');", conectar);
            nual.ExecuteNonQuery();
            conectar.Close();
        }

        public static void regdoc(int dCI,string dNom ,string dApe,string dCon,int año)
        {

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= 1234;");
            conectar.Open();

            MySqlCommand nudoc = new MySqlCommand("INSERT INTO docente (dci, dnom, dape, dcon, año) VALUES ('" + dCI + "','" + dNom + "','" + dApe + "','" + dCon + "','" + año + "');", conectar);
            nudoc.ExecuteNonQuery();
            conectar.Close();
        }

        public static Boolean Inseal(int alCI, string alCon)
        {
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= 1234;");
            conectar.Open();
            int e;
            int vCI;
            String vCon;
            MySqlCommand inse = new MySqlCommand("select alci,alcon from alumno where alci='"+alCI+"' and '"+alCon+"' ");
            MySqlDataReader r;
            r = inse.ExecuteReader();
            while (r.Read())
            {
                vCI = r.GetInt32("alci");
                vCon = r.GetString("alcon");
                if (vCI == alCI || vCon == alCon)
                {
                    e = 1;
                }
                else
                {
                    e = 0;
                }

                if (e == 1)
                {
                    e = 0;
                    conectar.Close();
                    return true;
                }
                else
                {
                    conectar.Close();
                    return false;
                }
            }
            return false;
            
        }
    }

}
