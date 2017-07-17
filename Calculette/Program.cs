#define DEBUG

using Calculette.ManualMode;
using Calculette.ScriptedMode;
using Calculette.Calcul;
using System;
using System.IO;
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
            if (args.Length != 0 && File.Exists(args[0]) )
            {
                theFilePath = args[0];
                isManualMode = false;
            }
            else
            {
                int theIt = 10;

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
                    //theFilePath = "C:/Users/bobo/Desktop/TutoC#/Calculette/Calculette_Test.txt";

                    while (!File.Exists(theFilePath) && (theIt != 0 ))
                    {
                        Console.Write("the file " + theFilePath + " does not exist \n");
                        Console.Write("Please re enter the Path of you script file\n");
                        theFilePath = Console.ReadLine();
                        theIt--;
                    }

                    if( File.Exists(theFilePath) )
                    {
                        Console.Write("You enter the following Path: " + theFilePath + " \n");
                    }
                    else
                    {
                        Console.Write("the file " + theFilePath +" does not exist \n");
                        goto End;
                    }

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

            End:
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

        public OPERATION ConvertOperation(string inOperation)
        {
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
                default:
                    return OPERATION.DEFAULT;
            }
        }

        public Line CreateLine(string inLine)
        {
            Line theLine;

            string[] expression = inLine.Split(' ');

            //Rajouter un test de sécurité sur le découpage de la chaine car quand pas d'espace ça bug

            if ((expression[0] != System.String.Empty)
                && (expression[2] != System.String.Empty)
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
    }








}


