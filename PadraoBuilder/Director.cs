using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoBuilder
{
    public class Director
    {
        public void Construct(VeiculoBuilder veiculoBuilder)
        {
            veiculoBuilder.BuildMotor();
            veiculoBuilder.BuildPortas();
            veiculoBuilder.BuildPneus();
        }
    }
}
