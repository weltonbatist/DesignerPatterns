using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            AcessoLegado legado = new AdpatadorAcessoSistema();
            legado.Acesso();

            Console.ReadKey();
        }
    }
}
