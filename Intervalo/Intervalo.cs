using System;

namespace Intervalo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            double n = double.Parse(System.Console.ReadLine());

            if (n >= 0 && n <= 25)
            {
                System.Console.WriteLine("Intervalo {0,25}");
            }
            else if (n > 25 && n <= 50)
            {
                System.Console.WriteLine("Intervalo {25,50}");
            }
            else if (n >= 75 && n <= 100)
            {
                System.Console.WriteLine("Inervalo {75,100}");
            }
            else
            {
                System.Console.WriteLine("Fora do intervalo");
            }
        }
    }
}