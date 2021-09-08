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

        public static Alumno Iniciosealum(int alCI, string alCon)
        {

            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
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
                }
                    else
                    {
                        op = 0;
                    }

                

                    if (op == 1)
                    {
                    MySqlDataReader f;
                    int cedula;
                    string nombre;
                    string ape;
                    string con;
                    string grupo;
                    string nick;

                    conectar.Close();
                    conectar.Open();
                    MySqlCommand ses = new MySqlCommand("select alci,alnom,alape,alcon,algrupo,alnick from alumno where alci='" + vCI + "' ", conectar);

                    f = ses.ExecuteReader();
                    f.Read();
                    cedula = f.GetInt32("alci");
                    nombre = f.GetString("alnom");
                    ape = f.GetString("alape");
                    con = f.GetString("alcon");
                    grupo = f.GetString("algrupo");
                    nick = f.GetString("alnick");


                    Alumno sesion = new Alumno(cedula, nombre, ape, con, grupo, nick);
                    op = 0;
                    return sesion;
                    }
                    else
                    {

                    }
                }
            Alumno error = new Alumno(0, null, null, null, null, null);
            return error;


        }
        
        public static Boolean Insedoc(int dCI, string dCon)
        {
            MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= "+contrabd+";");
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
                    return true;
                }
            }
            return false;

        }
        
        //public static Boolean Consulta(string consulta, int dci)
        //{
        //    try
        //    {
        //        Alumno v = new Alumno();
        //        int cod;
        //        int z;

        //        MySqlConnection conectar = new MySqlConnection("Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= " + contrabd + ";");
        //        conectar.Open();

        //        MySqlCommand con = new MySqlCommand("insert into consulta (estado, alci, dci ) values ('realizada','"++"','" + dci + "')", conectar);
        //        con.ExecuteNonQuery();

        //        MySqlCommand lcod = new MySqlCommand("select cod from consultas where ")
                
        //        MySqlCommand txtcon = new MySqlCommand

        //    }
        //}

    }


}
