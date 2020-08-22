using DevBoost.Patterns.Domain.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Patterns.Domain.Repositories
{
    public interface IRepositoryProduto
    {
        void Incluir(ProdutoCommand produto);
        void Alterar(ProdutoCommand produto);
        void Deletar(int idProduto);
    }
}
