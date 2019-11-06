using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PadraoPrototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Computador computadororiginal = new Computador(10, "Dell", 35000);
            Computador computadorcopia = (Computador)computadororiginal.Clone();

            Livro livrooriginal = new Livro(12, "Implementando DDD", 80);
            Livro livrocopia = (Livro)livrooriginal.Clone();

            Console.WriteLine($"Computador Original:{computadororiginal.ToString()}");
            Console.WriteLine($"Computador Copia:{computadorcopia.ToString()}");

            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Livro Original:{livrooriginal.ToString()}");
            Console.WriteLine($"Livro Copia:{livrooriginal.ToString()}");

            Console.ReadKey();


        }
    }
}
