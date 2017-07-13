using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculette.Calcul;

namespace Calculette.ScriptedMode
{
    class IHMScripted : IHM
    {

        private string mFilePath;

        public string FilePath
        {
            get
            {
                return mFilePath;
            }

            set
            {
                mFilePath = value;
            }
        }


        public IHMScripted()
        {
            Console.Write("Création de l'IHM Scripted sans adresse");
        }

        public IHMScripted(string inFilePath)
        {
            Console.Write("Création de l'IHM Scripted avec adresse");
            FilePath = inFilePath;
        }


        public override bool Process()
        {
            Console.Write("Process of the IHM Scripted Function\n");
            Main_Calcul theCalcul = new Main_Calcul();


            //Ouverture du fichier

            //Boucle sur chaque ligne du fichier
            // Lecture de la ligne et affichage du résultat
            theCalcul.Calculate();
            //Fermeture du fichier


            return true;
        }

    }
}