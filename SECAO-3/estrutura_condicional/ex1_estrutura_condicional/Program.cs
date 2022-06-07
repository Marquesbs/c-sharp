//Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
using System;

namespace ex1_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                System.Console.WriteLine("O numero digitado não é negativo!");
            }
            else
            {
                System.Console.WriteLine("O numero digitado é negativo!");
            }
        }
    }
}
