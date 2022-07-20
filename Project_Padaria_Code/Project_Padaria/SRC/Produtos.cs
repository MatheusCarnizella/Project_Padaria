using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Padaria.SRC;

namespace Project_Padaria.SRC
{
    internal class Produtos : IInterface
    {
        public string Produto;
        public int Quantidade;
        public string Sortido;
        public string Embalado;

        public Produtos(string Produto, int Quantidade, string Sortido, string Embalado)
        {
            this.Produto = Produto;
            this.Quantidade = Quantidade;
            this.Sortido = Sortido;
            this.Embalado = Embalado;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome do produto: {Produto}");
            Console.WriteLine($"Quantidade Disponivel: {Quantidade}");
            Console.WriteLine($"O produto é {Sortido}");
            Console.WriteLine($"O produto é {Embalado}");
        }
    }
}
