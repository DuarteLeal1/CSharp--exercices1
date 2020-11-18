using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplicação_de_2_números
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1;
            double numero2;
            double multiplicacao;
            Console.WriteLine("\n Escreva um número inteiro: ");
            numero1 = Double.Parse(Console.ReadLine());
            Console.Write("\nEscreva um número inteiro: ");
            numero2 = Double.Parse(Console.ReadLine());
            multiplicacao = numero1 * numero2;
            Console.WriteLine("\n O valor da multiplicação dos dois numeros é {0}", multiplicacao, ".");
            Console.ReadKey();
        }
    }
}
