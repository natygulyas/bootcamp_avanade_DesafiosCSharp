using System;

namespace Desafios_C_
{
    class QuadradoAoCubo
    {
        static void Main()
        {
            int N = Int32.Parse(Console.ReadLine());
                                 
            if( N >= 1 ) {  
              
                for(int i = 1; i <= N; i++) {  
                 
                    var saidas = $"{i} {Math.Pow(i,2)} {Math.Pow(i,3)}";
                    Console.WriteLine(saidas);
                }
            }
        }
    }
}