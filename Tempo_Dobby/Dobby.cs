using System;

namespace Desafios_C_{

  class TempoDobby {

    static void Main() { 
        
    int N = int.Parse(Console.ReadLine());

       string[] AeB = Console.ReadLine().Split(" ");
       int presentes = int.Parse(AeB[0]);
       int minutos = int.Parse(AeB[1]);
                
          if (minutos >= presentes && minutos <= N) {          
            Console.WriteLine("Farei hoje!");
          } 
            else {
              Console.WriteLine("Deixa para amanha!");
            }     
    }
  }
}
        