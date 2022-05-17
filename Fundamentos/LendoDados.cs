using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Seu nome é " + nome);

            Console.WriteLine("Qual é sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Sua idade é " + idade + " anos.");

            Console.WriteLine("Qual é o seu salário? ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("Seu salário é R$ " + salario + ".");

            Console.WriteLine($"Seu nome é {nome} sua idade é {idade} anos e seu salário é R${salario}.");
        }
    }
}
