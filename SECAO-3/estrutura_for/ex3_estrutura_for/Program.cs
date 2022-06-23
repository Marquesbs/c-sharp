/*Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste
de 3 valores reais, cada um deles com uma casa decimal. Apresente a média ponderada para cada um destes
conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro valor tem
peso 5.*/
using System;
using System.Globalization;

namespace ex3_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            double media = 0;
            for(int x = 0; x < numero; x++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                media = (double.Parse(vet[0], CultureInfo.InvariantCulture) * 0.2) + (double.Parse(vet[1], CultureInfo.InvariantCulture) * 0.3) + (double.Parse(vet[2], CultureInfo.InvariantCulture) * 0.5);
                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
