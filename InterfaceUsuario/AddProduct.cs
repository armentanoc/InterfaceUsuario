using Compartilhado;
using ConsoleInteraction;

namespace InterfaceUsuario
{
    public class AddProduct
    {
        public static void TryAddingProduct(ProductsList productsList)
        {
            Display.Products(productsList.GetList());
            string productToAdd = Receive.NonNullString("\nDigite o produto que você gostaria de adicionar:\n");
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