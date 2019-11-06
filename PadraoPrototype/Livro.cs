using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    public class Livro: Item
    {
        public Livro(int id, string nome, decimal preco)
            : base(id, nome, preco)
        {
        }

        public override Item Clone()
        {
            //retorna copia de si mesmo
            return (Item)this.MemberwiseClone();
        }
    }
}
