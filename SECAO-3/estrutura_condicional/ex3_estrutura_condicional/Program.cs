/*Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
ordem crescente ou decrescente.*/
using System;

namespace ex3_estrutura_condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois numeros inteiros: ");
            string[] vetor = Console.ReadLine().Split(' ');
            int A = int.Parse(vetor[0]);
            int B = int.Parse(vetor[1]);

            if (A % B == 0 || B % A == 0)
            {
                System.Console.WriteLine("SÃO MÚLTIPLOS!");
            }
            else
            System.Console.WriteLine("NÃO SÃO MÚLTIPLOS");
        }
    }
}
