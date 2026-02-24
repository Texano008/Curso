using System;

namespace AulaEstruturaRepetitiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("quantos numeros inteiros voce vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++) { 
                Console.WriteLine("oi");
            }
        }
    }
}
