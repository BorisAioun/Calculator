using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette
{
    class Tools
    {
        public static double StringToDouble(String inString)
        {
           
            if (inString.IndexOf('.') == -1)
            {
                return Convert.ToDouble(inString);
            }

            return Convert.ToDouble(inString.Replace(".", ","));

        }
    }
}
