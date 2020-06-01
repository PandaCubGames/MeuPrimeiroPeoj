using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe sua idade");
            int.TryParse(Console.ReadLine(), out int idade);
            Console.WriteLine(idade);

            if (idade < 12)
            {
                Console.WriteLine("Voce e uma crianca");
            }
            else if(idade>=12 && idade < 18)
            {
                Console.WriteLine("Voce e um adolecente");
            }
            else
            {
                Console.WriteLine("voce e um adulto");
            }

            string mensagem = idade > 18 ? "Voce e maior de idade" : "Voce e menor de idade";
            Console.WriteLine(mensagem);

            Console.WriteLine("Informe seu mes de nascimento");
            var mes = Console.ReadLine();

            switch (mes.ToLower())
            {
                case "dezembro":
                case "janeiro":
                case "fevereiro":
                    Console.WriteLine("Voce nasceu no verao");
                    break;
                case "marco":
                case "abril":
                case "maio":
                    Console.WriteLine("Voce nasceu no outrono");
                    break;
                 case "junho":
                case "julho":
                case "agosto":
                    Console.WriteLine("Voce nasceu no inverno");
                    break;
                case "setembro":
                case "outubro":
                case "novembro":
                    Console.WriteLine("Voce nasceu na primavera");
                    break;
                default:
                    Console.WriteLine("mes nao reconhecido");
                    break;
            }

            // List e Array
            string[] nomes = new string[5];
            nomes[0] = "ana";
            nomes[1] = "bola";
            nomes[2] = "ola";
            nomes[3] = "xupa";

            Console.WriteLine("escrava seu nome");
            nomes[4] = Console.ReadLine();
            Console.WriteLine(nomes[4]);

            List<string> sobrenomes = new List<string>();
            sobrenomes.Add("c");
            for(int i=0; i< nomes.Count(); i++)
            {
                sobrenomes.Add(nomes[i]);
            }
            for(int i=0; i<sobrenomes.Count; i++)
            {
                Console.WriteLine($"sobrenome{i + 1}: {sobrenomes[i]}");
            }
            Console.WriteLine();

            foreach (string sobrenome in sobrenomes)
            {
                Console.WriteLine($"Sobrenome por foreach: {sobrenome}");
            }
            Console.WriteLine();

            sobrenomes.ForEach(sobrenome =>
            Console.WriteLine($"sobrenome por foreach1: {sobrenome}"));
            Console.WriteLine();

            int x = sobrenomes.Count - 1;
            while (x >= 0)
            {
                Console.WriteLine($"Sobrenome por While invertido: {sobrenomes[x]}");
                x--;
            }
            int y = 0;
            do
            {
                Console.WriteLine($"nomes pelo do While {nomes[y]}");
                y++;
            } while (y < nomes.Length);
        }
    }
}
