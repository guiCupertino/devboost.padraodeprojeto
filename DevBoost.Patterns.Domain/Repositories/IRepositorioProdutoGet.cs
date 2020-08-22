using DevBoost.Patterns.Domain.Commands;
using DevBoost.Patterns.Domain.Queries;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Patterns.Domain.Repositories
{
    public interface IRepositorioProdutoGet
    {
        List<ProdutoQuery> Obter();
    }
}
