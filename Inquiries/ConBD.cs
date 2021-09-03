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

            MySqlCommand nual = new MySqlCommand("insert into alumno (alci, alnom, alape, alcon, algrupo, alnick) values ('"+Convert.ToString(alCI)+"','"+alNom+"','"+alApe+"','"+alCon+"','"+alGrupo+ "','"+alNick+"');'", conectar);
            nual.ExecuteNonQuery();
        }
    }

}
