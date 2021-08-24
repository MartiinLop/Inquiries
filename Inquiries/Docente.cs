using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiries
{
    class Docente : Persona
    {
        // atributos
        protected int DocCI;
        protected string DocNom;
        protected string DocApe;
        protected string DocCon;
        protected string DocGrupo;
        protected string DocMateria;

        // constructor completo
        public Docente(int DocCI, string DocNom, string DocApe, string DocCon, string DocGrupo, string DocMateria) : base(DocCI, DocNom, DocApe, DocCon)
        {

            this.DocCI = DocCI;
            this.DocNom = DocNom;
            this.DocApe = DocApe;
            this.DocCon = DocCon;
            this.DocGrupo = DocGrupo;
            this.DocMateria = DocMateria;

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
        //////////////////////////////
    }
}
