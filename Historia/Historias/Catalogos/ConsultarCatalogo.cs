using Dominio.Entidades;
using Dominio.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Historias.Catalogos
{
   public class ConsultarCatalogo
    {
        private readonly ICatalogoRepository _catalogoRepository;

        public ConsultarCatalogo(ICatalogoRepository catalogoRepository)
        {
            _catalogoRepository = catalogoRepository;
        }

        public async Task<Catalogo> BuscarPorId(int id)
        {
            return await _catalogoRepository.BuscarPorId(id);
        }

        public async Task<IEnumerable<Catalogo>> ListarTodosCatalogos()
        {
            return await _catalogoRepository.ListarTodosCatalogos();
        }
    }
}
