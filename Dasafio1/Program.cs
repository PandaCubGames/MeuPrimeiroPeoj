using System;
using System.Collections.Generic;

namespace Dasafio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, num, numA= 1, numB=0, x;
            Console.WriteLine("digite quantos termos devem aparecer");
            int.TryParse(Console.ReadLine(), out N);
            
            List<int> Fibonacci = new List<int>();

            do
            {
                num = numA + numB;
                numB = numA;
            } while (x < N);

        }
    }
}
