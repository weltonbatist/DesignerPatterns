using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoSingleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Core core1 = Core.Instance();
            Core core2 = Core.Instance();

            //Aponto para a mesma posição de memória
            if (core1.Equals(core2))
            {
                Console.WriteLine(core1.Ola());
            }

            Console.ReadKey();
        }
    }
}
