using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Letiral_characters
{
    class Program
    {
        static void Main(string[] args)
        {
            int myvar = -100;
            uint myUvar = 1000U;
            long myLvar = 1000;
            ulong myULvar = 1000;
            float myFvar = 1.5F;
            double myDvar = 100.5;
            decimal myDecvar = 100.5M; 

                Console.WriteLine("{0} {1}", myvar, myUvar);
            Console.WriteLine($"{myLvar}, {myULvar}, {myFvar}, {myDvar}, {myDecvar}");
            Console.ReadKey();
        }
    }
}
