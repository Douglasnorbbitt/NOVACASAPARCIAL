using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.IRepositories
{
    public interface ICatalogoRepository
    {
        Task Criar(Catalogo catalogo);
        Task Alterar(Catalogo catalogo);
        Task Excluir(Catalogo catalogo);
        Task <Catalogo>BuscarPorId(int id);
        Task <IEnumerable<Catalogo>> ListarTodosCatalogos();
        Task Excluir(int id);
    }
}
