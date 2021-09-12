using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Inquiries
{
    class ConBD
    {

        static int obtCI;
        static string mcod;
        static string lastmcod = null;

        public ConBD()
        {
        }

        public int obtci
        {
            get { return obtCI; }
            set { obtCI = value; }
        }
        //Contraseña a base de datos
        private static string conexbd = "Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= 1234;";


        //Registro alumnos
        public static void regal(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick)
        {

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand nual = new MySqlCommand("INSERT INTO alumno (alci, alnom, alape, alcon, algrupo, alnick) VALUES ('" + alCI + "','" + alNom + "','" + alApe + "','" + alCon + "','" + alGrupo + "','" + alNick + "');", conectar);
            nual.ExecuteNonQuery();
            conectar.Close();
        }

        //Registro docente
        public static void regdoc(int dCI, string dNom, string dApe, string dCon, int año)
        {

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand nudoc = new MySqlCommand("INSERT INTO docente (dci, dnom, dape, dcon, año) VALUES ('" + dCI + "','" + dNom + "','" + dApe + "','" + dCon + "','" + año + "');", conectar);
            nudoc.ExecuteNonQuery();
            conectar.Close();
        }

        //Inicio sesión alumno
        public static Boolean Inseal(int alCI, string alCon)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
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

        //Inicio sesión docente
        public static Boolean Insedoc(int dCI, string dCon)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
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

        //Cerrar sesión alumno
        public static void CerrarSesionAl()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cerrar = new MySqlCommand("update table alumno modify alestado = false where alci = "+obtCI+"");
            cerrar.ExecuteNonQuery();
            obtCI = 0;
        }

        //Cerrar sesión docente
        public static void CerrarSesionDoc()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cerrar = new MySqlCommand("update table docente modify destado = false where dci = " + obtCI + "");
            cerrar.ExecuteNonQuery();
            obtCI = 0;
        }

        //Crear Consulta
        public static void Consulta(int dci, string contenido)
        {
            MySqlConnection conexion = new MySqlConnection(conexbd);
            conexion.Open();
            MySqlConnection datos = new MySqlConnection(conexbd);
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
            datos.Close();

        }

        //Leer Consulta
        public static MySqlDataAdapter LeerConsulta(){

            MySqlConnection conLeer = new MySqlConnection(conexbd);
            conLeer.Open();

            string consulta = "select contenidoconsulta.cod , contenidoconsulta.contenido, consulta.alci from contenidoconsulta inner join consulta on contenidoconsulta.cod = consulta.cod where dci = " + obtCI + ";";
            MySqlCommand cons = new MySqlCommand(string.Format(consulta), conLeer);

            MySqlDataAdapter data = new MySqlDataAdapter(cons);

            conLeer.Close();
            return data;

        }

        //Crear Mensaje
        public static void CrearMensaje(int dci,int alci, string texto)
        {
            
            string c = null;
            //creacion de chat
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            MySqlCommand chat = new MySqlCommand("INSERT INTO chat (docente) values ("+dci+"); ", conectar);
            chat.ExecuteNonQuery();
            conectar.Close();

            //obtencion de codigo de chat
            MySqlConnection conectar2 = new MySqlConnection(conexbd);
            conectar2.Open();
            string t = "select chcod from chat order by chcod desc limit 1;";
            MySqlCommand part = new MySqlCommand(string.Format(t), conectar2);
            MySqlDataReader cod = part.ExecuteReader();

            while (cod.Read())
            {
                c = cod.GetString("chcod");
            }
            conectar2.Close();

            // creacion de mensaje e insercion en participa
            MySqlConnection conectar3 = new MySqlConnection(conexbd);
            conectar3.Open();

            MySqlCommand cpart = new MySqlCommand("insert into participa (alci,chcod) values ('" + alci + "','" + c + "');", conectar3);
            cpart.ExecuteNonQuery();

            MySqlCommand mens = new MySqlCommand("INSERT INTO mensaje (chcod,nomemisor,contenido) values (" + c + ",'" + obtCI + "','" + texto + "');",conectar3);
            mens.ExecuteNonQuery();
            conectar3.Close();

        }
        
        //Leer Mensaje
        public static string LeerMensaje()
        {
            
            string comando;
            int comparar = 0;
            string textovich=null;

            MySqlConnection conectar2 = new MySqlConnection(conexbd);
            conectar2.Open();

            string prueba = "select alci from alumno where alci = "+obtCI+"";
            MySqlCommand pr = new MySqlCommand(string.Format(prueba), conectar2);
            MySqlDataReader dat = pr.ExecuteReader();

            if (dat.Read())
            {

                comparar = dat.GetInt32("alci");

            }
            conectar2.Close();
            if (obtCI == comparar)
            {

                MySqlConnection conectar = new MySqlConnection(conexbd);
                conectar.Open();

                comando = "select chat.docente, mensaje.contenido,participa.alci from chat, mensaje, participa " +
                    "where participa.chcod = chat.chcod && mensaje.nomemisor = participa.alci && participa.alci = " + obtCI + " order by mensaje.mcod desc limit 1;";
                MySqlCommand buscar = new MySqlCommand(string.Format(comando), conectar);

                MySqlDataReader data = buscar.ExecuteReader();
                if(data.Read()) textovich = data.GetString("contenido") ;

                conectar.Close();
            }
            else
            {
                MySqlConnection conectar = new MySqlConnection(conexbd);
                conectar.Open();

                comando = "select chat.docente, mensaje.contenido,participa.alci from chat, mensaje, participa " +
                     "where participa.chcod = chat.chcod && mensaje.nomemisor = participa.alci && chat.docente = "+ obtCI +" order by mensaje.mcod desc limit 1;";
                MySqlCommand buscar = new MySqlCommand(string.Format(comando), conectar);
                
                MySqlDataReader data = buscar.ExecuteReader();
                if (data.Read()) textovich = data.GetString("contenido");
                conectar.Close();
            }
            

            MySqlConnection conectar3 = new MySqlConnection(conexbd);
            conectar3.Open();

            string a = "select mcod from mensaje order by mcod desc limit 1";
            MySqlCommand test = new MySqlCommand(string.Format(a), conectar3);
            MySqlDataReader lcod = test.ExecuteReader();
            while (lcod.Read())
            {
                mcod = lcod.GetString("mcod");
            }

            if(lastmcod == mcod)
            {
                conectar3.Close();
                return null;
            }
            else
            {
                conectar3.Close();
                lastmcod = mcod;
                return textovich;
            }

        }

    }

}
