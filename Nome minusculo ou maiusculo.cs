﻿using System;

namespace HelloWorld
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine($"Seu nome tem {nome.Length} caracteres");
                  
            string nomeMaiusculo = nome.ToUpper();
            Console.WriteLine($"Seu nome em letras maisculas: {nomeMaiusculo}");

            string nomeMinusculo = nome.ToLower();
            Console.WriteLine($"Seu nome em letras minusculas> {nomeMinusculo}");
           

            Console.ReadKey();
        }
    }
}
