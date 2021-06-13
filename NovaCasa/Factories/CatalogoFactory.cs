using Dominio.Entidades;
using NovaCasa.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NovaCasa.Factories
{
    public static class CatalogoFactory
    {
        public static Catalogo MapearCatalogo(CatalogoViewModel catalogoViewModel)
        {
            return new Catalogo(catalogoViewModel.Valor, catalogoViewModel.TipoImovel, catalogoViewModel.NumeroImovel, catalogoViewModel.Rua, catalogoViewModel.Bairro, catalogoViewModel.Cidade, catalogoViewModel.Estado, catalogoViewModel.Cep);
        }

        public static CatalogoViewModel MapearCatalogoViewModel(Catalogo catalogo)
        {
            return new CatalogoViewModel() { Id = catalogo.Id, Valor = catalogo.Valor, TipoImovel = catalogo.TipoImovel, NumeroImovel = catalogo.NumeroImovel, Rua = catalogo.Rua, Bairro = catalogo.Bairro, Cidade = catalogo.Cidade, Estado = catalogo.Estado, Cep = catalogo.Cep };
        }
        
        public static IEnumerable<CatalogoViewModel> MapearListaCatalogoViewModel(IEnumerable<Catalogo> lista)
        {
            var listaCatalogoViewModel = new List<CatalogoViewModel>();
            CatalogoViewModel catalogovm;

            foreach (var item in lista)
            {
                catalogovm = new CatalogoViewModel
                {

                    Id = item.Id,
                    Valor = item.Valor,
                    TipoImovel = item.TipoImovel,
                    NumeroImovel = item.NumeroImovel,
                    Rua = item.Rua,
                    Bairro = item.Bairro,
                    Cidade = item.Cidade,
                    Estado = item.Estado,
                    Cep = item.Cep

                };
            
                listaCatalogoViewModel.Add(catalogovm);
            }
            return listaCatalogoViewModel;
        }
    }
}
