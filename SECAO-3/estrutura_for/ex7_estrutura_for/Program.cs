/* Fazer um programa para ler um número inteiro positivo N. O programa deve então mostrar na tela N linhas,
começando de 1 até N. Para cada linha, mostrar o número da linha, depois o quadrado e o cubo do valor, conforme
exemplo.*/
using System;

namespace ex7_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            double quadrado, cubo;
            for (int linha = 1;linha <= numero; linha++)
            {
                quadrado = Math.Pow(linha, 2);
                cubo = Math.Pow(linha, 3);
                System.Console.WriteLine($"{linha} {quadrado} {cubo}");
            }
        }
    }
}
