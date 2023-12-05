
namespace InterfaceUsuario
{
    using Compartilhado;
    using ConsoleInteraction;

    public class GeradorDeInterface
    {
        ProductsList productsList = new ProductsList();
        public void Gerar()
        {
            Display.Greeting();

            while(true)
            {
                Display.Menu();
                string? choice = Console.ReadLine();
                Console.Clear();
                DetermineChoice(choice, productsList);
            }
        }

        static void DetermineChoice(string? choice, ProductsList productsList)
        {
            switch (choice)
            {
                case "1":                    
                    TryAddingProduct(productsList);
                    break;
                case "2":
                    Console.WriteLine("Digite o produto que você gostaria de remover:\n");
                    string productToRemove = Console.ReadLine();
                    productsList.RemoveProduct(productToRemove);
                    Console.WriteLine("Produto removido.");
                    Display.Products(productsList.GetList(), "Nova lista após adição:\n");
                    break;
                case "3":
                    Display.Products(productsList.GetList(), "Lista completa de produtos: \n");
                    break;
                case "4":
                    Display.Products(productsList.GetListInAlfabeticalOrder(), "Lista completa de produtos em ordem alfabética:\n");
                    break;
                case "5":
                    Console.Write("Digite a primeira letra:\n");
                    char letter = Receive.Letter();
                    Display.Products(productsList.GetProductsThatStartsWith(letter), $"Lista completa dos produtos que começam com {letter}:\n");
                    break;
                case "6":
                    Console.WriteLine("Programa encerrado.\n");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente");
                    break;
            }
        }

        private static void TryAddingProduct(ProductsList productsList)
        {
            string productToAdd = Receive.NonNullString("Digite o produto que você gostaria de adicionar:\n");
            VerifyIfProductExists(productToAdd, productsList);
        }
        private static void VerifyIfProductExists(string productToAdd, ProductsList productsList)
        {
            if(!productsList.GetList().Contains(productToAdd))
            {
                productsList.AddProduct(productToAdd);
                Console.WriteLine("Produto adicionado.");
                Display.Products(productsList.GetList(), "Nova lista após adição:\n");
            }
            else
            {
                Console.WriteLine("Um produto com o mesmo nome já existe. ");
            }
        }
    }
}
