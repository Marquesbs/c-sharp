//Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso.
using System;

namespace ex1_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            
            for (int valor = 1; valor <= x; valor++)
            {
                if (valor % 2 != 0)
                {
                    Console.WriteLine(valor);
                }
            }
        }
    }
}
