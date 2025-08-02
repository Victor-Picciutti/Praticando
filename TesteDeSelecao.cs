using System;

namespace TesteDeSelecao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de A: ");
            int A = int.Parse(System.Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            int B = int.Parse(System.Console.ReadLine());

            Console.Write("Digite o valor de C: ");
            int C = int.Parse(System.Console.ReadLine());

            Console.Write("Digite o valor de D: ");
            int D = int.Parse(System.Console.ReadLine());

            if (B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                System.Console.WriteLine("Valores aceitos");
            }
            else
            {
                System.Console.WriteLine("Valores nao aceitos");
            }

        }
    }
}