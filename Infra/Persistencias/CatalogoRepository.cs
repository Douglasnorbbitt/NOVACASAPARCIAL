using Dominio.Entidades;
using Dominio.IRepositories;
using Infra.Contexto;

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Persistencias
{
    public class CatalogoRepository : ICatalogoRepository
    {
        private readonly DataContext _dataContext;

        public CatalogoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task Alterar(Catalogo catalogo)
        {
            _dataContext.Update(catalogo);
            await _dataContext.SaveChangesAsync();
        }

        public async Task<Catalogo> BuscarPorId(int id)
        {
            return await _dataContext.Catalogos.FirstOrDefaultAsync(x => x.Id == id);
            
        }

        public async Task Criar(Catalogo catalogo)
        {
            _dataContext.Catalogos.Add(catalogo);
            await _dataContext.SaveChangesAsync();
        }

        public async Task Excluir(Catalogo catalogo)
        {
            _dataContext.Remove(catalogo);
            await _dataContext.SaveChangesAsync();
        }

        public Task Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Catalogo>> ListarTodosCatalogos()
        {
            return await _dataContext.Catalogos.AsNoTracking().ToListAsync();
        }
    }
}
