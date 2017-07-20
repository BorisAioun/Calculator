using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.Calcul
{
    enum OPERATION { ADD, SOUS, MULT, DIV, EXP, LOG, LN, SIN, COS, TAN, DEFAULT};

    class Main_Calcul
    {
        public Line mLine { get; set; }                  //the line which will be use to make the calcul.
        public bool mprinted { get; private set; }               //indicate if the result of a calcul should be printed in the screen

        public Main_Calcul(Line theLine)
        {
            mLine = theLine;
            mprinted = true;
        }

        public Main_Calcul()
        {
            mLine = null;
            mprinted = true;
        }


        public bool Calculate()
        {
            if(mLine == null)
            {
                return false;
            }

            mLine.Calculate();

            if(!mLine.Calculate())
            {
                return false;
            }

            if (mprinted)
            {
                Console.Write("Result of the Calcul is: " +  mLine.mResult + " \n");
            }

            return true;
        }


    }

}
