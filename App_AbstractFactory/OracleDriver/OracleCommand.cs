using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_AbstractFactory.OracleDriver
{
    //Produto Concreto
    public class OracleCommand : DBCommand
    {
        public override DBResult Execute()
        {
            Console.WriteLine("OracleCommand Execute");
            return new OracleResult();
        }

        public override void ExecutaAcaoEspecifica()
        {
            Console.WriteLine("Oracle Acao especifica");
        }
    }
}
