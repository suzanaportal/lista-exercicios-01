using System;

namespace Exercicio02
{
    public class Program
    {
        public static void Main(string[] args)
        {
Console.WriteLine("Por favor, informe seu salário.");
string? salario = Console.ReadLine();
double salarioOriginal = Convert.ToDouble(salario);
double percentualReajuste = 0;
double novoSalario = 0;
double valorAumento = 0;
if (salarioOriginal < 2800)
{
    percentualReajuste = 0.2;
}
else if (salarioOriginal >= 2800 && salarioOriginal < 7000)
{
    percentualReajuste = 0.15;
}
else if (salarioOriginal >= 7000 && salarioOriginal < 15000)
{
percentualReajuste = 0.1;
}
else 
{
    percentualReajuste = 0.05;
}
valorAumento  = percentualReajuste*salarioOriginal;
novoSalario = valorAumento+salarioOriginal;
Console.WriteLine($"O salário original é {salarioOriginal}. O percentual de reajuste foi de  {percentualReajuste*100}. O valor real do aumento foi de {valorAumento}. O novo salário é de {novoSalario}.");
        }
    }
}