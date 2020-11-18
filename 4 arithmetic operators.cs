using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_operadores_aritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2;
            double soma, multiplicacao, subtracao, divisao;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Valor do n1: ");
            n1 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Valor do n2: ");
            n2 = double.Parse(Console.ReadLine());

            Console.WriteLine("");

            soma = n1 + n2;
            subtracao = n1 - n2;
            multiplicacao = n1 * n2;
            divisao = n1 / n2;

            Console.WriteLine("O resultado da soma é: " + soma + ".");
            Console.WriteLine("");
            Console.WriteLine("O resultado da subração é: " + subtracao + ".");
            Console.WriteLine("");
            Console.WriteLine("O resultado da multipicação é: " + multiplicacao + ".");
            Console.WriteLine("");
            Console.WriteLine("O resultado da divisao é: " + divisao + ".");
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
