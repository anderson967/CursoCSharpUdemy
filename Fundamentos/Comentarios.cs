using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Comentarios {
        public static void Executar() {
            // Cuidado com os comentários desnecessários
            Console.WriteLine("Código claro é sempre melhor!");
            /// <summary>
            /// Para documentação
            /// </summary>
            Console.WriteLine("O C# tem o XML Comments!");
            /* Comentários 
             * de
             * multiplas linhas
             */
            Console.WriteLine("Comentários de multiplas linhas!");
            // Control K+C comenta linhas selecionadas
            // Control K+U descomenta linhas selecionadas
            // Console.WriteLine("1");
            // Console.WriteLine("2");
        }
    }
}
