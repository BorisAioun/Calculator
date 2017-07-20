using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.Calcul
{
    class Line
    {
        public double mResult { get; protected set; }

        public Line() { }
        
        public virtual bool Calculate()
        {
            return false;
        }
    }

    class Line2_1 : Line
    {
        public double mFirstOperande { get; private set; }
        public double mSecondOperande { get; private set; }
        public OPERATION mOperation { get; private set; }


        public Line2_1(double inFirstOperande, double inSecondOperande, OPERATION inOperation)
        {
            mFirstOperande = inFirstOperande;
            mSecondOperande = inSecondOperande;
            mOperation = inOperation;
        }

        public override bool Calculate()
        {
            switch (mOperation)
            {
                case OPERATION.ADD:
                    mResult = mFirstOperande + mSecondOperande;
                    break;
                case OPERATION.SOUS:
                    mResult = mFirstOperande - mSecondOperande;
                    break;
                case OPERATION.DIV:
                    mResult = mFirstOperande / mSecondOperande;
                    break;
                case OPERATION.MULT:
                    mResult = mFirstOperande * mSecondOperande;
                    break;
                default:
                    Console.WriteLine("this Operation should not be here");
                    return false;
            }
            return true;
        }
    }


    class Line1_0 : Line
    {
        public string mInitialLine { get; private set; }
        public double mOperande { get; private set; }
        public OPERATION mOperation { get; private set; }

        public Line1_0(string inLine)
        {
            mInitialLine = inLine;
            Convert();
        }

        private void Convert()
        {
            string[] expression = mInitialLine.Split('(');

            if (expression.Length != 2)
            {
                return;
            }

            mOperation = Tools.ConvertOperation(expression[0]);
            string[] expression2 = expression[1].Split(')');
            mOperande = Tools.StringToDouble(expression2[0]);

        }

        public override bool Calculate()
        {
            switch (mOperation)
            {
                case OPERATION.EXP:
                    mResult = System.Math.Exp(mOperande);
                    break;
                case OPERATION.LOG:

                    if (mOperande >= 0)
                    {
                        mResult = System.Math.Log10(mOperande);
                    }
                    else
                    {
                        Console.WriteLine("the log cannot take negative arguments");
                        return false;
                    }
                    break;
                case OPERATION.LN:
                    if (mOperande >= 0)
                    {
                        mResult = System.Math.Log(mOperande);
                    }
                    else
                    {
                        Console.WriteLine("the ln cannot take negative arguments");
                        return false;
                    }
                    break;
                case OPERATION.SIN:
                    mResult = System.Math.Sin(mOperande);
                    break;
                case OPERATION.COS:
                    mResult = System.Math.Cos(mOperande);
                    break;
                case OPERATION.TAN:
                    mResult = System.Math.Tan(mOperande);
                    break;
                default:
                    Console.WriteLine("this Operation should not be here");
                    return false;
            }
            return true;
        }

    }

}
