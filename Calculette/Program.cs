#define DEBUG

using Calculette.ManualMode;
using Calculette.ScriptedMode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Calculette
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean isManualMode = true;
            string theFilePath = null;

            Console.Write("Starting the Calculator\n");


            //Managing the mode of the Calculator
            if (args.Length != 0)
            {
                theFilePath = args[0];
                //Rajouter un test pour vérifier que le fichier existe
                isManualMode = false;
            }
            else
            {
                Console.Write("Would you use the calculator in manual mode ? y or n ?\n");
                ConsoleKeyInfo theKey = Console.ReadKey(true);
                if(theKey.Key == ConsoleKey.Y)
                {
                    Console.Write("You chose the Manual Mode\n");
                }
                else if(theKey.Key == ConsoleKey.N)
                {
                    Console.Write("You chose the Scripted Mode\n");
                    isManualMode = false;
                    Console.Write("Please enter the Path of you script file\n");
                    theFilePath = Console.ReadLine();
                    Console.Write("You enter the following Path: %s \n", theFilePath);
                }

            }

            IHM theIHM;
            //Launching the process for the mode which have been selected
            if(isManualMode)
            {
                theIHM = new IHMManual();
            }
            else
            {
                theIHM = new IHMScripted(theFilePath);
            }

            if(theIHM.Process())
            {
                DebugMessage("Tout s'est bien déroulé\n");
            }
            else
            {
                DebugMessage("Houston on a eu un problème\n");
            }

            Console.Write("Closing the Calculator\n");
            Console.Read();
        }

        public static void DebugMessage(string inString)
        {
#if (DEBUG)
            Console.Write(inString);
#endif
        }

    }


    class IHM
    {
        public IHM()
        {
        }

        public static bool YorNoDialog(string inMessage)
        {
            Console.Write(inMessage + " y or n ?\n");
            ConsoleKeyInfo theKey = Console.ReadKey(true);
            if (theKey.Key == ConsoleKey.Y)
            {
                return true;
            }
            else if (theKey.Key == ConsoleKey.N)
            {
                return false;
            }
            return false;
        }


        public virtual bool Process()
        {
            Program.DebugMessage("Process classe IHM\n");
            return true;
        }
    }








}


