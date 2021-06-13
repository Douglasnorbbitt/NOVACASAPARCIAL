using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NovaCasa.Models
{
    public class CatalogoViewModel
    {
        public int Id { get; set; }
        public string Valor { get; set; }
        public string TipoImovel { get; set; }
        [Required(ErrorMessage = "{0} é requerido")]
        public int NumeroImovel { get; set; }
        public string Rua{ get; set; }
        public string Bairro{ get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        [Required(ErrorMessage = "{0} é requerido")]
        public int Cep { get; set; }


    }
}
