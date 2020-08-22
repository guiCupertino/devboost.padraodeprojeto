using DevBoost.Patterns.Domain.Commands;
using DevBoost.Patterns.Domain.Repositories;
using DevBoost.Patterns.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevBoost.Patterns.Repository
{
    public class ProdutoRepository : IRepositoryProduto
    {
        private ProdutoContext contexto; 
        public ProdutoRepository() 
        {
            this.contexto = new ProdutoContext(); 
        }        

        public void Alterar(ProdutoCommand produto)
        {
            contexto.Produtos.Update(produto); 
            contexto.SaveChanges();
        }

        public void Deletar(int idProduto)
        {
            var produto = contexto.Produtos.SingleOrDefault(p => p.IdProduto == idProduto);
            contexto.Produtos.Remove(produto);
            contexto.SaveChanges();
        }

        public void Incluir(ProdutoCommand produto)
        {
            contexto.Produtos.Add(produto);
            contexto.SaveChanges();
        }
    }

    

}
