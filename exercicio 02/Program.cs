﻿using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Por favor, digite o primeiro número.");
string? textoNumero01 = Console.ReadLine();
Console.WriteLine("Por favor digite o 2º número.");
string? textoNumero02 = Console.ReadLine();
Console.WriteLine("Por favor, digite o 3º número.");
string? textoNumero03 = Console.ReadLine();
int numero01 = Convert.ToInt32(textoNumero01);
int numero02 = Convert.ToInt32(textoNumero02);
int numero03 = Convert.ToInt32(textoNumero03);
int maior = 0;
if (numero01 > numero02) 
{
    if (numero01 > numero03)
    {
        maior = mumero01;
    }
    else
    {
        maior= numero03;
    }
    else
}

        }
    }
}