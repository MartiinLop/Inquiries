using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inquiries
{
    class PedBD
    {
        public static void regal(int alCI, string alNom, string alApe, string alCon, string alGrupo, string alNick)
        {
            ConBD.regal(alCI, alNom, alApe, alCon, alGrupo, alNick);
        }
    }
}
