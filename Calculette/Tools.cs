using System;
using Calculette.Calcul;
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


        public static OPERATION ConvertOperation(string inOperation)
        {
            if (inOperation == System.String.Empty)
            {
                return OPERATION.DEFAULT;
            }

            switch (inOperation)
            {
                case "+":
                    return OPERATION.ADD;

                case "-":
                    return OPERATION.SOUS;
                case "/":
                    return OPERATION.DIV;
                case "*":
                    return OPERATION.MULT;
                case "log":
                    return OPERATION.LOG;
                case "exp":
                    return OPERATION.EXP;
                case "ln":
                    return OPERATION.LN;
                case "cos":
                    return OPERATION.COS;
                case "sin":
                    return OPERATION.SIN;
                case "tan":
                    return OPERATION.TAN;

                default:
                    return OPERATION.DEFAULT;
            }
        }
    }

}
