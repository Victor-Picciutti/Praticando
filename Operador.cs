using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite o primeiro numero: ");
            int n1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite o segundo numero: ");
            int n2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Escolha entre esses operadores: +, -, / ou *");
            char operador = char.Parse(System.Console.ReadLine());

            double resultado = 0;


            switch (operador)
            {
                case '+':
                    resultado = n1 + n2;
                    break;

                case '-':
                    resultado = n1 - n2;
                    break;

                case '/':
                    resultado = n1 / n2;
                    break;

                case '*':
                    resultado = n1 * n2;
                    break;

                 default:
                    Console.WriteLine("Operador inválido!");
                    return;
            }
            System.Console.WriteLine($"{resultado}");
        }
    }
}
