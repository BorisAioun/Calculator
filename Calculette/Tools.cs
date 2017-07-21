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


    class ListVar
    {
        public LinkedList<Variable> mVarList { get; private set; }

        public ListVar()
        {
            mVarList = new LinkedList<Variable>();
        }


        //Search in the List of variable if a var called "inVarName" Exist
        public bool VarExist(string inVarName)
        {
            foreach(Variable theElement in mVarList) 
            {
                if (theElement.mName == inVarName)
                {
                    return true;
                }
            }

            return false;
        }

        public bool AddElement(Variable inVariable)
        {
            if (!VarExist(inVariable.mName))
            {
                mVarList.AddFirst(inVariable);
                return true;
            }
            return false;
        }

        public bool DeleteElement(String inVarName)
        {
            Variable theVariable;
            foreach(Variable theElement in mVarList)
            {
                if (theElement.mName == inVarName)
                {
                    theVariable = new Variable(inVarName, theElement.mValue);
                    mVarList.Remove(theVariable);
                    return true;
                }
            }

            return false;
        }

        public Variable ReturnElement(String inVarName)
        {
            foreach(Variable theElement in mVarList)
            {
                if (theElement.mName == inVarName)
                {
                    return theElement;
                }
            }
            return null;
        }

        public bool ModifyVariable(String inVarName, double inNewValue)
        {
            foreach(Variable theElement in mVarList)
            {
                if (theElement.mName == inVarName)
                {
                    theElement.mValue = inNewValue;
                    return true;
                }
            }
            return false;
        }

    }


}
