using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.Calcul
{
    enum OPERATION { ADD, SOUS, MULT, DIV, DEFAULT};


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
            double theResult = 0;

            if(mLine == null)
            {
                return false;
            }

            theResult = mLine.Calculate();
            if (mprinted)
            {
                Console.Write("Result of the Calcul is: " +  theResult + " \n");
            }
            return true;
        }


    }

    class Line
    {
        public double mFirstOperande {get; private set;}
        public double mSecondOperande { get; private set; }
        public OPERATION mOperation { get; private set; }

        public Line(double inFirstOperande, double inSecondOperande, OPERATION inOperation)
        {
            mFirstOperande = inFirstOperande;
            mSecondOperande = inSecondOperande;
            mOperation = inOperation;
        }

        public double Calculate()
        {
            double theResult = 0;

            switch (mOperation)
            {
                case OPERATION.ADD:
                    theResult = mFirstOperande + mSecondOperande;
                    break;
                case OPERATION.SOUS:
                    theResult = mFirstOperande - mSecondOperande;
                    break;
                case OPERATION.DIV:
                    theResult = mFirstOperande / mSecondOperande;
                    break;
                case OPERATION.MULT:
                    theResult = mFirstOperande * mSecondOperande;
                    break;
            }
            return theResult;
        }
    }
}
