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

        
        // Atributos
        protected int alCI;
        protected string alNom;
        protected string alApe;
        protected string alCon;
        protected string alGrupo;
        protected string alNick;
        protected Boolean alEstado;
        protected Boolean Conectado;

        //Constructor completo
        public Alumno(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick, Boolean alEstado, Boolean Conectado): base(alCI, alNom, alApe, alCon)
        {

            this.alCI = alCI;
            this.alNom = alNom;
            this.alNom = alApe;
            this.alCon = alCon;
            this.alNom = alGrupo;
            this.alNom = alNick;
            this.alEstado = alEstado;
            this.Conectado = Conectado;

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
        public Boolean alestado
        {
            get { return alEstado; }
            set { alEstado = value; }
        }
        public Boolean conectado
        {
            get { return conectado; }
            set { conectado = value; }
        }

        //Metodos
        public void CSesion()
        {
            ConBD.CerrarSesionAl();
        }

        ////////////////////////////
    }
}
