using System;
using System.Formats.Asn1;

namespace AreaDoCirculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Informe o raio do circulo: ");
            double raio = double.Parse(System.Console.ReadLine());

            double pi = 3.14159;

            double AreaDoCirculo = pi * (raio * raio); 

            System.Console.WriteLine($"A area do circulo é de {AreaDoCirculo}");
        }
    }
}