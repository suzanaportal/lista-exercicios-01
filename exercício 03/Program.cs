using System;

namespace Exercicio03
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Por favor, digite o valor do primeiro produto.");
            string? valorProduto01 = Console.ReadLine();
            Console.WriteLine("Por favor, agora, digite o valor do 2º produto.");
            string? valorProduto02 = Console.ReadLine();
            Console.WriteLine("Por favor, digite o valor do 3º produto.");
            string? valorProduto03 = Console.ReadLine();
            double produto01 = Convert.ToDouble(valorProduto01);
            double produto02 = Convert.ToDouble(valorProduto02);
            double produto03 = Convert.ToDouble(valorProduto03);
            if (produto01 < produto02 && produto01 < produto03)
            {
                Console.WriteLine("Escolha o produto 01");
            }
else if (produto02 < produto03 && produto02 < produto03)
            {
                Console.WriteLine("Escolha produto 02");
            }
            else
            {
                Console.WriteLine("Escolha produto 03");
            }
        }
    }
}