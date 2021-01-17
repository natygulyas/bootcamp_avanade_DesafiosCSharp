using System;

namespace Desafios_C_
{
    class DiaPizza
    {
        static void Main(string[] args) {

            string[] pessoasedatas = Console.ReadLine().Split(" ");
            int N =int.Parse(pessoasedatas[0]);
            int D =int.Parse(pessoasedatas[1]);
     
            string datasugestao = "";
      
            for (int i = 0; i < D; i++) { 
            int pessoas = 0;
            string[] dataseconfirm = Console.ReadLine().Split(" ");
            datasugestao = dataseconfirm[0];
          
               for (int j = 1; j < N + 1; j++) {
                   pessoas += int.Parse(dataseconfirm[j]);
                }
               if (pessoas == N) {
                  Console.WriteLine(datasugestao);
                  break;
                }
                  else if (i + 1 >= D) {
                      Console.WriteLine("Pizza antes de FdA");
                    }
            }      
        }
    }
}