using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Inquiries
{
    class Admin : Persona
    {
                
        // Atributos
        protected int AdCI;
        protected string AdNom;
        protected string AdApe;
        protected string AdCon;

        public Admin()
        {
        }


        // Constructor completo
        public Admin(int AdCI, string AdNom, string AdApe, string AdCon) : base (AdCI, AdNom, AdApe, AdCon)
        {

            this.AdCI = AdCI;
            this.AdNom = AdNom;
            this.AdApe = AdApe;
            this.AdCon = AdCon;

        }
        //Gets y Sets
        public int adci
        {
            get { return PCI; }
            set { AdCI = value; }
        }
        public string adnom
        {
            get { return AdNom; }
            set { AdNom = value; }
        }
        public string adape
        {
            get { return AdApe; }
            set { AdApe = value; }
        }
        public string adcon
        {
            get { return AdCon; }
            set { AdCon = value; }
        }

        //////////////////////////////
        //Metodos

        public static Array ObtenerUsuariosAl()
        {
            MySqlDataAdapter usuarios = new MySqlDataAdapter();

            usuarios = ConBD.ObtTodosAl();
            DataTable a = new DataTable();

            usuarios.Fill(a);

            string[,] b = new string[a.Rows.Count,a.Rows.Count];
            
            for (int x=0; x < a.Rows.Count; x++)
            {
                for(int y=0; y < a.Columns.Count;y++)
                {
                    b[x, y] = Convert.ToString(a.Rows[x][y]);
                };
            };
            return b;
        }
    }
}

