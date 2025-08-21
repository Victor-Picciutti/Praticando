using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o codigo do primeiro item: ");
            int codigo1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a quantidade do primeiro item: ");
            int quantidade1 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Qual o valor desse item: ");
            double valorUnitario1 = double.Parse(System.Console.ReadLine());

            Console.Write("Digite o codigo do segundo item: ");
            int codigo2 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Digite a quantidade do segundo item: ");
            int quantidade2 = int.Parse(System.Console.ReadLine());

            System.Console.Write("Qual o valor desse item: ");
            double valorUnitario2 = double.Parse(System.Console.ReadLine());

            double valorTotal1 = quantidade1 * valorUnitario1;
            double valorTotal2 = quantidade2 * valorUnitario2;
            double valorTotal = valorTotal1 + valorTotal2;

            System.Console.WriteLine($"Valor a pagar = R${valorTotal}");

        }
    }
}