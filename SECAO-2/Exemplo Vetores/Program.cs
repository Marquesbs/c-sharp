using System;

namespace Exemplo_Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();
            
            string[] vetor = Console.ReadLine().Split(' ');

            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            System.Console.WriteLine(frase);
            System.Console.WriteLine(x);
            System.Console.WriteLine(y);
            System.Console.WriteLine(z);
            System.Console.WriteLine(a);
            System.Console.WriteLine(b);
            System.Console.WriteLine(c);
        }
    }
}
