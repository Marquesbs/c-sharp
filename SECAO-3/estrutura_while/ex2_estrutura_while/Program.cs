/*Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).*/
using System;

namespace ex2_estrutura_while
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int valor_X = int.Parse(valores[0]);
            int valor_Y = int.Parse(valores[1]);;
            while(valor_X != 0 && valor_Y != 0)
            {
                if(valor_X > 0 && valor_Y > 0)
                {
                    System.Console.WriteLine("primeiro");
                }
                else if(valor_X > 0 && valor_Y < 0)
                {
                    System.Console.WriteLine("quarto");
                }
                else if(valor_X < 0 && valor_Y > 0)
                {
                    System.Console.WriteLine("segundo");
                }
                else
                {
                    System.Console.WriteLine("terceiro");
                }
                valores = Console.ReadLine().Split(' ');
                valor_X = int.Parse(valores[0]);
                valor_Y = int.Parse(valores[1]);
            }
        }
    }
}
