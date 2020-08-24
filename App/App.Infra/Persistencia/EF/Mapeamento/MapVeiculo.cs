using App.Domain.Entidades;
using App.Domain.ObjetosDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra.Persistencia.EF.Mapeamento
{
    class MapVeiculo : IEntityTypeConfiguration<Veiculo>
    {
        public void Configure(EntityTypeBuilder<Veiculo> builder)
        {

            // builder.ToTable("Pessoa");
            builder.OwnsOne<Placa>(x => x.Placa);
            builder.OwnsOne<Endereco>(x => x.Endereco);
          //  builder.OwnsOne<Pessoa>(x => x.Pessoa);
         //   builder.OwnsOne<Marca>(x => x.Marca);
            // builder.OwnsOne<TipoPessoa>(x => x.TipoPessoa);
            //builder.OwnsOne<Endereco>(x => x.Endereco, cb => {
            //    cb.Property(x => x.Logradouro).HasMaxLength(200).HasColumnName("Logradouro").IsRequired();
            //});
        }
    }
}
