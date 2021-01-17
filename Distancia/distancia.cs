using System;

namespace Desafios_C_
{
    class distancia
    {
        static void Main() {
            Console.WriteLine("Digite quantos quilômetros de distância você quer entre a moto Y e a moto X que eu te retorno quantos minutos são necessários pra atingir essa distância");
            int quilometros = Int32.Parse(Console.ReadLine());
            int minutos = quilometros * 2;  // multiplicado por 2 porque considerando as velocidades constantes das motos (60km/hr e 90km/h) o tempo em minutos sempre corresponde ao dobro da distância entre elas nesse caso
            Console.WriteLine($"{minutos} minutos");           
        }
    }
}