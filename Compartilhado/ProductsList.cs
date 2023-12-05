
namespace Compartilhado
{
    public class ProductsList
    {
        private List<string> products = new List<string>()
            {
                "Doce de leite",
                "Leite",
                "Goiabada",
                "Suco de uva",
                "Iogurte"
            };

        public List<string> GetList()
        {
            return products;
        }

        public void AddProduct(string newProduct)
        {
            products.Add(newProduct);  
        }

        public bool RemoveProduct(string productToRemove)
        {
            return products.Remove(productToRemove);
        }

        public List<string> GetListInAlfabeticalOrder()
        {
            return products.Order().ToList();
        }

        public List<string> GetProductsThatStartsWith(char letter)
        {
            List<string> productsWithLetter = new List<string>();

            foreach(var product in products)
            {
                if (product.ToUpper().StartsWith(letter))
                {
                    productsWithLetter.Add(product);
                }
            }

            return productsWithLetter;
        }
    }
}
