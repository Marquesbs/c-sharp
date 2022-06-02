/*Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau. Em seguida, 
mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja abaixo). 
Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser negativo), mostrar uma mensagem "Impossivel calcular".*/
using System;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Entre com o valor de A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de A: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Entre com o valor de A: ");
            double c = double.Parse(Console.ReadLine());
            
            double delta = Math.Pow(b, 2) - (4 * a * c);//funcão de potênciação.

            double x1 = (-b + Math.Sqrt(delta))/(2 * a);//função de raiz quadrada.
            double x2 = (-b - Math.Sqrt(delta))/(2 * a);

            if(a == 0.0 || delta < 0.0) //se a for igual a zero ou delta menor que zero, então mostrar na tela impossível calcular.
            {
                System.Console.WriteLine("Impossível Calcular");
            }

            else
            {
                System.Console.WriteLine(x1.ToString("F5"));
                System.Console.WriteLine(x2.ToString("F5"));
            }
        }
    }
}
