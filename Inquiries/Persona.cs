using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiries
{
    class Persona
   
        {
            // atributos
            protected int PCI;
            protected string PNom;
            protected string PApe;
            protected string PCon;

            //Constructor vacio
            public Persona()
            {

            }
            // constructor completo
            public Persona(int PCI, string PNom, string PApe, string PCon)
            {

                this.PCI= PCI;
                this.PNom = PNom;
                this.PApe = PApe;
                this.PCon = PCon;

            }
            //Gets y Sets
            public int pci
            {
                get { return PCI; }
                set { PCI = value; }
            }
            public string pnom
            {
                get { return pnom; }
                set { PNom = value; }
            }
            public string pape
            {
                get { return PApe; }
                set { PApe = value; }
            }
            public string pcon
            {
                get { return PCon; }
                set { PCon = value; }
            }
        
            //Metodos
            public static string Mdatos()
            {
            string basadoendatos = ConBD.MostrarDatosPerf();
            return basadoendatos;
            }


            //////////////////////////////
        }
    }

