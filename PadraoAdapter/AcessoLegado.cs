using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAdapter
{
    public class AcessoLegado
    {
        public virtual void Acesso()
        {
            Console.WriteLine("Acesso ao sistema legado");
        }
    }
}
