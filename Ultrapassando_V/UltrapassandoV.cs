using System;

namespace Desafios_C_ {

    class UltrapassandoV {

       static void Main() { 

         int R = Int32.Parse(Console.ReadLine());
         int V = 0; 
         int soma = 0; 
         int contaN = 0; 

            while (V <= R) { 
                V = Int32.Parse(Console.ReadLine()); 
            } 
            while (soma <= V) { 
                soma += R; 
                R++; 
                contaN++; 
            }  
                Console.WriteLine(contaN); 
        } 
    }
}