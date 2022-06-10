/*Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.*/
using System;
using System.Globalization;

namespace ex6_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            if (valor >= 0 && valor <= 25)
            {
                Console.WriteLine("INTERVALO [0, 25]");
            }
            if (valor > 25 && valor <= 50)
            {
                Console.WriteLine("INTERVALO [25, 50]");
            }
            if (valor > 50 && valor <= 75)
            {
                Console.WriteLine("INTERVALO [50, 75]");
            }
            if (valor > 75 && valor <= 100)
            {
                Console.WriteLine("INTERVALO [75, 100]");
            }
            else
            {
                System.Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
