using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            //soma, adição
            //calculadora

            double num1, num2;
            char tipo;

            Console.WriteLine("Qual é o tipo de operação? ");
            tipo = char.Parse(Console.ReadLine());

            Console.WriteLine("Numero 1: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Numero 2: ");
            num2 = double.Parse(Console.ReadLine());

            switch tipo
            {
                case '+' :
                Console.WriteLine(num1 + num2);
                    break;

                case '-' :
                    Console.WriteLine(num1 - num2);
            }
        }
    }
}
