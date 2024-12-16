using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Ucenje
{
    internal class E12Metode
    {
        public static void Izvedi()
        {
            Tip1();
            Tip1();

            Tip2(7);
            Tip2(5);

            Tip2(10, "Poziv druge varijante metode Tip2");

            int i = Tip3() + 1;
            Console.WriteLine(i);

            int[] niz = { 2, 5, 2, 1, 4, 1, 2, 1, 4, 2, 3 };
            Console.WriteLine(Tip4(niz));
        }


        static void Tip1()
        {
            Console.WriteLine("Ispis iz 1. tipa metode");
            Console.WriteLine("******************");
            Console.WriteLine("Kraj ispisa 1. tipa metode");
        }

        private static void Tip2(int x)
        {
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine(i);
            }
        }

        private static void Tip2(int x, string naslov)
        {
            Console.WriteLine(naslov);
            Tip2(x);
        }

        private static int Tip3()
        {
            return int.MaxValue;
        }

        private static int Tip4(int[] niz)
        {
            int suma = 0;
            foreach (int i in niz)
            {
                suma += i;
            }
            return suma;
        }

    }
}
