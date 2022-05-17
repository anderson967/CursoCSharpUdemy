using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturasDeControle;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Control D para duplicar a linha 
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentários - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolacao.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo Dados - Fundamentos", LendoDados.Executar},
                {"Formatando Números - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operador Unário - Fundamentos", OperadoresUnarios.Executar},
                {"Operador Ternário - Fundamentos", OperadoresTernarios.Executar},
                // EstruturasDeControle
                {"Estrutura If - Estruturas de Controle", EstruturaIf.Executar},
                {"Estrutura For - Estruturas de Controle", EstruturaFor.Executar},
                {"Estrutura ForEach - Estruturas de Controle", EstruturaForEach.Executar},
                {"Estrutura IfEsle - Estruturas de Controle", EstruturaIfElse.Executar},
                {"Estrutura IfEsleIf - Estruturas de Controle", EstruturaIfElseIf.Executar},
                {"Estrutura Switch - Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrutura While - Estruturas de Controle", EstruturaWhile.Executar},
                {"Usando Break - Estruturas de Controle", UsandoBreak.Executar},
                {"Usando Continue - Estruturas de Controle", UsandoContinue.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}