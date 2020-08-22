using DevBoost.Patterns.Domain.Commands;
using DevBoost.Patterns.Domain.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace DevBoost.Patterns.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IServiceProduto _produtoService;
        private readonly IRepositorioProdutoGet _repositorioProdutoGet;

        public ProdutoController(IServiceProduto produtoService, 
                                 IRepositorioProdutoGet repositorioProdutoGet)
        {
            _produtoService = produtoService;
            _repositorioProdutoGet = repositorioProdutoGet;
        }

        [HttpGet]
        [Route("obter")]
        public IActionResult Get()
        {
            return Ok(_repositorioProdutoGet.Obter());
        }

        [HttpPost]
        [Route("incluir")]
        public IActionResult Post(ProdutoCommand produto)
        {
            _produtoService.Incluir(produto);
            return Ok();
        }

        [HttpPut]
        [Route("alterar")]
        public IActionResult Put(ProdutoCommand produto)
        {
            _produtoService.Alterar(produto);
            return Ok();
        }

        [HttpDelete]
        [Route("deletar")]
        public IActionResult Delete(int idProduto)
        {
            _produtoService.Deletar(idProduto);
            return Ok();
        }

    }
}