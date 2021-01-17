using System;

namespace Desafios_C_ {

    class CorridaTartarugas {

        static void Main() {

            string N = Console.ReadLine();
            do {
                string[] Vi;

                if (!string.IsNullOrWhiteSpace(N)) {
                    Vi = Console.ReadLine().Split(" ");
                    int velocidade = 0;

                    foreach (var item in Vi) {
                        if (Int32.Parse(item) > velocidade)
                           velocidade = Int32.Parse(item);
                    }
                        if (velocidade < 10) {
                           Console.WriteLine(1);
                        }
                        else if (velocidade >= 10 && velocidade < 20) {
                           Console.WriteLine(2);
                        }
                        else {
                           Console.WriteLine(3);
                        }
                }
               N = Console.ReadLine();
            }  while (!string.IsNullOrWhiteSpace(N));
        }
    }
}