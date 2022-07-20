using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Project_Padaria.SRC;

namespace Project_Padaria
{
    internal class Program
    {
        enum MENU {Listagem = 1, Cadastro, Excluir, Sair = 9}
        static List <IInterface> produtos = new List <IInterface> ();
        static void Main(string[] args)
        {
            
            bool Saida = false;
            while (Saida == false)
            {
                Console.WriteLine("Escolha 9 para sair");
                int digite = int.Parse(Console.ReadLine());

                MENU menu = (MENU) digite;
                switch (menu)
                {
                    case MENU.Listagem:
                        break;
                    case MENU.Cadastro:
                        break;
                    case MENU.Excluir:
                        break;
                    case MENU.Sair:
                        Saida = true;
                        break;


                }
                Console.Clear();
            }
            
        }
    }
}
