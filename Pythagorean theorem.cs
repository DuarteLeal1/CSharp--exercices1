using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teorema_de_pitágoras
{
    class Program
    {
        static void Main(string[] args)
        {
            double h, c1, c2;
            Console.WriteLine("Insira o valor dos dois catetos: ");
            c1 = double.Parse(Console.ReadLine());
            c2 = double.Parse(Console.ReadLine());
            h = Math.Sqrt(Math.Pow(c1, 2) + Math.Pow(c2, 2));
            Console.WriteLine("A hipotenusa tem o valor de " + h + ".");
            Console.ReadKey();
        }
    }
}
