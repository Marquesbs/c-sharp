/*Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.*/
using System;

namespace ex1_estrutura_while
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha = 0;
            while(senha != ((int)2002))
            {
                senha = int.Parse(Console.ReadLine());
                if (senha != (int)2002)
                {
                    System.Console.WriteLine("Senha Inválida");
                }
                else
                {
                    System.Console.WriteLine("Acesso Permitido");
                }
            }            
        }
    }
}
