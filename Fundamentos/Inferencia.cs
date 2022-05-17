using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            //com a declaração var é obrigatorio inicializar um valor
            var nome = "Anderson";
            //nome = 123;
            Console.WriteLine(nome);

            var idade = 38;
            Console.WriteLine("A idade é " + idade);

            int a;
            a = 3;

            int b;
            b = 2;

            Console.WriteLine("A soma é " + (a + b));
        }
    }
}
