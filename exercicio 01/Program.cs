using System;

namespace Exercicio01
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Por favor, digite a 1ª nota.");
string? textoNota01 = Console.ReadLine();
Console.WriteLine("Por favor, digite a 2ª nota.");
string? textoNota02 = Console.ReadLine();
double nota01 = Convert.ToDouble(textoNota01);
double nota02 = Convert.ToDouble(textoNota02);
double media = (nota01 + nota02) /2;
if (media >=     7) 
{
    Console.WriteLine("Aprovado com sucesso! Parabéns!");
}
else if (media <7)
{
Console.WriteLine("Infelizmente você não atingiu a média necessária.");
}
else
Console.WriteLine("Você não digitou os dados corretamente.");
        }
    }
}