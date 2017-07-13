using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.Calcul
{
    class Main_Calcul
    {

        private bool m_printed;

        public bool printed                     //indicate if the result of a calcul should be printed in the screen
        {
            get
            {
                return m_printed;
            }

            set
            {
                m_printed = value;
            }
        }

        public Main_Calcul()
        {
            printed = true;
        }

        public bool Calculate()
        {
            Console.Write("Result of the Calcul\n");
            return true;
        }


    }
}
