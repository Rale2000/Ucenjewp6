using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucenje
{

    // Napišite program koji unosi vaše ime i broj godina

    // Program ispisuje: Osoba XXXXX ima YY godina.

    internal class E02Z1
    {


        public static void Izvedi()
        {
            
            
            
            Console.Write("Unesi ime: ");
            string ime= Console.ReadLine();
            Console.WriteLine("Unesi broj godina (cijeli broj): ");
            int godine = int.Parse(Console.ReadLine());

            Console.WriteLine("Osoba {0} ima {1} godina: ", ime, godine);






        }    
    
    
    
    }
}
