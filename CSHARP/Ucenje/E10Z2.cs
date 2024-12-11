using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10Z2
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E10Z2");
            int b = 458;
            bool print = true;
            for (int i = 2; i < b; i++)
            {
                if (b % i == 0)
                {
                    print = false;
                    break;
                }
            }
            Console.WriteLine(print ? "DA" : "NE");
            
        }
    }
}
