using Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Contexto.Maps
{
    public class CatalogoMap : IEntityTypeConfiguration<Catalogo>
    {
        public void Configure(EntityTypeBuilder<Catalogo> builder)
        {
            builder.ToTable("Catalogos");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Valor).HasMaxLength(10).HasColumnType("varchar");
            builder.Property(x => x.TipoImovel).HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.NumeroImovel).HasMaxLength(10).HasColumnType("varchar");
            builder.Property(x => x.Rua).HasMaxLength(100).HasColumnType("varchar");
            builder.Property(x => x.Bairro).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.Cidade).HasMaxLength(80).HasColumnType("varchar");
            builder.Property(x => x.Estado).HasMaxLength(50).HasColumnType("varchar");
            builder.Property(x => x.Cep).HasMaxLength(10).HasColumnType("varchar");


        }
    }

}
