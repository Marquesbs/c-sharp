//Ler um número inteiro N e calcular todos os seus divisores.
using System;

namespace ex6_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int c = 1;c <= N;c++)
            {
                if (N % c == 0)
                {
                    System.Console.WriteLine(c);
                }
            }
        }
    }
}
