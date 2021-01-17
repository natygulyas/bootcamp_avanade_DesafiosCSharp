using System;

namespace Desafios_C_
{
    class desafioDaCorrida
    {
        static void Main() {
            string[] voltaseplacas = Console.ReadLine().Split(" ");       
            int A = int.Parse(voltaseplacas[0]);
            int N = int.Parse(voltaseplacas[1]);

            double seqplacas = A * N;
                                         
                for (int i = 1; i <= 9; i++) {
                    
                    double totalplacas = seqplacas * i * 10/100;
                    Console.WriteLine(Math.Ceiling(totalplacas) + " ");
                }                 
        }    
    }
}