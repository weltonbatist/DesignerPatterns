using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<ICreator> creators = new List<ICreator>
            {
                new CriarAutenticacaoFacebook(),
                new CriaAutenticacaoGoogle()
            };

            foreach (var criador in creators)
            {
                Autenticacao autenticacao = criador.CriaInstancia(); //Factory Method
                autenticacao.Autenticar();
            }

            Console.ReadKey();
        }
    }
}
