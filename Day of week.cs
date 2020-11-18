using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nº entre 1 a 7:");
            char dia = char.Parse(Console.ReadLine());
            switch (dia)
            {
                case '1':
                    Console.WriteLine("Domingo");
                    break;
                
                case '2':
                    Console.WriteLine("Segunda");
                    break;
                
                case '3':
                    Console.WriteLine("Terça");
                    break;

                case '4':
                    Console.WriteLine("Quarta");
                    break;

                case '5':
                    Console.WriteLine("Quinta");
                    break;

                case '6':
                    Console.WriteLine("Sexta");
                    break;

                case '7':
                    Console.WriteLine("Sábado");
                    break;

                default:
                    Console.WriteLine("Oh puto estupido, é para meteres de 1 a 7 não sejas parvo pah");
                    break;
            }
            Console.ReadKey();
        }
    }
}
