using System;

namespace Desafios_C_
{
    class DivisaoXporY {

        static void Main() {

        Console.WriteLine("Digite quantos pares de números você quer dividir");         
            int quantospares = Int32.Parse(Console.ReadLine());
            for (int i = 0; i < quantospares; i++) {

                Console.WriteLine("Agora digite o dividendo, tecle espaço e digite o divisor");
                string[] linha2 = Console.ReadLine().Split(" ");
                double X = double.Parse(linha2[0]);
                double Y = double.Parse(linha2[1]);

                if (Y <= 0) {
                    Console.WriteLine("divisao impossivel");
                }   
                    else {
                        double divisao = X / Y; 
                        if(divisao < 0 && (divisao.ToString("N1") == "0.0"))
                        Console.WriteLine("-0.0");
                        else
                        Console.WriteLine(divisao.ToString("N1"));
                        Console.WriteLine("Desafio concluído");
                    }
            }
        }
    }
}