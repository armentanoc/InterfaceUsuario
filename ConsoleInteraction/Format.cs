
namespace ConsoleInteraction
{
    public class Format
    {
        public static string Product(string product)
        {
            product = product.ToLower();
            product = char.ToUpper(product[0]) + product.Substring(1);
            return product;
        }
    }
}
