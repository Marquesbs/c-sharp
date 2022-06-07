//Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
using System;

namespace ex2_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                System.Console.WriteLine("PAR");
            }
            else
            System.Console.WriteLine("IMPAR");
        }
    }
}
