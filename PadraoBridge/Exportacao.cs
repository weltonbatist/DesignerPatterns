using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBridge
{
    //Abstracao
    public abstract class Exportacao
    {
        //Composição
        protected Implementor _Implemento;

        public Implementor Implementor
        {
            set { this._Implemento = value; }
        }

        public virtual void Exportar()
        {
            //Implementação por delegação
            _Implemento.Exportar();
        }
    }
}
