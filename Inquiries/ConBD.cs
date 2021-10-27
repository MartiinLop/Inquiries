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


        //Cargar cantidad de grupos

        public int contgrupos()
        {
            int num = 0;
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string a = "select count(*) from grupo";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataReader obtnum = comando.ExecuteReader();

            if (obtnum.Read())
            {
                num = obtnum.GetInt32("count(*)");
            }

            return num;
        }

        //Cargar grupos
        public DataTable grupos()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            string a = "select * from grupo";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataAdapter grupo = new MySqlDataAdapter(comando);
            DataTable datos = new DataTable();
            grupo.Fill(datos);


            return datos;
        }
        //Cargar cantidad de materias
        public int contmaterias()
        {
            int num = 0;
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string a = "select count(*) from asignatura";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataReader obtnum = comando.ExecuteReader();

            if (obtnum.Read())
            {
                num = obtnum.GetInt32("count(*)");
            }

            return num;
        }
        //Cargar materias
        public DataTable materias()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            string a = "select * from asignatura";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataAdapter grupo = new MySqlDataAdapter(comando);
            DataTable datos = new DataTable();
            grupo.Fill(datos);


            return datos;
        }

        //Registro alumnos
        public static void regal(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick, Boolean alConexion, Boolean alEstado)
        {
            alConexion = false;
            alEstado = true;
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand nual = new MySqlCommand("INSERT INTO alumno (alci, alnom, alape, alcon, algrupo, alnick, alconexion, alestado) VALUES" +
                " ('" + alCI + "','" + alNom + "','" + alApe + "','" + alCon + "'," + alGrupo + ",'" + alNick + "', " + alConexion + "," + alEstado + ");", conectar);
            nual.ExecuteNonQuery();
            conectar.Close();
        }

        //Registro docente
        public static void regdoc(int dCI, string dNom, string dApe, string dCon, int año, Boolean dConexion, Boolean dEstado)
        {

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand nudoc = new MySqlCommand("INSERT INTO docente (dci, dnom, dape, dcon, año, dconexion, destado) VALUES ('" + dCI + "','" + dNom + "','" + dApe + "','" + dCon + "','" + año + "', " + dConexion + "," + dEstado + ");", conectar);
            nudoc.ExecuteNonQuery();
            conectar.Close();
        }

        //Inicio sesión alumno
        public static Boolean Inseal(int alCI, string alCon)
        {
            MySqlConnection conectar00 = new MySqlConnection(conexbd);
            conectar00.Open();
            Boolean comp;
            string check = "select alestado from alumno where alci = " + obtCI + ";";
            MySqlCommand chequear = new MySqlCommand(string.Format(check), conectar00);
            MySqlDataReader revisar = chequear.ExecuteReader();

            if (revisar.Read())
            {
                comp = revisar.GetBoolean("alestado");
            }


            if (comp = true) {

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
                        MySqlConnection conectar2 = new MySqlConnection(conexbd);
                        conectar2.Open();
                        MySqlCommand conex = new MySqlCommand("update alumno set alconexion = true where alci =" + obtCI + ";", conectar2);
                        conex.ExecuteNonQuery();
                        conectar.Close();
                        conectar2.Close();
                        return true;
                    }
                }
                conectar.Close();
                return false;
            }
            conectar00.Close();
            return false;
        }

        //Inicio sesión docente
        public static Boolean Insedoc(int dCI, string dCon)
        {

            MySqlConnection conectar0 = new MySqlConnection(conexbd);
            conectar0.Open();
            Boolean comp;
            string check = "select destado from docente where dci = " + obtCI + ";";
            MySqlCommand chequear = new MySqlCommand(string.Format(check), conectar0);
            MySqlDataReader revisar = chequear.ExecuteReader();

            if (revisar.Read())
            {
                comp = revisar.GetBoolean("destado");
            }


            if (comp = true)
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
                        MySqlConnection conectar2 = new MySqlConnection(conexbd);
                        conectar2.Open();
                        MySqlCommand conex = new MySqlCommand("update docente set dconexion = true where dci =" + obtCI + ";", conectar2);
                        conex.ExecuteNonQuery();
                        conectar.Close();
                        conectar2.Close();
                        return true;
                    }
                }
                conectar.Close();
                return false;
            }
            conectar0.Close();
            return false;

        }

        //Iniciar sesión administrador
        public static Boolean Insead(int adCI, string adCon)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            MySqlDataReader com;
            int op;
            int vCI;
            String vCon;
            string a = "select adci,adcon from administrador";
            MySqlCommand seleccionar = new MySqlCommand(string.Format(a), conectar);

            com = seleccionar.ExecuteReader();

            while (com.Read())
            {
                vCI = com.GetInt32("adci");
                vCon = com.GetString("adcon");
                if (vCI == adCI && vCon == adCon)
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
                    MySqlConnection conectar2 = new MySqlConnection(conexbd);
                    conectar2.Open();
                    MySqlCommand conex = new MySqlCommand("update docente set dconexion = true where dci =" + obtCI + ";", conectar2);
                    conex.ExecuteNonQuery();
                    conectar.Close();
                    conectar2.Close();
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

            MySqlCommand cerrar = new MySqlCommand("update alumno set alconexion = false where alci = " + obtCI + "", conectar);
            cerrar.ExecuteNonQuery();
            conectar.Close();
        }

        //Cerrar sesión docente
        public static void CerrarSesionDoc()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cerrar = new MySqlCommand("update docente set dconexion = false where dci = " + obtCI + "", conectar);
            cerrar.ExecuteNonQuery();
            conectar.Close();
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

        //Crear respuesta de docente
        public static void Respuesta(int alci, string contenido)
        {
            MySqlConnection conexion = new MySqlConnection(conexbd);
            conexion.Open();
            MySqlConnection datos = new MySqlConnection(conexbd);
            datos.Open();

            MySqlCommand con = new MySqlCommand("insert into consulta (estado, fecharealizada, alci, dci) values ('contestada', now(), " + alci + ", " + obtCI + "); ", conexion);
            con.ExecuteNonQuery();

            string obtCod = "select cod from consulta where dci = " + obtCI + " && " + "alci = " + alci + " order by cod desc limit 1;";
            MySqlCommand obtenCod = new MySqlCommand(string.Format(obtCod), datos);
            MySqlDataReader cod = obtenCod.ExecuteReader();

            int codigo = 0;

            if (cod.Read())
            {
                codigo = cod.GetInt32("cod");
            }

            MySqlCommand conCont = new MySqlCommand("insert into respuestaconsulta (cod, respuesta) values ('" + codigo + "', '" + contenido + "');", conexion);

            conCont.ExecuteNonQuery();

            conexion.Close();
            datos.Close();
        }

        //Leer Consulta
        public static MySqlDataAdapter LeerConsulta() {

            MySqlConnection conLeer = new MySqlConnection(conexbd);
            conLeer.Open();

            string consulta = "select contenidoconsulta.cod , contenidoconsulta.contenido, consulta.alci from contenidoconsulta inner join consulta on contenidoconsulta.cod = consulta.cod where dci = " + obtCI + ";";
            MySqlCommand cons = new MySqlCommand(string.Format(consulta), conLeer);

            MySqlDataAdapter data = new MySqlDataAdapter(cons);

            conLeer.Close();
            return data;

        }

        //Leer respuesta para el alumno
        public static string LeerRespuesta()
        {

            string comando;
            int codigo = 0;
            string textovich = null;

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            MySqlConnection conectar2 = new MySqlConnection(conexbd);
            conectar2.Open();

            string consulta = "select cod, dci from consulta where alci = " + obtCI + " order by cod desc limit 1";
            MySqlCommand codigoCons = new MySqlCommand(string.Format(consulta), conectar);
            MySqlDataReader dat = codigoCons.ExecuteReader();

            if (dat.Read())
            {

                codigo = dat.GetInt32("cod");

            }

            comando = "select respuesta from respuestaconsulta where cod = " + codigo + ";";
            MySqlCommand buscar = new MySqlCommand(string.Format(comando), conectar2);

            MySqlDataReader data = buscar.ExecuteReader();
            if (data.Read()) textovich = data.GetString("respuesta");

            conectar.Close();
            return textovich;
        }

        //Obtener docentes

        public static MySqlDataAdapter ObtDocentes()
        {
            string comando = "select dci, dnom, dape, dconexion from docente";

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cons = new MySqlCommand(string.Format(comando), conectar);
            MySqlDataAdapter datos = new MySqlDataAdapter(cons);

            conectar.Close();
            return datos;
        }

        //Crear Chat
        public static void CrearChat(int codChat, int dci, int codMateria, Boolean cEstado)
        {
            MySqlConnection chat = new MySqlConnection(conexbd);
            chat.Open();

            MySqlCommand insChat = new MySqlCommand("INSERT INTO chat (docente, chmate, fechacomienzo, cestado) values ('" + dci + "', '" + codMateria + "', now(), true); ", chat);
            insChat.ExecuteNonQuery();

            MySqlCommand cpart = new MySqlCommand("insert into participa (alci, chcod, rol) values ('" + obtCI + "','" + codChat + "', 'iniciador');", chat);
            cpart.ExecuteNonQuery();

            chat.Close();

        }
        //Obtener Codigo Chat
        public static int obtChatCod()
        {
            int a = 0;
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string t = "select chcod from chat order by chcod desc limit 1;";
            MySqlCommand part = new MySqlCommand(string.Format(t), conectar);
            MySqlDataReader cod = part.ExecuteReader();
            while (cod.Read())
            {
                a = cod.GetInt32("chcod");
            }
            conectar.Close();

            return a;

        }
        //Desactivar chat
        public static void desChat(int codChat)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand mod = new MySqlCommand("update chat set cestado = false where chcod = '" + codChat +"';", conectar);
            mod.ExecuteNonQuery();
            conectar.Close();
        }
        //Obtener asignatura
        public static int obtAsignatura(string nomAsig){
            int a = 0;

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string t = "select acod from asignatura where anom = '" + nomAsig + "';";
            MySqlCommand codAs = new MySqlCommand(string.Format(t), conectar);
            MySqlDataReader cod = codAs.ExecuteReader();
            while (cod.Read())
            {
                a = cod.GetInt32("acod");
            }
            conectar.Close();


            return a;
        }
        //Crear Mensaje
        public static void CrearMensaje(int dci, int alci, string texto)
        {
            
            // creacion de mensaje e insercion en participa
            MySqlConnection conectar3 = new MySqlConnection(conexbd);
            conectar3.Open();

            MySqlCommand mens = new MySqlCommand("INSERT INTO mensaje (chcod,emisor,contenido) values (" + obtChatCod() + ",'" + obtCI + "','" + texto + "');",conectar3);
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

                MySqlConnection conectar4 = new MySqlConnection(conexbd);
                conectar4.Open();

                string b = "select emisor from mensaje order by mcod desc limit 1";
                MySqlCommand nusuario = new MySqlCommand(string.Format(b), conectar4);

                comando = "select chat.docente, mensaje.contenido,participa.alci from chat, mensaje, participa " +
                    "where participa.chcod = chat.chcod && participa.alci = " + obtCI + " order by mensaje.mcod desc limit 1;";
                MySqlCommand buscar = new MySqlCommand(string.Format(comando), conectar);

                MySqlDataReader lnomusu = nusuario.ExecuteReader();
                MySqlDataReader data = buscar.ExecuteReader();

                if (lnomusu.Read()) textovich = lnomusu.GetString("emisor");
                if (data.Read()) textovich = textovich + ": " + data.GetString("contenido");
                conectar4.Close();
                conectar.Close();

            }
            else
            {
                MySqlConnection conectar = new MySqlConnection(conexbd);
                conectar.Open();

                MySqlConnection conectar4 = new MySqlConnection(conexbd);
                conectar4.Open();

                string b = "select emisor from mensaje order by mcod desc limit 1";
                MySqlCommand nusuario = new MySqlCommand(string.Format(b), conectar4);


                comando = "select chat.docente, mensaje.contenido,participa.alci from chat, mensaje, participa " +
                     "where participa.chcod = chat.chcod && chat.docente = "+ obtCI +" order by mensaje.mcod desc limit 1;";
                MySqlCommand buscar = new MySqlCommand(string.Format(comando), conectar);

                MySqlDataReader lnomusu = nusuario.ExecuteReader();
                MySqlDataReader data = buscar.ExecuteReader();
                
                if (lnomusu.Read()) textovich = lnomusu.GetString("emisor");
                if (data.Read()) textovich = textovich +": "+ data.GetString("contenido");
                conectar4.Close();
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
        //Leer CI emisor mensaje

        public static Boolean CIEmisor()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            string a = "select emisor from mensaje where mcod = "+lastmcod+" order by chcod desc limit 1 ";
            int b=0;
            MySqlCommand ci = new MySqlCommand(string.Format(a), conectar);
            MySqlDataReader lci = ci.ExecuteReader();

            while (lci.Read())
            {
                b = lci.GetInt32("emisor");
            }

            if (b == obtCI)
            {
                return true;
            }
            else
            {
                return false;
            }
            conectar.Close();
        }

        //Mostrar Datos
        public static string MostrarDatosPerf()
        {
            MySqlConnection conectar1 = new MySqlConnection(conexbd);
            conectar1.Open();
            int cedula = 0;

            string determinar = "select alci from alumno where alci = " + obtCI + ";";
            MySqlCommand det = new MySqlCommand(string.Format(determinar), conectar1);
            MySqlDataReader dete = det.ExecuteReader();
            while (dete.Read())
            {
                cedula = dete.GetInt32("alci");
            }
            conectar1.Close();

            if (cedula == obtCI)
            {
                string datote1 = null;
                string datote2 = null;
                string datote3 = null;
                string datotef = null;
                MySqlConnection conectar = new MySqlConnection(conexbd);
                conectar.Open();

                string mos = "select alnom, alnick, alcon from alumno where alci = " + obtCI + ";";
                MySqlCommand datos = new MySqlCommand(string.Format(mos), conectar);
                MySqlDataReader datito = datos.ExecuteReader();
                while (datito.Read()) 
                { 
                    datote1 = datito.GetString("alnom");
                    datote2 = datito.GetString("alnick"); 
                    datote3 = datito.GetString("alcon"); 
                }
                datotef = $"{datote1}|{datote2}|{datote3}";

                return datotef;
            }
            else
            {
                string datote1 = null;
                string datote2 = null;
                string datotef = null;
                MySqlConnection conectar = new MySqlConnection(conexbd);
                conectar.Open();

                string mos = "select dnom, dcon from docente where dci = " + obtCI + ";";
                MySqlCommand datos = new MySqlCommand(string.Format(mos), conectar);
                MySqlDataReader datito = datos.ExecuteReader();
                while (datito.Read()) 
                { 
                    datote1 = datito.GetString("dnom"); 
                    datote2 = datito.GetString("dcon"); 
                }
                datotef = $"{datote1}|{datote2}";
                return datotef;
            }

        }

        //Modificar perfil alumno
        public static void ModPerfilAl(string nombre, string apodo, string contraseña)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand mod = new MySqlCommand("update alumno set alnom = '"+nombre+"', alnick = '"+apodo+"', alcon = '"+contraseña+"' where alci = "+obtCI+";",conectar);
            mod.ExecuteNonQuery();
            conectar.Close();

        }

        //Modificar perfil docente
        public static void ModPerfilDoc(string nombre, string contraseña)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand mod = new MySqlCommand("update docente set dnom = '" + nombre + "', dcon = '" + contraseña + "' where dci = " + obtCI + "; ",conectar);
            mod.ExecuteNonQuery();
            conectar.Close();
        }

        //Eliminar perfil docente
        public static void EliminarDoc()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand elim = new MySqlCommand("update docente set dconexion = false && destado = false where dci = "+obtCI+";", conectar);
            elim.ExecuteNonQuery();
            conectar.Close();

        }

        //Eliminar perfil alumno
        public static void EliminarAl()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand elim = new MySqlCommand("update alumno set alconexion = false && alestado = false where alci = " + obtCI + ";", conectar);
            elim.ExecuteNonQuery();
            conectar.Close();
        }

    }

}
