using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_do_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            const double valorsemiva = 1000, txiva = 0.23;
            double valoriva, valorcomiva;
            valoriva = valorsemiva * txiva;
            valorcomiva = valoriva + valorsemiva;


            Console.WriteLine("O valor final do artigo é " + valorsemiva);
        }
    }
}
