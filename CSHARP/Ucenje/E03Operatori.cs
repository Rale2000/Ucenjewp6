using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E03Operatori
    {


        public static void Izvedi()
        {


            //Console.WriteLine("E03")

            
            int i = 7;

           
            Console.WriteLine(i == 6);

            
            int k = 2, l = 1;

           
            Console.WriteLine(l / k);

            
            Console.WriteLine(l / (float)k);

           
            Console.WriteLine(i != k);

            
            Console.WriteLine("5%2={0}", 5 % 2);

            
            Console.WriteLine("4%2={0}", 4 % 2);


            int b = 0;

            b = b + 1; //1

            b += 1; //2

            b++; //3

            Console.WriteLine(b);

            b = 0;

            Console.WriteLine(b++); //0

            Console.WriteLine(++b); //2

            int t = 0, c = 1;
            t = c++ + t; //t = 1, c = 2
            c += --t; // c = 2 , t = 0

            Console.WriteLine(c+t); //2














        }






    }
}
