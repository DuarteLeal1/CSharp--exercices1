using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler dois numeros inteiros, x e y, e mostrar a divisão e o resto da divisão inteira entre eles. 
            //Se o valor  de Y for igual a zero deverá aparecer a mensagem "Não há divisão por zero.".

            int x, y;
            float z;
            x = 6;
            y = 7;
            z = (x % y);
            if (z == 0)
            {
                Console.WriteLine("Há divisão por zero");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Não há divisão por zero");
                Console.ReadKey();
            }
            


        }
    }
}
