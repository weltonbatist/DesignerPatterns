using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Exportacao exp = new ExportacaoRefinada
            {
                Implementor = new ExportacaoPDF()
            };
            exp.Exportar();

            Console.ReadKey();
        }
    }
}
