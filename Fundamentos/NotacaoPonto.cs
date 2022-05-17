using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, "World!").Replace("World!", " Mundo!");
            Console.WriteLine(saudacao);
            // Numero de caracteres utiliza .Length
            Console.WriteLine("Teste".Length);
            //null é para eclarar um valor vazio
            string valorImportante = null;
            valorImportante = "Casa";
            //? é para uma navegação segura e não chamar objetos vazios
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
