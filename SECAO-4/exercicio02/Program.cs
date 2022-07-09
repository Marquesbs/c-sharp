/*Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.
Exemplo:
Dados do primeiro funcionário:
Nome: Carlos Silva
Salário: 6300.00
Dados do segundo funcionário:
Nome: Ana Marques
Salário: 6700.00
Salário médio = 6500.00*/

using System;
using System.Globalization;

namespace exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1, func2;
            func1 = new Funcionario();
            func2 = new Funcionario();

            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            func1.nome = Console.ReadLine();
            Console.Write("Salário: ");
            func1.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("\nDados do segundo funcionário:");
            Console.Write("Nome: ");
            func2.nome = Console.ReadLine();
            Console.Write("Salário: ");
            func2.salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMedio = calculoMedia(func1.salario, func2.salario);
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));
        }
        static double calculoMedia(double salario1, double salario2)
        {
            double Media = (salario1 + salario2)/2;
            return Media;
        }
    }
}
