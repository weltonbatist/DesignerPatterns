using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory
{
    //Produto Concreto
    public class SqlServerCommand : DBCommand
    {
        public override void ExecutaAcaoEspecifica()
        {
            Console.WriteLine("SqlServerCommand ExecutaAcaoEspecifica");
        }

        public override DBResult Execute()
        {
            Console.WriteLine("SqlServerCommand Executa");
            return new SqlServerResult();
        }
    }
}
