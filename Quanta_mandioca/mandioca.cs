using System;

namespace Desafios_C_
{
    class mandioca {
        static void Main() 
        {   
            Console.WriteLine("Quantas porções de 300g o chico vai comer?");     
            int chico = 300 * Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas porções de 1500g o Bento vai comer?"); 
            int bento = 1500 * Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas porções de 600g o Bernardo vai comer?");
            int bernardo = 600 * Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas porções de 1000g a Marina vai comer?");
            int marina = 1000 * Int32.Parse(Console.ReadLine());
            Console.WriteLine("Quantas porções de 150g a Iara vai comer?");
            int iara = 150 * Int32.Parse(Console.ReadLine());
            int marlene = 225;
            int total = chico + bento + bernardo + marina + iara + marlene;
            Console.WriteLine($"Será necessário preparar {total} gramas de madioca");
        }
    }
}  