/*EXERCÍCIO 01:
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.
Exemplo:
Dados da primeira pessoa:
Nome: Maria
Idade: 17
Dados da segunda pessoa:
Nome: Joao
Idade: 16
Pessoa mais velha: Maria*/

using System;

namespace exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa dado1, dado2;
            dado1 = new Pessoa();
            dado2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            dado1.nome = Console.ReadLine();
            Console.Write("Idade: ");
            dado1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("\nDados da segunda pessoa:");
            Console.Write("Nome: ");
            dado2.nome = Console.ReadLine();
            Console.Write("Idade: ");
            dado2.idade = int.Parse(Console.ReadLine());

            string nome = calculoIdade (dado1.idade, dado2.idade, dado1.nome, dado2.nome);
            Console.WriteLine("\nPessoa Mais Velha: " + nome);
        }
        static string calculoIdade(int a, int b, string nome1, string nome2)
        {
            string nomeMaisVelho;
            if (a > b)
            {
                nomeMaisVelho = nome1;
            }
            else
            {
                nomeMaisVelho = nome2;
            }
            return nomeMaisVelho;
        }
    }
}
