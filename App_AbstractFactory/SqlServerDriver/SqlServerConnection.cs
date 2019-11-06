using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory
{
    //Produto Concreto
    public class SqlServerConnection : DBConnection
    {
        public override void Close()
        {
            Console.WriteLine("SqlServerConnection Fecha conexão");
        }

        public override void Open()
        {
            Console.WriteLine("SqlServerConnection Abre conexão");
        }
    }
}
