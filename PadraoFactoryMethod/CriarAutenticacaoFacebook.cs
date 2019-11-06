using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    public class CriarAutenticacaoFacebook : ICreator
    {
        public Autenticacao CriaInstancia()
        {
            return new AutenticacaoFacebook();
        }
    }
}
