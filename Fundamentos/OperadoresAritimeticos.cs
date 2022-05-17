using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritimeticos {
        public static void Executar() {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total *desconto);
            Console.WriteLine(totalComDesconto.ToString("C"));
            // IMC
            double peso = 86.4;
            double altura = 1.74;
            double imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"IMC é {imc.ToString("F2")}.");
            // Número Par/ Impar
            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);



        }
    }
}
