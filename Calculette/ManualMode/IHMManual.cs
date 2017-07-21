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
            Program.DebugMessage("Création de l'IHM Manual\n");
        }

        public override bool Process()
        {
            String theReadLine = null;
            
            Console.Write("Please enter your calcul \n");
            theReadLine = Console.ReadLine();
            Console.Write("You write the following line " + theReadLine + " \n");
            if( !IHM.YorNoDialog("Do You Want to process the Calcul ?"))
            {
                return false;
            }
            

            Main_Calcul theCalcul = new Main_Calcul(CreateLine(theReadLine), ref mVarList);
            Program.DebugMessage("Process of the IHM Manual Function\n");


            return theCalcul.Calculate();
                       
        }

    }
}
