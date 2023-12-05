using Compartilhado;
using ConsoleInteraction;
using InterfaceUsuario;

namespace MarketList.Operator.MarketMethods
{
    public class AddProduct
    {
        public static void TryAddingProduct(ProductsList productsList)
        {
            Display.Products(productsList.GetList());
            string productToAdd = Receive.NonNullString("\nInforme o nome do produto que deseja adicionar: ");
            productToAdd = Format.Product(productToAdd);

            try
            {
                if (ProductToAddDoesntExist(productToAdd, productsList))
                {
                    productsList.AddProduct(productToAdd);
                    Console.WriteLine("\nProduto adicionado.");
                    Display.Products(productsList.GetList(), "\nNova lista após adição:\n");
                }
                else
                {
                    throw new Exception("\nUm produto com o mesmo nome já existe.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static bool ProductToAddDoesntExist(string productToAdd, ProductsList productsList)
        {
            return !productsList.GetList().Contains(productToAdd);
        }
    }
}