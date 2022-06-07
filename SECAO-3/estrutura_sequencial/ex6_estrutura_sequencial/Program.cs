/*Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
mostre:
a) a área do triângulo retângulo que tem A por base e C por altura.
b) a área do círculo de raio C. (pi = 3.14159)
c) a área do trapézio que tem A e B por bases e C por altura.
d) a área do quadrado que tem lado B.
e) a área do retângulo que tem lados A e B.
*/
using System;
using System.Globalization;

namespace ex6_estrutura_sequencial
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vetor = Console.ReadLine().Split(' ');
            double valor_a = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            double valor_b = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            double valor_c = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            double triangulo = (valor_a * valor_c) / 2;
            double circulo = Math.Pow(valor_c, 2) * 3.14159;
            double trapezio = ((valor_a + valor_b) * valor_c) / 2;
            double quadrado = Math.Pow(valor_b, 2);
            double retangulo = valor_a * valor_b;

            Console.WriteLine("TRIANGULO = {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO = {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO = {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO = {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO = {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
