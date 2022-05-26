/* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.*/ 
using System;
using System.Globalization; //Para conseguir digitar ponto ao invés de vírgula nos valores.

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o código da peça: ");
            int cod1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de peças: ");
            int qnt1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário da peça: ");
            double valor1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //CultureInfo.InvariantCulture serve para aceitar o ponto no lugar da vírgula.

            Console.Write("Digite o código da peça: ");
            int cod2 = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de peças: ");
            int qnt2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor unitário da peça: ");
            double valor2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = (qnt1 * valor1) + (qnt2 * valor2);
            
            Console.WriteLine("O valor total a ser pago é de: {0:F2}", total);
        }
    }
}
