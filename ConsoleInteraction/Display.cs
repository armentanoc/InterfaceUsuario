
namespace InterfaceUsuario
{
    public class Display
    {
        public static void Greeting()
        {
            Console.WriteLine("\nBem-vindo(a) ao sistema!");
            Thread.Sleep(1500);
            Console.Clear();
        }
        public static void Menu()
        {
            Console.WriteLine("\n---------- MARKET LIST ----------\n");
            Console.WriteLine("1 - Adicionar um produto");
            Console.WriteLine("2 - Remover um produto");
            Console.WriteLine("3 - Imprimir todos os produtos");
            Console.WriteLine("4 - Imprimir em ordem alfabética");
            Console.WriteLine("5 - Imprimir apenas os que começam com certa letra");
            Console.WriteLine("6 - Sair");
            Console.WriteLine("\nDigite a opção: ");
        }
        public static void Products(List<string> productsList, string prompt = "\nLista de Produtos: \n")
        {
            Console.WriteLine(prompt);
            foreach (var product in productsList)
            {
                Console.WriteLine(product);
            }
        }
    }
}
