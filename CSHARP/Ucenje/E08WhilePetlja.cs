﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E08WhilePetlja
    {


        public static void Izvedi()
        {
            Console.WriteLine("E08");

            int brojDo = 0;

            for(int i = 0; i < brojDo; i++)
            {
                Console.WriteLine(i);
            }


            while (true)
            {
                Console.WriteLine("Osijek");
                break;
            }



            int broj = 0, t = 2;
            while (broj < 10 && t==2)
            {
                Console.WriteLine(++broj);
                
            }

            broj = 10;
            while(broj < 10)
            {
                Console.WriteLine(++broj);
            }


            int suma = 0;
            for(int j = 1; j <= 100; j++)
            {
                suma += j;
            }
            Console.WriteLine(suma);

            suma = 0;
            broj = 1;
            while (broj <= 100)
            {
                suma += broj++;
                suma = suma + broj;
                broj = broj + 1;
            }
            Console.WriteLine(suma);



        







        }


    }
}
