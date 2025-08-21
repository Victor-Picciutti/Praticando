using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor desejado");
            int valor = int.Parse(System.Console.ReadLine());

            int valor1 = valor / 100;
            int resto = valor % 100;
            int valor2 = resto / 50;
            int resto1 = resto % 50;
            int valor3 = resto1 / 20;
            int resto2 = resto1 % 20;
            int valor4 = resto2 / 10;
            int resto3 = resto2 % 10;
            int valor5 = resto3 / 5;
            int resto4 = resto3 % 5;
            int valor6 = resto4 / 2;
            int resto5 = resto4 % 2;
            int valor7 = resto5 / 1;


            System.Console.WriteLine($"{valor1} nota(s) de R$100,00");
            System.Console.WriteLine($"{valor2} nota(s) de R$50,00");
            System.Console.WriteLine($"{valor3} nota(s) de R$20,00");
            System.Console.WriteLine($"{valor4} nota(s) de R$10,00");
            System.Console.WriteLine($"{valor5} nota(s) de R$5,00");
            System.Console.WriteLine($"{valor6} nota(s) de R$2,00"); 
            System.Console.WriteLine($"{valor7} nota(s) de R$1,00"); 
        }
    }
}