using Compartilhado;
using ConsoleInteraction;
using InterfaceUsuario;

namespace MarketList.Operator.MarketMethods
{
    public class FilterProducts
    {
        public static void ByLetter(ProductsList productsList)
        {
            char letter = Receive.NonNullChar("Digite a primeira letra:\n");
            List<string> productsThatStarsWithLetter = productsList.GetProductsThatStartsWith(letter);

            if (productsThatStarsWithLetter.Count == 0)
            {
                Console.WriteLine($"\nNão existem produtos que começam com a letra {letter}. ");
            }
            else
            {
                Display.Products(productsThatStarsWithLetter, $"\nLista completa dos produtos que começam com {letter}:\n");
            }
        }
    }
}