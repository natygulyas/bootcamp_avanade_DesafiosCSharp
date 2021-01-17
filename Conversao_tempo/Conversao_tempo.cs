using System;

namespace Desafios_C_
{
    class ConversaoTempo {
        static void Main() { 
        
            int N = int.Parse(Console.ReadLine());

            int horas = N / 3600;
            int minutos = (N % 3600) / 60;
            int segundos = (N % 3600) % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }
}