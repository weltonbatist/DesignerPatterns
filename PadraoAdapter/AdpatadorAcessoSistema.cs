using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoAdapter
{
    public class AdpatadorAcessoSistema: AcessoLegado
    {
        private AcessoNovoSistema _AcessoNovoSistema = new AcessoNovoSistema();

        public override void Acesso()
        {
            _AcessoNovoSistema.AcessoNovo();
        }
    }
}
