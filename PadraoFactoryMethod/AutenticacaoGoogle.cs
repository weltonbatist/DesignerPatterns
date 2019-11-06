using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    public class AutenticacaoGoogle : Autenticacao
    {
        public override void Autenticar()
        {
            Console.WriteLine("Autenticação pelo google");
        }
    }
}
