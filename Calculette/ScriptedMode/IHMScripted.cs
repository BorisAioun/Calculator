using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.ScriptedMode
{
    class IHMScripted
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


        IHMScripted()
        {
            Console.Write("Création de l'IHM Scripted sans adresse");
        }

        IHMScripted(string inFilePath)
        {
            Console.Write("Création de l'IHM Scripted avec adresse");
        }

        public void Test()
        {
            return;
        }
    }
}