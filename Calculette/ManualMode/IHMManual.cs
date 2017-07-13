using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.ManualMode
{
    class IHMManual : IHM
    {
        public IHMManual()
        {
            Console.Write("Création de l'IHM Manual\n");
        }

        public override bool Process()
        {
            Console.Write("Process of the IHM Manual Function\n");
            return true;
        }

    }
}
