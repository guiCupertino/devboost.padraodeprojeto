using DevBoost.Patterns.Domain.Queries;
using DevBoost.Patterns.Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace DevBoost.Patterns.Repository
{
    public class RepositorioProdutoGet : IRepositorioProdutoGet
    {
        private ProdutoQueryContext contexto;
        public RepositorioProdutoGet()
        {
            this.contexto = new ProdutoQueryContext();
        }

        public List<ProdutoQuery> Obter()
        {
            return contexto.Produtos.ToList();
        }
    }
}
