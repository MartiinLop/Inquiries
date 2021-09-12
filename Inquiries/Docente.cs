using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiries
{
    class Docente : Persona
    {
        // Atributos
        protected int DocCI;
        protected string DocNom;
        protected string DocApe;
        protected string DocCon;
        protected string DocGrupo;
        protected string DocMateria;
        protected Boolean DocEstado;
        protected Boolean Conectado;

        // Constructor completo
        public Docente(int DocCI, string DocNom, string DocApe, string DocCon, string DocGrupo, string DocMateria, Boolean DocEstado, Boolean Conectado) : base(DocCI, DocNom, DocApe, DocCon)
        {

            this.DocCI = DocCI;
            this.DocNom = DocNom;
            this.DocApe = DocApe;
            this.DocCon = DocCon;
            this.DocGrupo = DocGrupo;
            this.DocMateria = DocMateria;
            this.DocEstado = DocEstado;
            this.Conectado = Conectado;

        }

        public Docente()
        {

        }

        //Gets y Sets
        public int docci
        {
            get { return DocCI; }
            set { DocCI = value; }
        }
        public string docnom
        {
            get { return DocNom; }
            set { DocNom = value; }
        }
        public string docape
        {
            get { return DocApe; }
            set { DocApe = value; }
        }
        public string doccon
        {
            get { return DocCon; }
            set { DocCon = value; }
        }
        public string docgrupo
        {
            get { return DocGrupo; }
            set { DocGrupo = value; }
        }
        public string docmateria
        {
            get { return DocMateria; }
            set { DocMateria = value; }
        }
        public Boolean docestado
        {
            get { return DocEstado; }
            set { DocEstado = value; }
        }
        public Boolean conectado
        {
            get { return conectado; }
            set { conectado = value; }
        }

        //Metodos
        public static void CSesionDoc()
        {
            ConBD.CerrarSesionDoc();
        }

        public static void ModPerfDoc(string nombre, string contraseña)
        {
            ConBD.ModPerfilDoc(nombre, contraseña);
        }
        //////////////////////////////

        public static void ElDoc()
        {
            ConBD.EliminarDoc();
        }

    }
}
