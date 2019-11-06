using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory
{
    //Fabrica concreta
    public class SqlServerFactory : DBFactory
    {
        public override DBCommand CreateCommand()
        {
            return new SqlServerCommand();
        }

        public override DBConnection CreateConnection()
        {
            return new SqlServerConnection();
        }
    }
}
