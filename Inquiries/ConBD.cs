using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
namespace Inquiries
{
    class ConBD
    {

        static int obtCI;
        static int ccod;
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
        private static string conexbd = "Server = localhost; Port = 3306; Database = inquiriesbd; Uid = root; Pwd= 26134075sql;";
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


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

            conectar.Close();
            return num;
        }

        //Cargar grupos
        public DataTable grupos()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string a = "select * from grupo";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataAdapter grupo = new MySqlDataAdapter(comando);
            DataTable datos = new DataTable();
            grupo.Fill(datos);

            conectar.Close();
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

            conectar.Close();
            return num;
        }

        //Cargar materias
        public DataTable materias()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string a = "select * from asignatura";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataAdapter grupo = new MySqlDataAdapter(comando);
            DataTable datos = new DataTable();
            grupo.Fill(datos);

            conectar.Close();
            return datos;
        }

        //Registro alumnos
        public static void regal(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick, Boolean alConexion, Boolean alEstado, byte[] img)
        {
            alConexion = false;
            alEstado = true;
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            //MemoryStream ms = new MemoryStream();
            //ImageFormat imf = img.RawFormat;
            //img.Save(ms, imf);
            //ms.ToArray();


            MySqlCommand nual = new MySqlCommand("INSERT INTO alumno (alci, alnom, alape, alcon, algrupo, alnick, alconexion, alestado, aimagen) VALUES" +
                " ('" + alCI + "','" + alNom + "','" + alApe + "','" + alCon + "'," + alGrupo + ",'" + alNick + "', " + alConexion + "," + alEstado + ", @aimagen);", conectar);
            nual.Parameters.AddWithValue("aimagen", img);
            nual.ExecuteNonQuery();
            conectar.Close();
        }

        //Seleccionar imagen alumno
        public static byte[] imgAl()
        {
            byte[] imagen = null;

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string com = "select aimagen from alumno where alci = " + obtCI + ";";
            MySqlCommand cons = new MySqlCommand(string.Format(com), conectar);

            MySqlDataReader img = cons.ExecuteReader();
            while (img.Read())
            {
                imagen = (byte[])(img["aimagen"]);
            }


            conectar.Close();
            return imagen;
        }

        //Registro docente
        public static void regdoc(int dCI, string dNom, string dApe, string dCon, int año, Boolean dConexion, Boolean dEstado, byte[] img)
        {

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand nudoc = new MySqlCommand("INSERT INTO docente (dci, dnom, dape, dcon, año, dconexion, destado, dimagen) " +
                "VALUES ('" + dCI + "','" + dNom + "','" + dApe + "','" + dCon + "','" + año + "', " + dConexion + "," + dEstado + ", @dimagen);", conectar);
            nudoc.Parameters.AddWithValue("dimagen", img);
            nudoc.ExecuteNonQuery();
            conectar.Close();
        }

        //Seleccionar imagen docente
        public static byte[] imgDoc()
        {
            byte[] imagen = null;

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string com = "select dimagen from docente where dci = " + obtCI + ";";
            MySqlCommand cons = new MySqlCommand(string.Format(com), conectar);

            MySqlDataReader img = cons.ExecuteReader();
            while (img.Read())
            {
                imagen = (byte[])(img["dimagen"]);
            }


            conectar.Close();
            return imagen;
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
        public static void Consulta(int dci, string contenido, string titulo, int codasignatura)
        {
            MySqlConnection conexion = new MySqlConnection(conexbd);
            conexion.Open();
            MySqlConnection datos = new MySqlConnection(conexbd);
            datos.Open();

            MySqlCommand con = new MySqlCommand("insert into consulta (estado, fecharealizada, titulo, alci, dci, codasignatura) values ('realizada', now(), '" + titulo + "', " + obtCI + ", " + dci + "," + codasignatura + "); ", conexion);
            con.ExecuteNonQuery();

            string obtCod = "select cod from consulta where alci = " + obtCI + " and " + "dci = " + dci + " order by cod desc limit 1;";
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
        public static void Respuesta(string codigo , string contenido)
        {
            MySqlConnection conexion = new MySqlConnection(conexbd);
            conexion.Open();

            MySqlCommand conCont = new MySqlCommand("insert into respuestaconsulta (cod, respuesta, dci) values (" + codigo + ", '" + contenido + "',"+obtCI+");", conexion);

            conCont.ExecuteNonQuery();

            conexion.Close();

        }

        //Obtener consultas
        public static MySqlDataAdapter obtConsultas() {

            int comparar = 0;
            MySqlConnection conectar2 = new MySqlConnection(conexbd);
            conectar2.Open();

            string prueba = "select alci from alumno where alci = " + obtCI + "";
            MySqlCommand pr = new MySqlCommand(string.Format(prueba), conectar2);
            MySqlDataReader dat = pr.ExecuteReader();

            if (dat.Read())
            {
                comparar = dat.GetInt32("alci");
            }
            conectar2.Close();

            if (comparar == obtCI)
            {
                MySqlConnection conLeer = new MySqlConnection(conexbd);
                conLeer.Open();

                string consulta = "select contenidoconsulta.cod, consulta.titulo, contenidoconsulta.contenido, docente.dnom, docente.dape, estado, asignatura.anom from consulta, contenidoconsulta, docente, asignatura where contenidoconsulta.cod = consulta.cod and consulta.dci = docente.dci and asignatura.acod = consulta.codasignatura and consulta.alci = " + obtCI + ";";
                MySqlCommand cons = new MySqlCommand(string.Format(consulta), conLeer);

                MySqlDataAdapter data = new MySqlDataAdapter(cons);

                conLeer.Close();
                return data;

            }
            else
            {
                MySqlConnection conLeer = new MySqlConnection(conexbd);
                conLeer.Open();

                string consulta = "select contenidoconsulta.cod, consulta.titulo, contenidoconsulta.contenido, alumno.alnom, alumno.alape, estado, grupo.gnom from consulta, contenidoconsulta, alumno, grupo where contenidoconsulta.cod = consulta.cod and consulta.alci = alumno.alci and grupo.gcod = alumno.algrupo and consulta.dci ="+obtCI+"; ";
                MySqlCommand cons = new MySqlCommand(string.Format(consulta), conLeer);

                MySqlDataAdapter data = new MySqlDataAdapter(cons);

                conLeer.Close();
                return data;

            }


        }


        //Obtener docentes para crear consulta
        public static MySqlDataAdapter docCons(string grupo){

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string cons = "select dci, gruposdocente.dgrupo, dnom, dape, asignatura.anom from docente, gruposdocente, grupo, materiasdocente, asignatura " +
                "where docente.dci = gruposdocente.cidocente and grupo.gcod = gruposdocente.dgrupo and materiasdocente.cidocente = docente.dci and asignatura.acod = materiasdocente.dmateria and grupo.gnom = '" + grupo + "'; ";
            MySqlCommand comando = new MySqlCommand(string.Format(cons), conectar);

            MySqlDataAdapter data = new MySqlDataAdapter(comando);

            conectar.Close();
            return data;

        }

        //Obtener grupo de alumno para comparar
        public static string alGrupo()
        {
            string gru = null;
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string cons = "select alci, gnom from alumno, grupo where grupo.gcod = alumno.algrupo and alci = " + obtCI + ";";
            MySqlCommand comando = new MySqlCommand(string.Format(cons), conectar);
            MySqlDataReader data = comando.ExecuteReader();

            while (data.Read())
            {
                gru = data.GetString("gnom");
            }

            conectar.Close();
            return gru;
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
            string comando = "select dci, dnom, dape, dconexion from docente where destado = true";

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cons = new MySqlCommand(string.Format(comando), conectar);
            MySqlDataAdapter datos = new MySqlDataAdapter(cons);

            conectar.Close();
            return datos;
        }

        //Crear Chat 
        public static int CrearChat(int dci, int codMateria, string titulochat, Boolean cEstado)
        {
            int codchat = 0;
            MySqlConnection chat = new MySqlConnection(conexbd);
            chat.Open();

            MySqlCommand insChat = new MySqlCommand("INSERT INTO chat (docente, chmate, titulochat, fechacomienzo, cestado) values ('" + dci + "', '" + codMateria + "', '" + titulochat + "', now(), true); ", chat);
            insChat.ExecuteNonQuery();

            chat.Close();

            MySqlConnection codigo = new MySqlConnection(conexbd);
            codigo.Open();
            string a = "select chcod from chat order by chcod desc limit 1";
            MySqlCommand sel = new MySqlCommand(string.Format(a), codigo);
            MySqlDataReader coda = sel.ExecuteReader();

            if (coda.Read())
            {
                codchat = coda.GetInt32("chcod");
            }

            return codchat;

        }

        //insertar en participa
        public static void crearParticipa(int codChat)
        {
            MySqlConnection chat = new MySqlConnection(conexbd);
            chat.Open();

            MySqlCommand cpart = new MySqlCommand("insert into participa (alci, chcod, rol) values ('" + obtCI + "','" + codChat + "', 'iniciador');", chat);
            cpart.ExecuteNonQuery();

            chat.Close();

        }

        //Crear resumen de chat
        public static void CrearResumen(int codchat)
        {
            string test = null;
            string query = "select contenido from mensaje where chcod = '" + codchat + "';";

            MySqlConnection obtMensajes = new MySqlConnection(conexbd);
            obtMensajes.Open();

            MySqlCommand resumenChat = new MySqlCommand(string.Format(query), obtMensajes);
            MySqlDataAdapter res = new MySqlDataAdapter(resumenChat);
            DataTable datos = new DataTable();

            res.Fill(datos);

            string[] mensajes = new string[datos.Rows.Count];
            for (int i = 0; i < mensajes.Length; i++)
            {
                mensajes[i] = Convert.ToString(datos.Rows[i][0]);

            }

            test = string.Join("|||", mensajes);

            MySqlConnection resumen = new MySqlConnection(conexbd);
            resumen.Open();


            MySqlCommand resumenC = new MySqlCommand("update chat set resumen = '" + test + "' where chcod = '" + codchat + "';", resumen);
            resumenC.ExecuteNonQuery();

            obtMensajes.Close();
            resumen.Close();
        }

        //Obtener Codigo Chat
        public static int obtChatCod()
        {
            int comparar = 0;
            MySqlConnection conectar2 = new MySqlConnection(conexbd);
            conectar2.Open();

            string prueba = "select alci from alumno where alci = " + obtCI + "";
            MySqlCommand pr = new MySqlCommand(string.Format(prueba), conectar2);
            MySqlDataReader dat = pr.ExecuteReader();

            if (dat.Read())
            {
                comparar = dat.GetInt32("alci");
            }
            conectar2.Close();

            if (obtCI == comparar)
            {
                int a = 0;
                MySqlConnection conectar = new MySqlConnection(conexbd);
                conectar.Open();
                string t = "select chat.chcod from chat, participa where chat.chcod = participa.chcod && participa.alci=" + obtCI + " order by chcod desc limit 1;";
                MySqlCommand part = new MySqlCommand(string.Format(t), conectar);
                MySqlDataReader cod = part.ExecuteReader();
                while (cod.Read())
                {
                    a = cod.GetInt32("chcod");
                }
                conectar.Close();
                ccod = a;

                return a;

            }
            else
            {
                int a = 0;
                MySqlConnection conectar = new MySqlConnection(conexbd);
                conectar.Open();
                string t = "select chcod from chat where docente=" + obtCI + " order by chcod desc limit 1;";
                MySqlCommand part = new MySqlCommand(string.Format(t), conectar);
                MySqlDataReader cod = part.ExecuteReader();
                while (cod.Read())
                {
                    a = cod.GetInt32("chcod");
                }
                conectar.Close();

                ccod = a;
                return a;

            }

        }

        //Obtener codigos chat para docente
        public static MySqlDataAdapter ObtenerCodigosChatDoc()
        {
            string comando = "select chat.chcod, cestado from chat, participa where chat.chcod = participa.chcod and chat.docente='" + obtCI + "' and chat.cestado = 1;";

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cons = new MySqlCommand(string.Format(comando), conectar);
            MySqlDataAdapter datos = new MySqlDataAdapter(cons);

            conectar.Close();
            return datos;

        }

        //Obtener codigos chat para alumno
        public static MySqlDataAdapter ObtenerCodigosChatAl()
        {
            string comando = "select chat.chcod, cestado from chat, participa where chat.chcod = participa.chcod and participa.rol = 'iniciador' and chat.cestado = 1;";

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cons = new MySqlCommand(string.Format(comando), conectar);
            MySqlDataAdapter datos = new MySqlDataAdapter(cons);

            conectar.Close();
            return datos;

        }
        
        //Obtener grupo alumno
        public static string ObtGrupoAl()
        {
            string comando = "select gnom from grupo, alumno where grupo.gcod = alumno.algrupo && alumno.alci = " + obtCI + ";";
            string grupo = null;

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cons = new MySqlCommand(string.Format(comando), conectar);
            MySqlDataReader g = cons.ExecuteReader();
            while (g.Read())
            {
                grupo = g.GetString("gnom");
            }
            conectar.Close();
            return grupo;

        }

        //Revisar si alumno ha creado chats
        public static bool checkMatGru()
        {
            string res = null;
            string f = "select gnom, chat.chcod from grupo, chat, alumno, participa where chat.chcod = participa.chcod && " + obtCI + " = participa.alci && '" + ObtGrupoAl() + "' = grupo.gnom && chat.cestado = 1 group by gnom;";
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cons = new MySqlCommand(string.Format(f), conectar);
            MySqlDataReader a = cons.ExecuteReader();
            while (a.Read())
            {
                res = a.GetString("chcod");
            }

            Console.WriteLine(res);
            if (res == null)
            {
                return true;
            }
            else
            {
                return false;
            }
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
        public static void CrearMensaje(string texto)
        {
            
            MySqlConnection conectar3 = new MySqlConnection(conexbd);
            conectar3.Open();

            MySqlCommand mens = new MySqlCommand("INSERT INTO mensaje (chcod, emisor, contenido, fecharealizado) values (" + obtChatCod() + ",'" + obtCI + "','" + texto + "', now());",conectar3);
            mens.ExecuteNonQuery();
            conectar3.Close();

        }

        //Ver usuarios(alumnos) de chat
        public static DataTable aChatConectados(string cod) 
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string a = "select alnom, alape from alumno, chat, participa where alumno.alci= participa.alci and participa.chcod = chat.chcod and chat.cestado = 1 and chat.chcod = "+cod+";";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataAdapter grupo = new MySqlDataAdapter(comando);
            DataTable usuarios = new DataTable();
            grupo.Fill(usuarios);

            conectar.Close();
            return usuarios;
        }

        //Ver usuarios(docentes) de chat
        public static DataTable dChatConectados(string cod)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string a = "select dnom, dape from docente, chat where docente.dci = chat.docente and chat.cestado = 1 and chat.chcod = " + cod + "; ";
            MySqlCommand comando = new MySqlCommand(string.Format(a), conectar);
            MySqlDataAdapter grupo = new MySqlDataAdapter(comando);
            DataTable usuarios = new DataTable();
            grupo.Fill(usuarios);

            conectar.Close();
            return usuarios;
        }

        //Leer Mensaje
        public static string LeerMensaje(int cod)
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

            if (cod != 0)
            {
                if (obtCI == comparar)
                {

                    MySqlConnection conectar = new MySqlConnection(conexbd);
                    conectar.Open();
                    comando = "select chat.docente, mensaje.contenido,participa.alci from chat, mensaje, participa " +
                      "where participa.chcod = chat.chcod && participa.alci = " + obtCI + " order by mensaje.mcod desc limit 1;";
                    MySqlCommand buscar = new MySqlCommand(string.Format(comando), conectar);


                    MySqlConnection conectar4 = new MySqlConnection(conexbd);
                    conectar4.Open();
                    string b = "select emisor from mensaje order by mcod desc limit 1";
                    MySqlCommand nusuario = new MySqlCommand(string.Format(b), conectar4);


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
                         "where participa.chcod = chat.chcod && chat.docente = " + obtCI + " order by mensaje.mcod desc limit 1;";
                    MySqlCommand buscar = new MySqlCommand(string.Format(comando), conectar);

                    MySqlDataReader lnomusu = nusuario.ExecuteReader();
                    MySqlDataReader data = buscar.ExecuteReader();

                    if (lnomusu.Read()) textovich = lnomusu.GetString("emisor");
                    if (data.Read()) textovich = textovich + ": " + data.GetString("contenido");
                    conectar4.Close();
                    conectar.Close();
                }
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

            conectar.Close();

            if (b == obtCI)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        //Obtener CI de Alumno
        public static string obtCIAl(int codChat)
        {
            string a = null;

            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();
            string t = "select alci from participa where chcod = '" + codChat + "';";
            MySqlCommand codAs = new MySqlCommand(string.Format(t), conectar);
            MySqlDataReader cod = codAs.ExecuteReader();
            while (cod.Read())
            {
                a = cod.GetString("alci");
            }
            conectar.Close();


            return a;
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

                conectar.Close();
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
                conectar.Close();
                return datotef;
            }

        }

        //Modificar perfil alumno
        public static void ModPerfilAl(string nombre, string apodo, string contraseña, byte[] img)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand mod = new MySqlCommand("update alumno set alnom = '"+nombre+"', alnick = '"+apodo+"', alcon = '"+contraseña+"', aimagen = '" + img + "' where alci = "+obtCI+";",conectar);
            mod.ExecuteNonQuery();
            conectar.Close();

        }

        //Modificar perfil docente
        public static void ModPerfilDoc(string nombre, string contraseña, byte[] img)
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand mod = new MySqlCommand("update docente set dnom = '" + nombre + "', dcon = '" + contraseña + "', dimagen = '"+img+"' where dci = " + obtCI + "; ",conectar);
            mod.ExecuteNonQuery();
            conectar.Close();
        }

        //Eliminar perfil docente
        public static void EliminarDoc()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand elim = new MySqlCommand("update docente set destado = false where dci = "+obtCI+";", conectar);
            elim.ExecuteNonQuery();
            conectar.Close();

        }

        //Eliminar perfil alumno
        public static void EliminarAl()
        {
            MySqlConnection conectar = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand elim = new MySqlCommand("update alumno set alestado = false where alci = " + obtCI + ";", conectar);
            elim.ExecuteNonQuery();
            conectar.Close();
        }

        //Obtener todos los usuarios
        public static MySqlDataAdapter ObtTodosUsu()
        {
            string comando1 = "select alci, algrupo from alumno";
            string comando2 = "select * from docente";
            MySqlConnection conectar = new MySqlConnection(conexbd);
            MySqlConnection conectar1 = new MySqlConnection(conexbd);
            conectar.Open();

            MySqlCommand cons = new MySqlCommand(comando1, conectar);
            MySqlDataAdapter datos1 = new MySqlDataAdapter(cons);
            conectar.Close();

            conectar1.Open();
            MySqlCommand cons1 = new MySqlCommand(comando2, conectar1);
            MySqlDataAdapter datos2 = new MySqlDataAdapter(cons1);
            conectar1.Close();

            return datos1;
           
        }
    }

}
