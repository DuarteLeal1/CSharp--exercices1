using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Valor_de_f
{
    class Program
    {
        static void Main(string[] args)
        {
            //Expressão matemática é f = y + (raiz quadrada |2x + 10|)
            //                                           2x
            
            double f, x, y;
            Console.WriteLine("Valor de y: ");
            y = double.Parse(Console.ReadLine());

            Console.WriteLine("Valor de x: ");
            x = double.Parse(Console.ReadLine());

            f = (y + Math.Sqrt(Math.Abs(2 * x + 10))) / 2 * x;

            Console.WriteLine(f);
            Console.ReadKey();

        }
    }
}
