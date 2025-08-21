using System;

namespace Salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o numero do seu ID: ");
            int ID = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite as horas trabalhadas: ");
            double horasTrabalhadas = double.Parse(System.Console.ReadLine());

            System.Console.Write("Digite quanto voce ganha por hora trabalhada: ");
            double precoHora = double.Parse(System.Console.ReadLine());

            double salario = horasTrabalhadas * precoHora;

            System.Console.WriteLine($"Numero: {ID}");
            System.Console.WriteLine($"Salario = R${salario}");

        }
    }
}