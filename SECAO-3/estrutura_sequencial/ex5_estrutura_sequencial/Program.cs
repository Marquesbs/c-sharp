/*Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/
using System;
using System.Globalization;

namespace ex5_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            int codigo1 = int.Parse(vetor[0]);
            int quant1 = int.Parse(vetor[1]);
            float valor1 = float.Parse(vetor[2], CultureInfo.InvariantCulture);

            vetor = Console.ReadLine().Split(' ');
            int codigo2 = int.Parse(vetor[0]);
            int quant2 = int.Parse(vetor[1]);
            float valor2 = float.Parse(vetor[2], CultureInfo.InvariantCulture);

            float total = (valor1 * quant1) + (quant2 * valor2);
            System.Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
