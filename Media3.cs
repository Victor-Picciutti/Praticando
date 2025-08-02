using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite sua N1: ");
            double n1 = double.Parse(System.Console.ReadLine());
            Console.Write("Digite sua N2: ");
            double n2 = double.Parse(System.Console.ReadLine());
            Console.Write("Digite sua N3: ");
            double n3 = double.Parse(System.Console.ReadLine());
            Console.Write("Digite sua N4: ");
            double n4 = double.Parse(System.Console.ReadLine());

            double pesoN1 = n1 * 2;
            double pesoN2 = n2 * 3;
            double pesoN3 = n3 * 4;
            double pesoN4 = n4 * 1;

            double media = (pesoN1 + pesoN2 + pesoN3 + pesoN4) / 10;
            double mediaExame = 0;

            if (media >= 7)
            {
                System.Console.WriteLine("Aluno aprovado!");
                System.Console.WriteLine($"Media final: {media}");
            }
            else if (media >= 5 && media <= 6.9)
            {
                System.Console.WriteLine($"Media: {media}");
                System.Console.WriteLine("Aluno em exame!");
                System.Console.Write("Qual foi sua nota no exame de recuperaçao: ");
                double n5 = double.Parse(System.Console.ReadLine());
                mediaExame = (media + n5) / 2;
            }
            if (mediaExame >= 7)
            {
                System.Console.WriteLine("Aluno Aprovado!");
                System.Console.WriteLine($"Media final {mediaExame}");
            }
            else
            {
                System.Console.WriteLine($"Media final: {mediaExame}");
                System.Console.WriteLine("Aluno reprovado!");
            }
            
        }
    }
}