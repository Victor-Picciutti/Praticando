using System;

namespace MediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();


            System.Console.WriteLine("Digite a sua primeira nota: ");
            int nota1 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite a sua segunda nota: ");
            int nota2 = int.Parse(System.Console.ReadLine());

            System.Console.WriteLine("Digite a sua terceira nota: ");
            int nota3 = int.Parse(System.Console.ReadLine());

            float MediaAluno = (nota1 + nota2 + nota3) / 3;

            if (MediaAluno >= 7)
            {
                System.Console.WriteLine($"Parabens {nome}, voce esta aprovado");
            }
            else if (MediaAluno < 7 && MediaAluno >= 5)
            {
                System.Console.WriteLine($"{nome}, voce esta de recuperaçao");
            }
            else
            {
                System.Console.WriteLine($"Infelizmente voce esta reprovado, boa sorte no proximo ano {nome}");
            }
            

        }
    }
}
