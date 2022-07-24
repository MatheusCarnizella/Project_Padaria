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
        public double Preco;

        public Produtos(string Produto, int Quantidade, double Preco)
        {
            this.Produto = Produto;
            this.Quantidade = Quantidade;
            this.Preco = Preco;
        }

        public void Exibir()
        {
            Console.WriteLine($"Nome do produto: {Produto}");
            Console.WriteLine($"Quantidade Disponivel: {Quantidade}");
            Console.WriteLine($"Preco do produto: {Preco}");
        }

        public void Exibir2()
        {

        }
    }
}
