using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.Calcul
{
    class Variable
    {
        public string mName { get; private set; }

        public double mValue;

        public Variable (string inName, double inValue)
        {
            mName = inName;
            mValue = inValue;
        }
    }
}
