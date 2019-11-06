using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBridge
{
    public class ExportacaoDoc: Implementor
    {
        public override void Exportar()
        {
            Console.WriteLine("Exportando DOC");
        }
    }
}
