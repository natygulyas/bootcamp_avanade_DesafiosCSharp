using System;

namespace Desafios_C_
{
    class CardapioAereo
    {
        static void Main()  {
            string[] refeicoes = Console.ReadLine().Split(" ");
            int Ca = int.Parse(refeicoes[0]);
            int Ba = int.Parse(refeicoes[1]);
            int Pa = int.Parse(refeicoes[2]);

                string[] escolhas = Console.ReadLine().Split(" ");
                int Cr = int.Parse(escolhas[0]);
                int Br = int.Parse(escolhas[1]);
                int Pr = int.Parse(escolhas[2]);

                int pizzas = 0;
                int saladas = 0;
                int massas = 0; 
              
                if (Cr > Ca) {
                pizzas = Cr - Ca;
                } 
          
                if (Br > Ba) {
                saladas = Br - Ba;
                } 

                if (Pr > Pa) {
                massas = Pr - Pa;
                } 
            
                int vaifaltar = pizzas + saladas + massas;

                if (vaifaltar >= 0) {
                Console.WriteLine(vaifaltar);              
                }        
        }   
    }
}
