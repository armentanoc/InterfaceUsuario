using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceUsuario
{
    using Compartilhado;
    internal class GeradorDeInterface
    {
        public void Gerar()
        {
            Console.WriteLine("Bem-vindo ao sistema");
            ListaDeProdutos listaDeProdutos = new ListaDeProdutos();
            
            bool encerrou = false;

            while(!encerrou)
            {
                imprimirMenu();
                Console.Write("Digite sua opção: ");
                int op = ReadInteger();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o produto que você gostaria de adicionar");
                        string produtoParaAdicionar = Console.ReadLine();
                        listaDeProdutos.AdicionarProduto(produtoParaAdicionar);
                        Console.WriteLine("Produto adicionado.");
                        Console.WriteLine("Nova lista após adição:");
                        imprimirProdutos(listaDeProdutos.ListarProdutos());
                        break;
                    case 2:
                        Console.WriteLine("Digite o produto que você gostaria de remover");
                        string produtoParaRemover = Console.ReadLine();
                        listaDeProdutos.RemoverProduto(produtoParaRemover);
                        Console.WriteLine("Produto removido.");
                        Console.WriteLine("Nova lista após adição:\n");
                        imprimirProdutos(listaDeProdutos.ListarProdutos());
                        break;
                    case 3:
                        Console.WriteLine("Lista completa de produtos:\n");
                        imprimirProdutos(listaDeProdutos.ListarProdutos());
                        break;
                    case 4:
                        Console.WriteLine("Lista completa de produtos em ordem alfabética:\n");
                        imprimirProdutos(listaDeProdutos.ListarProdutosOrdemAlfabetica());
                        break;
                    case 5:
                        Console.Write("Digite a primeira letra: ");
                        char letra = ReadChar();
                        Console.WriteLine($"Lista completa dos produtos que começam com {letra}:\n");
                        imprimirProdutos(listaDeProdutos.ListarProdutosQueComecamComALetra(letra));
                        break;
                    default:
                        encerrou = true;
                        break;

                }
                
            }

        }


        private char ReadChar()
        {
            bool validLetter = false;
            while (!validLetter)
            {
                string txt = Console.ReadLine();
               
                validLetter = (txt.Length == 1) && Char.IsLetter(txt[0]);
                if (validLetter)
                    return txt.ToUpper()[0];
                Console.WriteLine("Digite uma entrada válida");
            }

            return '0';
        }

        private int ReadInteger()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                validNumber = int.TryParse(Console.ReadLine(), out int number);
                if (validNumber)
                    return number;
                Console.WriteLine("Digite uma entrada válida");
            }

            return -1;
        }

        private void imprimirProdutos(List<string> produtosListados)
        {
            foreach (var produtos in produtosListados)
            {
                Console.WriteLine(produtos);
            }
        }

        private void imprimirMenu()
        {
            Console.WriteLine("---------- MENU ----------");
            Console.WriteLine("1 - Adicionar um produto");
            Console.WriteLine("2 - Remover um produto");
            Console.WriteLine("3 - Imprimir todos os produtos");
            Console.WriteLine("4 - Imprimir em ordem alfabética");
            Console.WriteLine("5 - Imprimir apenas os que começam com certa letra");
            Console.WriteLine("Qualquer outra opção: sair");
        }
    }
}
