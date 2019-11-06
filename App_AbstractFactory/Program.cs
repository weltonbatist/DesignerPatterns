using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem padrão 
            //var con = new SqlServerConnection();
            //con.Open();

            //var command = new SqlServerCommand();
            //command.Execute();

            //con.Close();

            //Com o padrão: Olha só como é lindo, vc pode mudar o driver

            //DBFactory fabrica = new SqlServerFactory();

            DBFactory fabrica = new SqlServerFactory();


            var con = fabrica.CreateConnection();
            con.Open();

            var command = fabrica.CreateCommand();
            command.Execute();
            command.ExecutaAcaoEspecifica();

            con.Close();

            Console.ReadKey();
        }
    }
}
