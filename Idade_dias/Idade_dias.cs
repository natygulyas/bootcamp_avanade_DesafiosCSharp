using System;

namespace Desafios_C_ {

    class IdadeDias {

        static void Main() {

            int idade = int.Parse(Console.ReadLine());

            int ano = idade / 365;
            int mes = (idade % 365) / 30;
            int dia = (idade % 365) % 30;

            Console.WriteLine($"{ano} ano(s)\r\n{mes} mes(es)\r\n{dia} dia(s)");
        }
    }
}
