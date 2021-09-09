using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiries
{
    class Consulta
    {
        protected int cod;
        private string est;
        private string cont;
        private string res;
        private string fere;
        private int alci;
        private int dci;

        public Consulta()
        {

        }

        public Consulta(int cod, string est, string cont, string res, string fere, int alci, int dci)
        {
            this.cod = cod;
            this.est = est;
            this.cont = cont;
            this.res = res;
            this.fere = fere;
            this.alci = alci;
            this.dci = dci;
        }

        //Leer consultas
        public Consulta LCon(int dci)
        {
             // Mandar cedula docente a ConBD y recibir todas las consultas que esten a nombre del profe
        }

    }
}
