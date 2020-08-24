using App.Domain.Entidades;
using App.Domain.ObjetosDeValor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.Infra.Persistencia.EF.Mapeamento
{
    class MapPessoa : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {

            // builder.ToTable("Pessoa");
            builder.OwnsOne<Endereco>(x => x.Endereco);
            builder.OwnsOne<Cnh>(x => x.Cnh);
            // builder.OwnsOne<TipoPessoa>(x => x.TipoPessoa);
            //builder.OwnsOne<Endereco>(x => x.Endereco, cb => {
            //    cb.Property(x => x.Logradouro).HasMaxLength(200).HasColumnName("Logradouro").IsRequired();
            //});
        }
    }
}
