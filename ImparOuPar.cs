using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.Write("Digite um numero: ");
            int numero = int.Parse(System.Console.ReadLine());

            if (numero % 2 == 0)
            {
                System.Console.WriteLine("Par");
            }
            else
            {
                System.Console.WriteLine("Impar");
            }
            
        }
    }
}