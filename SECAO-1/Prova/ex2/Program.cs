/* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
casas decimais conforme exemplos.
Fórmula: area = π * raio (ao quadrado)
Considere o valor de π = 3.14159*/

using System;
using System.Globalization;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor do raio de um círculo: ");
            double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double area = 3.14159 * Math.Pow(raio, 2);
            Console.WriteLine($"{area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}
