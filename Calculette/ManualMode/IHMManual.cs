using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculette.Calcul;

/*
   iteration 1:
   the Calculator in Manual mode can read line "X o Y"
   with X and Y are real (2,2 or 2.2 are supported by the calculator)
   o is an operation ( + - * / or %)
   We must have a space (and only one) between an operande and the operator
     
     
     
*/




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
            string theReadLine = "2,5 + 33";
            Console.Write("Process of the IHM Manual Function\n");
            theCalcul.Calculate();


            return true;
        }

        public Line CreateLine(string inLine)
        {
            Line theLine;

            string[] expression = inLine.Split(' ');

            if(    (expression[0] != System.String.Empty) 
                && (expression[2] !=System.String.Empty)
                && (ConvertOperation(expression[1]) != OPERATION.DEFAULT))
            {
                theLine = new Line(Convert.ToDouble(expression[0]),
                                   Convert.ToDouble(expression[2]),
                                   ConvertOperation(expression[1]));
                                   
            }
            else
            {
                return null;
            }
            

            return theLine;
        }


        public OPERATION ConvertOperation(string inOperation)
        {
            switch(inOperation)
            {
                case "+":
                    return OPERATION.ADD;

                case "-":
                    return OPERATION.SOUS;
                case "/":
                    return OPERATION.DIV;
                case "*":
                    return OPERATION.MULT;
                default:
                    return OPERATION.DEFAULT;
            }
        }
    }
}
