using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Padaria.SRC
{
    internal class Carrinho : IInterface
    {
        public int ID;
        public int deseja;
        public double valor;

        public Carrinho(int ID, int deseja, double valor)
        {
            this.ID = ID;
            this.deseja = deseja;
            this.valor = valor;
        }

        public void Exibir()
        {

        }

        public void Exibir2()
        {
            Console.WriteLine($"ID do produto: {ID}");
            Console.WriteLine($"Quantidade desejada: {deseja}");
            Console.WriteLine($"Valor final: {valor}");
        }
    }
}
