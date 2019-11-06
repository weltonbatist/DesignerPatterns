using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory
{
    //Produto abstrato
    public abstract class DBCommand
    {
        public abstract DBResult Execute();

        public abstract void ExecutaAcaoEspecifica();
    }
}
