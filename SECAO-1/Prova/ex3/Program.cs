using System;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo = int.Parse(Console.ReadLine());
            int quantidade = int.Parse(Console.ReadLine());
            double valor = 0.0f;

            if (codigo == 1)
            {
                valor = (double) quantidade * 4.0f;
                Console.WriteLine($"Total: R$ " + valor.ToString("F2"));
            }
            if (codigo == 2)
            {
                valor = (double) quantidade * 4.50f;
                Console.WriteLine($"Total: R$ " + valor.ToString("F2"));
            }
            if (codigo == 3)
            {
                valor = (double) quantidade * 5.0f;
                Console.WriteLine($"Total: R$ " + valor.ToString("F2"));
            }
            if (codigo == 4)
            {
                valor = (double) quantidade * 2.0f;
                Console.WriteLine($"Total: R$ " + valor.ToString("F2"));
            }
            if (codigo == 5)
            {
                valor = (double) quantidade * 1.0f;
                Console.WriteLine($"Total: R$ " + valor.ToString("F2"));
            }
        }
    }
}
