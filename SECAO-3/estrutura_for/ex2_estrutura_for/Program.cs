/*Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).*/
using System;

namespace ex2_estrutura_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = int.Parse(Console.ReadLine());
            int dentro = 0, fora = 0, valor = 0;

            for(int i = 0; i < numero; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if(valor >= 10 && valor<= 20)
                {
                    dentro++;
                }
                else
                {
                    fora++;
                }
            }
            System.Console.WriteLine(dentro + " In");
            System.Console.WriteLine(fora + " Out");
        }
    }
}
