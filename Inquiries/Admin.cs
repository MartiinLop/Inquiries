using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiries
{
    class Admin : Persona
    {
                
        // Atributos
        protected int AdCI;
        protected string AdNom;
        protected string AdApe;
        protected string AdCon;


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
    }
}

