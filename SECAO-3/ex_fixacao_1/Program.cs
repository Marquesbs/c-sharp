using System;
using System.Globalization;

namespace ex_fixacao_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem a sua casa?: ");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço de um produto: ");
            float preco = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura: (mesma linha)");
            string[] vetor = Console.ReadLine().Split(' ');
            
            System.Console.WriteLine(nome);
            System.Console.WriteLine(quartos);
            System.Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            System.Console.WriteLine(vetor[0]);
            System.Console.WriteLine(vetor[1]);
            System.Console.WriteLine(vetor[2]);
        }
    }
}
