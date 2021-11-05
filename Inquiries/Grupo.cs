using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Inquiries
{
    class Grupo
    {
        protected int gcod;
        protected string gnom;
        protected enum gori
        {
            Desarrollo_Y_Soporte, 
            Desarrollo_Web, 
            videojuegos
        }

        public Grupo(int gcod, string gnom)
        {
            this.gcod = gcod;
            this.gnom = gnom;
        }
        public Grupo()
        {

        }
        public int Gcod
        {
            get { return gcod; }
            set { gcod = value; }
        }
        public string Gnom
        {
            get { return gnom; }
            set { gnom = value; }
        }

        public static DataTable grupo()
        {
            ConBD a = new ConBD();
            return a.grupos();
        }
        public static int cantGrupos()
        {
            ConBD a = new ConBD();
            return a.contgrupos();
        }

        public static int cantAlEnGrupo(string gcod)
        {
            return ConBD.cantidadAlGrupo(gcod);
        }

    }
}
