using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Inquiries
{


    class Alumno : Persona
    {

        
        // atributos
        protected int alCI;
        protected string alNom;
        protected string alApe;
        protected string alCon;
        protected string alGrupo;
        protected string alNick;

        //constructor completo
        public Alumno(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick): base(alCI, alNom, alApe, alCon)
        {

            this.alCI = alCI;
            this.alNom = alNom;
            this.alNom = alApe;
            this.alCon = alCon;
            this.alNom = alGrupo;
            this.alNom = alNick;

        }
        // Gets y Sets
        public int alci
        {
            get { return alCI; }
            set { alCI = value; }
        }
        public string alnom
        {
            get { return alNom; }
            set { alNom = value; }
        }
        public string alape
        {
            get { return alApe; }
            set { alApe = value; }
        }
        public string alcon
        {
            get { return alCon; }
            set { alCon = value; }
        }
        public string algrupo
        {
            get { return alGrupo; }
            set { alGrupo = value; }
        }
        public string alnickname
        {
            get { return alNick; }
            set { alNick = value; }
        }

        public static Boolean RCon(string a)
        {

        }

        ////////////////////////////
    }
}
