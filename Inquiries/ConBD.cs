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
        //Contraseña a base de datos
        private static string contrabd = "1234";



        public static void regal(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick)
        {
            Alumno bd = new Alumno(alCI, alNom, alApe, alCon, alGrupo, alNick);

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
            conectar.Open();

            MySqlCommand nual = new MySqlCommand("INSERT INTO alumno (alci, alnom, alape, alcon, algrupo, alnick) VALUES ('"+alCI+"','"+alNom+"','"+alApe+"','"+alCon+"','"+alGrupo+ "','"+alNick+"');", conectar);
            nual.ExecuteNonQuery();
            conectar.Close();
        }

        public static void regdoc(int dCI,string dNom ,string dApe,string dCon,int año)
        {

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
            conectar.Open();

            MySqlCommand nudoc = new MySqlCommand("INSERT INTO docente (dci, dnom, dape, dcon, año) VALUES ('" + dCI + "','" + dNom + "','" + dApe + "','" + dCon + "','" + año + "');", conectar);
            nudoc.ExecuteNonQuery();
            conectar.Close();
        }

        public static Boolean Inseal(int alCI, string alCon)
        {
            string usu;
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
            conectar.Open();
            MySqlDataReader com;
            int op;
            int vCI;
            String vCon;
            //MySqlCommand inse = new MySqlCommand
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
                        usu = alCI;
                    }
                    else
                    {
                        op = 0;
                    }

                    if (op == 1)
                    {
                        op = 0;
                        return true;
                    }
                }
            return false;

            }
        
        public static Boolean Insedoc(int dCI, string dCon)
        {
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
            conectar.Open();
            MySqlDataReader com;
            int op;
            int vCI;
            String vCon;
            //MySqlCommand inse = new MySqlCommand
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
                    return true;
                }
            }
            return false;

        }
        
        public static Boolean Consulta()
        {
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
            conectar.Open();
            
            MySqlCommand con = new MySqlCommand("insert into consulta values (estado, )")
        }
    }


}
