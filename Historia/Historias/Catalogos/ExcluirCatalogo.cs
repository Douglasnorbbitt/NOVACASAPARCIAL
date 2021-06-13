using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Catalogos
{
    public class ExcluirCatalogo
    {
        private readonly ICatalogoRepository _catalogoRepository;

        public ExcluirCatalogo(ICatalogoRepository catalogoRepository)
        {
            _catalogoRepository = catalogoRepository;
        }

        public async Task Executar(int id)
        {
            await _catalogoRepository.Excluir(id);
        }
    }
}
