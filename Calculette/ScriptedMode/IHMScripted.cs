using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Calculette.Calcul;

namespace Calculette.ScriptedMode
{
    class IHMScripted : IHM
    {
        public string mFilePath { get; private set; }

        public IHMScripted()
        {
            Program.DebugMessage("Création de l'IHM Scripted sans adresse\n");
        }

        public IHMScripted(string inFilePath)
        {
            Program.DebugMessage("Création de l'IHM Scripted avec adresse\n");
            mFilePath = inFilePath;
        }


        public override bool Process()
        {
            string theCurrentLine = null;

            Program.DebugMessage("Process of the IHM Scripted Function\n");
            Main_Calcul theCalcul = new Main_Calcul();

            //Ouverture du fichier
            StreamReader sr = new StreamReader(mFilePath);

            theCurrentLine = sr.ReadLine();

            //Boucle sur chaque ligne du fichier
            while (theCurrentLine != null)
            {
                theCalcul.mLine = CreateLine(theCurrentLine);
                theCalcul.Calculate();
                theCurrentLine = sr.ReadLine();
            }

            //Fermeture du fichier
            sr.Close();


            return true;
        }

    }
}