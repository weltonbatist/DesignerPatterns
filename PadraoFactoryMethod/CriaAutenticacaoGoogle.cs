using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    public class CriaAutenticacaoGoogle : ICreator
    {
        public Autenticacao CriaInstancia()
        {
            return new AutenticacaoGoogle();
        }
    }
}
