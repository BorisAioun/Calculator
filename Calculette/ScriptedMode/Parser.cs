using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette.ScriptedMode
{
    class Parser
    {
        public string mFilePath
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


        public Parser(string inFilePath)
        {
            mFilePath = inFilePath;
            Console.Write("Lecture du fichier %s \n", mFilePath);
        }

    }
}
