using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            float z;

            Console.WriteLine("Valor inteiro para x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Valor inteiro para y");
            y = int.Parse(Console.ReadLine());

            y = (x % y);

            if (y == 0)
            {
                Console.WriteLine("O y é multiplo de x");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("O y não é multiplo de x");
                Console.ReadLine();
            }
        }
    }
}
