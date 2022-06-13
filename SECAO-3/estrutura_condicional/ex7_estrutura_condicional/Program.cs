/*Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).

Se o ponto estiver na origem, escreva a mensagem “Origem”.

Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.*/
using System;
using System.Globalization;

namespace ex7_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] eixo = Console.ReadLine().Split(' ');
            double eixoX = double.Parse(eixo[0], CultureInfo.InvariantCulture);
            double eixoY = double.Parse(eixo[1], CultureInfo.InvariantCulture);

            if (eixoX == 0 || eixoY == 0)
            {
                Console.WriteLine("ORIGEM");
            }
            else if (eixoX > 0 && eixoY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX < 0 && eixoY < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (eixoX < 0 && eixoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (eixoX > 0 && eixoY < 0)
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
