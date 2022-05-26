using System;
using System.Globalization;

namespace Exercício_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero ='M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine($"{produto1}, cujo o preço é $ {preco1.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine("{0}, cujo o preço é $ {1}\n", produto2, preco2);
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e genero {genero}\n");
            Console.WriteLine("Medida com oito casas decimais: {0}", medida);
            Console.WriteLine("Arredondado (três casas decimais): " + medida.ToString("F3"));
            Console.WriteLine($"Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
