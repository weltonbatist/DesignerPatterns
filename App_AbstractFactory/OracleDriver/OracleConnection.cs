using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory.OracleDriver
{
    //Produto concreto
    public class OracleConnection : DBConnection
    {
        public override void Close()
        {
            Console.WriteLine("OracleConnection Close");
        }

        public override void Open()
        {
            Console.WriteLine("OracleConnection Open");
        }
    }
}
