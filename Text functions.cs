using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funções_de_Texto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visual Studio".Replace("i","y"));
            Console.WriteLine("Visual Studio".Replace("V", "Y"));
            Console.WriteLine("Visual Studio".Replace("i","y"));
            Console.WriteLine("Lisboa" + " não é a capital da Alemanha.");
            Console.WriteLine("Coimbra".ToUpper());
            Console.WriteLine("PSI".ToLower());
            Console.WriteLine("");
            Console.WriteLine("Visual Studio".Substring(6,7));
            Console.WriteLine("Porto tricampeão tricampeão".IndexOf("tri"));
            Console.WriteLine("Porto tricampeão tricampeão".LastIndexOf("tri"));
            Console.WriteLine("Porto tricampeão".IndexOf("T", StringComparison.CurrentCultureIgnoreCase));

            string conteudo = "          sol          ";
            conteudo = conteudo.TrimEnd();
            Console.Write(conteudo);
            Console.ReadKey();
        }
    }
}
