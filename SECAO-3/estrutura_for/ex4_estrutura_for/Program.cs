/* Fazer um programa para ler um número N. Depois leia N pares de números e mostre a divisão do primeiro pelo
segundo. Se o denominador for igual a zero, mostrar a mensagem "divisao impossivel".*/
using System;
using System.Globalization;

namespace ex4_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int c = 0;c < num; c++)
            {
                string[] vet = Console.ReadLine().Split(" ");
                int num1 = int.Parse(vet[0]);
                int num2 = int.Parse(vet[1]);

                if (num2 == 0)
                {
                    System.Console.WriteLine("Divisão Impossível");
                }
                else
                {
                    double divisao = (double)num1 / num2;
                    System.Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
