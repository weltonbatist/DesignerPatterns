using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sem padrão

            //var CarroPasseio = new Veiculo("Carro Passeio");
            //CarroPasseio["motor"] = "240CV";
            //CarroPasseio["pneus"] = "4";
            //CarroPasseio["portas"] = "4";
            //CarroPasseio.Mostrar();

            //var Moto = new Veiculo("Moto");
            //Moto["motor"] = "50CV";
            //Moto["pneus"] = "2";
            //Moto["portas"] = "0";
            //Moto.Mostrar();
            //Console.ReadKey();

            // Com o Padrão

            Director director = new Director();

            VeiculoBuilder builderCarro = new CarroBuilder();
            director.Construct(builderCarro);
            builderCarro.Veiculo.Mostrar();

            VeiculoBuilder builderMoto = new MotoBuilder();
            director.Construct(builderMoto);
            builderMoto.Veiculo.Mostrar();

            Console.ReadKey();
            
        }
    }
}
