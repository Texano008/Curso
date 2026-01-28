using System;
using System.Globalization;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Entrada de dados - usuario digita algo no console e o programa armazena em uma variavel
            Console.WriteLine("Digite o nome completo");
            string nomeCompleto = Console.ReadLine();
            Console.WriteLine("Digite a idade");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o preço do produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("coloque o ultimo nome, idade e altura");
            string[] vetor = Console.ReadLine().Split(' ');

            string ultimoNome = vetor[0];
            int idade2 = int.Parse(vetor[1]);
            double altura = double.Parse(vetor[2], CultureInfo.InvariantCulture);



            // Saida de dados - mostrar na tela o que foi digitado
            Console.WriteLine("Nome Completo: " + nomeCompleto);
            Console.WriteLine("Idade: " + idade);
            Console.WriteLine("Preço: " + preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Ultimo Nome: " + ultimoNome);
            Console.WriteLine("Idade: " + idade2);
            Console.WriteLine("Altura: " + altura.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}