/*Ler um valor N. Calcular e escrever seu respectivo fatorial. Fatorial de N = N * (N-1) * (N-2) * (N-3) * ... * 1.
Lembrando que, por definição, fatorial de 0 é 1.*/
using System;

namespace ex5_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int fatorial = N;
            if (N != 0)
                {
                    for(int c = 1;c < N; c++)
                    {
                        fatorial = fatorial * c;
                    }
                    System.Console.WriteLine(fatorial);
                }
            else
            {
                System.Console.WriteLine("1");
            }
        }
    }
}