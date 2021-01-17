using System;
using System.Text.RegularExpressions;

namespace Desafios_C_
{
    class RodizioCavalosECarruagens
    {
        static void Main() { 
        
            int N = int.Parse(Console.ReadLine());
             
            for(int i = 1; i <= N; i++) {
                 string placa = Console.ReadLine();
                 var padraoCorreto = new Regex("[A-Z]{3}[0-9]{4}");
      
                  if (string.IsNullOrWhiteSpace(placa) 
                    || placa.Length != 8
                    || !placa.Contains("-"))
                  { 
                    Console.WriteLine("FALHA");
                    continue;
                  } 
      
                    placa = placa.Replace("-", "").Trim();

                    if (!padraoCorreto.IsMatch(placa)) {
                      Console.WriteLine("FALHA");
                      continue;
                    }
                      int Fplaca = int.Parse(placa.Substring(6,1));

                      if (Fplaca == 1 || Fplaca == 2) {                         
                        Console.WriteLine("SEGUNDA");
                      }
                      if (Fplaca == 3 || Fplaca == 4) {                         
                        Console.WriteLine("TERCA");
                      }
                      if (Fplaca == 5 || Fplaca == 6) {                         
                        Console.WriteLine("QUARTA");
                      }
                      if (Fplaca == 7 || Fplaca == 8) {                         
                        Console.WriteLine("QUINTA");
                      }
                      if (Fplaca == 0 || Fplaca == 9) {                         
                        Console.WriteLine("SEXTA");
                      }                         
            }
        }
    }
}