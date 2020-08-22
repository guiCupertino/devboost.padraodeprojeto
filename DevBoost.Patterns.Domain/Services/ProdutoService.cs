using DevBoost.Patterns.Domain.Commands;
using DevBoost.Patterns.Domain.Repositories;

namespace DevBoost.Patterns.Domain.Services
{
    public class ProdutoService : IServiceProduto
    {
        private readonly IRepositoryProduto _produtoRepository;

        public ProdutoService(IRepositoryProduto repositoryProduto)
        {
            _produtoRepository = repositoryProduto;
        }
        
        public void Incluir(ProdutoCommand  produto)
        {
            _produtoRepository.Incluir(produto);
        }

        public void Alterar(ProdutoCommand produto)
        {
            _produtoRepository.Alterar(produto);
        }

        public void Deletar(int idProduto)
        {
            _produtoRepository.Deletar(idProduto);
        }        
    }
}
