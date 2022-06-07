/*Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
decimais.*/
using System;
using System.Globalization;

namespace ex4_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod = int.Parse(Console.ReadLine());
            float hora_trabalhada = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float salario_hora = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            float salario = salario_hora * hora_trabalhada;
            
            Console.WriteLine($"NUMBER = {cod}");
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
