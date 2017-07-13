using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.ScriptedMode
{
    class IHMScripted : IHM
    {

        private string mFilePath
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
        }


        public override bool Process()
        {
            Console.Write("Process of the IHM Scripted Function\n");
            return true;
        }

    }
}