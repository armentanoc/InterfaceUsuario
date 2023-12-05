
namespace InterfaceUsuario
{
    public class Display
    {
        public static void Greeting()
        {
            Console.WriteLine("\nBem-vindo ao sistema!\n");
        }
        public static void Menu()
        {
            Console.WriteLine("---------- MENU ----------\n");
            Console.WriteLine("1 - Adicionar um produto");
            Console.WriteLine("2 - Remover um produto");
            Console.WriteLine("3 - Imprimir todos os produtos");
            Console.WriteLine("4 - Imprimir em ordem alfabética");
            Console.WriteLine("5 - Imprimir apenas os que começam com certa letra");
            Console.WriteLine("\nQualquer outra opção: sair");
        }
        public static void Products(List<string> productsList)
        {
            Console.WriteLine("Produtos:\n");
            foreach (var product in productsList)
            {
                Console.WriteLine(product);
            }
        }
    }
}
