using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory
{
    //Fábrica Abstrata
    public abstract class DBFactory
    {
        public abstract DBConnection CreateConnection();

        public abstract DBCommand CreateCommand();
        
    }
}
