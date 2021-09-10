﻿using System;
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

        //Contraseña a base de datos
        private static string conexbd = "Server = 192.168.0.168; Port = 3306; Database = inquiriesbd; Uid = ruut; Pwd= 1234;";

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

            MySqlCommand cerrar = new MySqlCommand("update table docente modify docestado = false where alci = " + obtCI + "");
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


    }


}
