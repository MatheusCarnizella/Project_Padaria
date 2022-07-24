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
        enum MENU {Administrador = 1, Usuario, Sair = 9}
        static List <IInterface> produtos = new List <IInterface> ();
        static void Main(string[] args)
        {
            Console.WriteLine("SISTEMA PARA PADARIAS.");
            Console.WriteLine("(Pressione ENTER para continuar)");
            Console.ReadKey();
            Console.Clear();
            
            bool Saida = false;
            while (!Saida)
            {
                Console.WriteLine("Escolha o numero da opcao correspondende:");
                Console.WriteLine("");
                Console.WriteLine("1 - Modo Administrador\n2 - Usuario\n\n\n\n9 - Salvar e Fechar");
                Console.WriteLine("");
                int digite = int.Parse(Console.ReadLine());

                MENU menu = (MENU) digite;
                switch (menu)
                {
                    case MENU.Administrador:
                        Administrador();
                        break;
                    case MENU.Usuario:
                        Usuario();
                        break;
                    case MENU.Sair:
                        Saida = true;
                        break;
                }
                Console.Clear();
            }
            
        }
        enum ADMIN {Lista = 1, Cadastro, Excluir }
        static void Administrador()
        {
            Console.Clear();
            Console.WriteLine("- Sistema de administrador -");
            Console.WriteLine("");
            Console.WriteLine("1 - Listar Produtos\n2 - Cadastrar Produtos\n3 - Excluir.");
            Console.WriteLine("");
            int digite2 = int.Parse(Console.ReadLine());

            ADMIN admin = (ADMIN) digite2;
            switch (admin)
            {
                case ADMIN.Lista:
                    Console.Clear();
                    Console.WriteLine("Produtos cadastrados");
                    Console.WriteLine("");
                    int i = 0;
                    foreach (IInterface prod in produtos)
                    {
                        Console.WriteLine("ID: " + i);
                        Console.WriteLine("");

                        prod.Exibir();
                        i++;
                        Console.WriteLine("____________________");
                    }
                    Console.ReadLine();
                    break;
                case ADMIN.Cadastro:
                    Console.Clear();
                    Console.WriteLine("Cadastre um produto: ");
                    Console.WriteLine("Digite quantos produtos quer cadastrar: ");
                    Console.WriteLine("");
                    int q = int.Parse(Console.ReadLine());
                    for (int z = 0; z < q; z++)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite o produto a ser cadastrado: ");
                        string Produto = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Digite a quantidade disponivel do produto: ");  
                        int Quantidade = int.Parse(Console.ReadLine());
                        Console.WriteLine("");
                        Console.WriteLine("Digite o preco do produto: ");
                        double Preco = double.Parse(Console.ReadLine());

                        Produtos prod = new Produtos(Produto, Quantidade, Preco); 
                        produtos.Add(prod);
                    }
                    Console.WriteLine("Produto(s) cadastrados.");
                    break;
                case ADMIN.Excluir:
                    Console.Clear();
                    if (produtos.Count == 0)
                    {
                        Console.WriteLine("Nao ha produtos na lista");
                        Console.WriteLine("");
                    }
                    else
                    {
                        i = 0;
                        Console.WriteLine("Lista dos produtos: ");
                        foreach (IInterface prod in produtos)
                        {
                            Console.WriteLine("ID: " + i);
                            Console.WriteLine("");

                            prod.Exibir();
                            i++;
                            Console.WriteLine("____________________");
                        }

                        Console.WriteLine("Digite o ID do produto a ser removido: ");
                        int id = int.Parse(Console.ReadLine());
                        produtos.RemoveAt(id);
                        Console.Clear();
                        Console.WriteLine("Lista final: ");
                        Console.WriteLine("");
                        foreach (IInterface prod in produtos)
                        {
                            Console.WriteLine("ID: " + id);
                            Console.WriteLine("");

                            prod.Exibir();
                            id++;
                            Console.WriteLine("____________________");
                        }
                        Console.WriteLine("Feito...");
                    }
                    break;
            }

            Console.ReadLine();
        }
        enum USER {Comprar = 1, Pagar}
        static List<IInterface> carrinho = new List<IInterface>();
        static void Usuario()
        {           
            Console.Clear();
            Console.WriteLine("- Sistema de administrador -");
            Console.WriteLine("");
            Console.WriteLine("1 - Comprar\n2 - Pagar.");
            Console.WriteLine("");
            int digite3 = int.Parse(Console.ReadLine());

            USER usuario= (USER)digite3;
            switch (usuario)
            {
                case USER.Comprar:
                    break;
                case USER.Pagar:
 
                    break;
            }
        }

    }    
}
