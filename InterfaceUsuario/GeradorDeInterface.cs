
namespace InterfaceUsuario
{
    using Compartilhado;
    using ConsoleInteraction;

    internal class GeradorDeInterface
    {

        ListaDeProdutos productsList = new ListaDeProdutos();
        public void Gerar()
        {
            Display.Greeting();

            while(true)
            {
                Display.Menu();
                Console.Write("Digite sua opção: ");
                int op = Receive.IntNumber();

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Digite o produto que você gostaria de adicionar");
                        string produtoParaAdicionar = Console.ReadLine();
                        productsList.AdicionarProduto(produtoParaAdicionar);
                        Console.WriteLine("Produto adicionado.");
                        Console.WriteLine("Nova lista após adição:");
                        Display.Products(productsList.GetList());
                        break;
                    case 2:
                        Console.WriteLine("Digite o produto que você gostaria de remover");
                        string produtoParaRemover = Console.ReadLine();
                        productsList.RemoverProduto(produtoParaRemover);
                        Console.WriteLine("Produto removido.");
                        Console.WriteLine("Nova lista após adição:\n");
                        Display.Products(productsList.GetList());
                        break;
                    case 3:
                        Console.WriteLine("Lista completa de produtos:\n");
                        Display.Products(productsList.GetList());
                        break;
                    case 4:
                        Console.WriteLine("Lista completa de produtos em ordem alfabética:\n");
                        Display.Products(productsList.GetListInAlfabeticalOrder());
                        break;
                    case 5:
                        Console.Write("Digite a primeira letra: ");
                        char letter = Receive.Letter();
                        Console.WriteLine($"Lista completa dos produtos que começam com {letter}:\n");
                        Display.Products(productsList.ListarProdutosQueComecamComALetra(letter));
                        break;
                    case 6:
                        Console.WriteLine("Programa encerrado.");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente");
                        break;

                }
                
            }

        }
    }
}
