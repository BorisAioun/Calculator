using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculette.Calcul;

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
            Main_Calcul theCalcul = new Main_Calcul();
            Console.Write("Process of the IHM Manual Function\n");
            theCalcul.Calculate();


            return true;
        }

    }
}
