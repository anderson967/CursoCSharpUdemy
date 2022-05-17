using System;
using System.Globalization;


namespace CursoCSharp.Fundamentos {
    class FormatandoNumero {
        public static void Executar() {
            double valor = 15.175;
            // F  vc define numero de casa apos a virgula
            Console.WriteLine(valor.ToString("F1"));
            // C vc transforma em currency moeda local
            Console.WriteLine(valor.ToString("C"));
            // P vc multiplica por cem e concatena o simbolo percentual ao fim
            Console.WriteLine(valor.ToString("P"));
            //
            Console.WriteLine(valor.ToString("#.##"));
            //
            Console.WriteLine(valor.ToString("P"));
            //
            CultureInfo cultura = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C2", cultura));
            // D ... adiciona zeros a esquerda até o numero definido
            int inteiro = 256;
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
