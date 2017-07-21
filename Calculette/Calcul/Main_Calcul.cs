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
        public LinkedList<Variable> mVarList { get; private set; }

        public Main_Calcul(Line theLine,ref LinkedList<Variable> inList)
        {
            mLine = theLine;
            mprinted = true;
            mVarList = inList;
        }

        public Main_Calcul(ref LinkedList<Variable> inList)
        {
            mLine = null;
            mprinted = true;
            mVarList = inList;
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
