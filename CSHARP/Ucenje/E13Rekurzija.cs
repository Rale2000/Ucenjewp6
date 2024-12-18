﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E13Rekurzija
    {
        public static void Izvedi()
        {
            //Izvedi();  // Ovdje dobijemo Stack overflow

            Console.WriteLine(Zbroji(100));

        }

        private static int Zbroji(int broj)
        {
            if (broj == 1)
            {
                return 1;
                
            }
            return broj + Zbroji(broj - 1);
        }
       
    }
}
