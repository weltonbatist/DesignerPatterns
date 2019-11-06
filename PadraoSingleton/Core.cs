using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoSingleton
{
    public class Core
    {
        protected Core() { }

        private static Core _Instance;

        public static Core Instance()
        {
            if (_Instance is null)
            {
                _Instance = new Core();
            }

            return _Instance;
        }

        public string Ola()
        {
            return "Olá Amigos!";
        }

    }
}
