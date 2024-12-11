using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E10foreachPetlja
    {
        public static void Izvedi()
        {
            //Console.WriteLine("E10");

            Console.Write("Unesi ime svog grada: ");

            string grad = Console.ReadLine();

            Console.WriteLine(grad);

            char[] znakoviGrad = new char[6];
            znakoviGrad[0] = 'o';
            znakoviGrad[0] = 's';
            znakoviGrad[0] = 'i';
            znakoviGrad[0] = 'j';
            znakoviGrad[0] = 'e';
            znakoviGrad[0] = 'k';

            for (int i = 0; i < 6; i++)
            {
                Console.Write(znakoviGrad[i]);
            }
            Console.WriteLine();

            for (int i = 0;i<grad.Length;i++)
            {
                Console.Write(grad[i]);
            }
            Console.WriteLine();


            foreach(char znak in znakoviGrad)
            {
                Console.Write(znak);
            }
            Console.WriteLine();

            foreach(char c in grad)
            {
                Console.Write(c);
            }
            Console.WriteLine();



            for (int i = grad.Length - 1; i >= 0; i--)
            {
                Console.Write(grad[i]);
            }



        
        
        
        }
        
    
    
    }



}
