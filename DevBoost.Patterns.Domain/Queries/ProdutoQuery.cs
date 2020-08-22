using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Patterns.Domain.Queries
{
    public class ProdutoQuery
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
