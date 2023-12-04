
namespace Compartilhado
{
    public class ListaDeProdutos
    {
        private List<string> produtos = new List<string>()
            {
                "Doce de leite",
                "Leite",
                "Goiabada",
                "Suco de uva",
                "Iogurte"
            };

        public List<string> ListarProdutos()
        {
            return produtos;
        }

        public void AdicionarProduto(string produto)
        {
            produtos.Add(produto);  
        }

        public void RemoverProduto(string produto)
        {
            if(produtos.Contains(produto))
                produtos.Remove(produto);
            
        }

        public List<string> ListarProdutosOrdemAlfabetica()
        {
            return produtos.Order().ToList();
        }

        public List<string> ListarProdutosQueComecamComALetra(char letra)
        {
            List<string> ret = new List<string>();
            foreach(var produto in  produtos)
            {
                if (produto.ToUpper().StartsWith(letra))
                {
                    ret.Add(produto);
                }
            }

            return ret;
        }
    }
}
