using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Catalogos
{
   public class AlterarCatalogo
    { 
    private readonly ICatalogoRepository _catalogoRepository;

    public AlterarCatalogo(ICatalogoRepository catalogoRepository)
    {
        _catalogoRepository = catalogoRepository;
    }

    public async Task Executar(int id, Catalogo catalogo )
    {
        var dadosDoCatalogo = await _catalogoRepository.BuscarPorId(id);

        dadosDoCatalogo.AtualizarDados (catalogo.Valor, catalogo.TipoImovel, catalogo.NumeroImovel,catalogo.Rua, catalogo.Bairro, catalogo.Cidade, catalogo.Estado, catalogo.Cep);

        await _catalogoRepository.Alterar(dadosDoCatalogo);
    }
}
}
