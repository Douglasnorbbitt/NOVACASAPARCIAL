
using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Catalogos
{
    public class CriarCatalogo
    {
        private readonly ICatalogoRepository _catalogoRepository;

        public CriarCatalogo(ICatalogoRepository catalogoRepository)
        {
            _catalogoRepository = catalogoRepository;
        }

        public async Task Executar(Catalogo catalogo)
        {
            await _catalogoRepository.Criar(catalogo);
        }
    }
}
