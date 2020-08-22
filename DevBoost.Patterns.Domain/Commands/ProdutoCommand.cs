using System;
using System.Collections.Generic;
using System.Text;

namespace DevBoost.Patterns.Domain.Commands
{
    public class ProdutoCommand
    {
        public int IdProduto { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
    }
}
