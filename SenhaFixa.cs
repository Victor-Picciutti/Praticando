using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira a senha: ");
            int senha = int.Parse(System.Console.ReadLine());

            if (senha != 2002)
            {
                System.Console.WriteLine("Senha invalida!");
            }
            else
            {
                System.Console.WriteLine("Acesso permitido!");
            }
        }
    }
}