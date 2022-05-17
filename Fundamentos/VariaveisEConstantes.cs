using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // Área da Circunferência 
            double raio = 4.5;
            const double PI = 3.14;
            
            // raio = 5.5;

            double area = PI * raio * raio;
            // PI = 3.1415;
            // Concatenação de uma string com um valor se coloca +
            Console.WriteLine("A area é: " + area);
            // Tipos Internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            byte idade = 38;
            Console.WriteLine("Sua idade é: " + idade);

            // s significa signed ou com sinal valores negativos e positivos
            sbyte saldoDeGols = sbyte.MinValue; 
            Console.WriteLine("Saldo de gols é: " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("O salário é: " + salario);

            int menorValorInt = int.MinValue;
            Console.WriteLine("O menor valor inteiro é: " + menorValorInt);

            // u significa unsigned ou sem sinal valores positivos
            uint inteiroSemSinal = uint.MaxValue;
            Console.WriteLine("inteiro sem sinal é: " + inteiroSemSinal);
            // É possível utilizar como separador numérico o underscore ou underline 
            // para ficar visivelmente melhor para identificar o valor
            // sem impactar a apresentação no console
            uint populacaoBrasileira = 211_740_400;
            Console.WriteLine("População Brasileira é: " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("O menor valor long é: " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial é: " + populacaoMundial);

            float precoDoComputador = 1299.99f;
            Console.WriteLine("Preço do computador é: R$ " + precoDoComputador);

            double valorDaApple = 1_000_000_000_000;
            Console.WriteLine("Valor de mercado da Apple é: R$ " + valorDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue;
            Console.WriteLine("Distancia entre as estrelas " + distanciaEntreEstrelas);

            char letra = 'a';
            Console.WriteLine("letra " + letra);

            string texto = "Seja bem vindo ao curso C#!";
            Console.WriteLine(texto);

        }
    }
}
