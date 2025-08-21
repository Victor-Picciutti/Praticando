using System;

namespace Bhaskara
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro valor");
            int a = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Digite o segundo valor");
            int b = int.Parse(System.Console.ReadLine());

            Console.WriteLine("Digite o terceiro valor");
            int c = int.Parse(System.Console.ReadLine());

            
            int delta = (b * b) - 4 * a * c;
            

            if(delta < 0)
            {
                System.Console.WriteLine("Opercação invalida");
            }
            else
            {
                double raizDelta = Math.Sqrt(delta);
                double resultado1 = (-b + raizDelta) / (2 * a);
                double resultado2 = (-b - raizDelta) / (2 * a);


            System.Console.WriteLine($" As raizes da equaçao {a}X² {b}X - {c} são: ");
            System.Console.WriteLine($"X1 = {resultado1}");
            System.Console.WriteLine($"X2 = {resultado2}");

            }

        }
    }
}