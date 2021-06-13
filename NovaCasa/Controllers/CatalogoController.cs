
using Dominio.IRepositories;
using Historias.Catalogos;
using Microsoft.AspNetCore.Mvc;
using NovaCasa.Factories;
using NovaCasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaCasa.Controllers
{
    [ApiController]
    [Route("api/catalogos")]
    public class CatalogoController : ControllerBase
    {
        private readonly CriarCatalogo _criarCatalogo;
        private readonly ConsultarCatalogo _consultarCatalogo;
        private readonly AlterarCatalogo _alterarCatalogo;
        private readonly ExcluirCatalogo _excluirCatalogo;

        public CatalogoController(ICatalogoRepository catalogoRepository)
        {
            _criarCatalogo = new CriarCatalogo(catalogoRepository);
            _consultarCatalogo = new ConsultarCatalogo(catalogoRepository);
            _alterarCatalogo = new AlterarCatalogo(catalogoRepository);
            _excluirCatalogo = new ExcluirCatalogo(catalogoRepository);
        }

        [HttpPost("criar-catalogo")]
        public async Task<IActionResult> Criar([FromBody] CatalogoViewModel catalogoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "Os Campos São Obrigatorios" });
            }

            var catalogo = CatalogoFactory.MapearCatalogo(catalogoViewModel);
            await _criarCatalogo.Executar(catalogo);
            return Ok(new { mensagem = "Catalogo Criado com Sucesso" });
        }

        [HttpGet("listar-catalogos")]

        public async Task<IEnumerable<CatalogoViewModel>> Listar()
        {
            var listaDeCatalogos = await _consultarCatalogo.ListarTodosCatalogos();
            if (listaDeCatalogos == null)
            {
                return null;
            }
            var listaCatalogoVm = CatalogoFactory.MapearListaCatalogoViewModel(listaDeCatalogos);
            return listaCatalogoVm;
        }
        [HttpPut("alterar-catalogo")]
        public async Task<IActionResult> Alterar([FromBody] CatalogoViewModel catalogoViewModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(new { mensagem = "O campos são obrigatorios" });
            }

            try
            {
                var ccatalogo = CatalogoFactory.MapearCatalogo(catalogoViewModel);

                await _alterarCatalogo.Executar(catalogoViewModel.Id, ccatalogo);

                return Ok(new { mensagem = "Catalogo alterado com sucesso" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao alterar o catagolo" });
            }

        }
        [HttpDelete("excluir-catagolo/{id}")]
        public async Task<IActionResult> Excluir(int id)
        {
            try
            {
                await _excluirCatalogo.Executar(id);
                return Ok(new { mensagem = "Catalogo excluido com sucesso" });
            }
            catch (System.Exception)
            {

                return BadRequest(new { erro = "Erro ao excluir o catalogo" });
            }
        }

            [HttpGet("buscar-catalogo{id}")]
            public async Task<CatalogoViewModel> Buscar(int id)
            {
                var catalogo = await _consultarCatalogo.BuscarPorId(id);

                if (catalogo == null)
                {
                    return null;
                }

                var catalogoViewModel = CatalogoFactory.MapearCatalogoViewModel(catalogo);

                return catalogoViewModel;
            }

        }
    }