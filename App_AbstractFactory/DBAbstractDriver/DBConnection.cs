using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory
{
    //Produto abstrato
    public abstract class DBConnection
    {
        public abstract void Open();

        public abstract void Close();
    }
}
