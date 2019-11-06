using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory.OracleDriver
{
    //Fábrica Concreta
    public class OracleFactory : DBFactory
    {
        public override DBCommand CreateCommand()
        {
            return new OracleCommand();
        }

        public override DBConnection CreateConnection()
        {
            return new OracleConnection();
        }
    }
}
