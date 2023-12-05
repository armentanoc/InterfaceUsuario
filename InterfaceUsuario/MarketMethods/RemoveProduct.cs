using Compartilhado;
using ConsoleInteraction;
using InterfaceUsuario;

namespace MarketList.Operator.MarketMethods
{
    public class RemoveProduct
    {
        public static void TryRemovingProduct(ProductsList productsList)
        {
            Display.Products(productsList.GetList());
            string productToRemove = Receive.NonNullString("\nDigite o produto que você gostaria de remover:\n");
            productToRemove = Format.Product(productToRemove);

            try
            {
                if (ProductToRemoveExists(productToRemove, productsList))
                {
                    productsList.RemoveProduct(productToRemove);
                    Console.WriteLine("\nProduto removido.");
                    Display.Products(productsList.GetList(), "\nNova lista após adição:\n");
                }
                else
                {
                    throw new Exception("O produto não existe na lista.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n{ex.Message}");
            }
        }
        public static bool ProductToRemoveExists(string productToRemove, ProductsList productsList)
        {
            return productsList.GetList().Contains(productToRemove);
        }
    }
}