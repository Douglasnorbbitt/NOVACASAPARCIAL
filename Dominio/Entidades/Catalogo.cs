using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Entidades
{
    public class Catalogo
    {
        public Catalogo( string valor, string tipoImovel, int numeroImovel, string rua, string bairro, string cidade, string estado, int cep)
        {
            Valor = valor;
            TipoImovel = tipoImovel;
            NumeroImovel = numeroImovel;
            Rua = rua;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
            Cep = cep;
        }

        public int Id { get; private set; }

        public void AtualizarDados(string valor, string tipoImovel, int numeroImovel, string rua, string bairro, string cidade, string estado, int cep)
        {
            throw new NotImplementedException();
        }

        public string Valor { get; private set; }
        public string TipoImovel { get; private set; }
        public int NumeroImovel { get; private set; }
        public string Rua { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public int Cep { get; private set; }

    }
}
