using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    public abstract class Item
    {
        protected Item(int id, string nome, decimal preco)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public abstract Item Clone();

        public override string ToString()
        {
            return $"ID:{this.Id};Nome:{this.Nome};Preco:{this.Preco}";
        }

    }
}
