using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MeuPrimeiroPeoj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores aritmeticos

            Programadora dev = new Programadora();
            dev.Nome = "Otavio Ribeiro";
            dev.AnosDeCarreira = 2;
            dev.ConheceMetodologiaAgil = true;
            dev.DataAdmissao = new DateTime(2020, 05, 14);
            dev.DataNascimento = new DateTime(1995, 02, 28);
            dev.Id = 5;
            dev.Linguagens = new List<string>() { "C#", "English", "Portuguese" };
            string nome = "Otavio";
            bool EChupaRola = true;
            int idade = 25;
            nome = idade.ToString();
            Console.WriteLine(nome);


            var soma = 10 + 5;
            var subtracao = 10 - 5;
            var multiplicacao = 10 * 5;
            var divisao = 10 / 5;
            var mod = 10 % 3;

            Console.WriteLine($"Resultado do soma {soma}");
            Console.WriteLine($"Resultado do subitracao {subtracao}");
            Console.WriteLine($"Resultado do multiplicacao {multiplicacao}");
            Console.WriteLine($"Resultado do ddivisao {divisao}");
            Console.WriteLine($"Resultado do resto {mod}");

            // Operadores lgocicos

            var Etrue = true && true;
            var Efalse = false && true;

            var OuVerdadeiro = true || true;
            var OuVerdadeiro1 = true || false;
            var OuFalso = false || false;

            Console.WriteLine(Etrue);
            Console.WriteLine(Efalse);
            Console.WriteLine(OuVerdadeiro);
            Console.WriteLine(OuVerdadeiro1);
            Console.WriteLine(OuFalso);

            var fakeTrue = !true;
            var fakeFalse = !false;

            Console.WriteLine(fakeTrue);
            Console.WriteLine(fakeFalse);

            // Conversao Implicita
            int varInt = 20;
            long varLong = varInt;

            float varFloat = 10.5f;
            double varDouble = varFloat;

            char varChar = 'T';
            int varInt1 = varChar;
            string meuTexto = $"Nest testo vamos testar a conversao implicita " +
                $"de variavel inteira {varInt} e variavel float {varFloat}";

            Funcionario devFunc = dev;

            Console.WriteLine($"Conversao implicita: int para long: {varLong}");
            Console.WriteLine($"Conversao implicita: float para double: {varDouble}");
            Console.WriteLine($"Conversao implicita: char para int {varInt1}");
            Console.WriteLine($"Conversao implicita por interpolacao: {meuTexto}");
            Console.WriteLine($"Conversao implicita: classe filha para classe pai: "
                + $"Nome : {devFunc.Nome}, "
                + $"dt adm: {devFunc.DataAdmissao:dd/MM/yyyy}, "
                + $"dt nasc: {devFunc.DataNascimento:dd/MM/yy}");
            Console.WriteLine();


        }

        public class Funcionario
        {
            public int Id { get; set; }
            public string Nome { get; set; }
            public DateTime DataNascimento { get; set; }
            public DateTime DataAdmissao { get; set; }
        }

        public class Programadora : Funcionario
        {
            public List<string> Linguagens { get; set; }
            public bool ConheceMetodologiaAgil { get; set; }
            public int AnosDeCarreira { get; set; }
        }
    }
}
