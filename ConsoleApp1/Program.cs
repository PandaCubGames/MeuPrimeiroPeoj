using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Diego";
            funcionario.DataAdmissao = new DateTime(2020, 03, 03);
            funcionario.DataNascimento = new DateTime(2020, 05, 08);


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

            // Conversao explicita

            long varLongExp = 9223372036854775807;
            int varIntExp = (int)varLongExp;


            varInt = (int)varLong;
            string longParaString = varLong.ToString();
            decimal varDecimal = Convert.ToDecimal("15.2");
            varDecimal += 10;
            decimal.TryParse("morango", out decimal varDecimalTry);
            decimal.TryParse("17", out decimal varDecimalTry1);

            if (devFunc is Programadora info)
                Console.WriteLine($"Conversao explicita: func e programadora: {info.Nome}");

            if (funcionario is Programadora infoFunc)
                Console.WriteLine($"conversao explicita: func e programador: {infoFunc.Nome}");

            Console.WriteLine($"conversao explicita: log(max) para int: {varIntExp}");
            Console.WriteLine($"conversao explicita: log para int: {varInt}");
            Console.WriteLine($"conversao explicita: log para string: {longParaString}");
            Console.WriteLine($"conversao explicita: string para decimal: {varDecimal}");
            Console.WriteLine($"conversao explicita: string para decimal via tryParse: {varDecimalTry}");
            Console.WriteLine($"conversao explicita: string para decimal via tryParse: {varDecimalTry1}");


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
