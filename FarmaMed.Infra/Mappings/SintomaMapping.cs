using FarmaMed.DomainModel.MedicamentoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.Infra.Mappings
{
    public class SintomaMapping : IEntityTypeConfiguration<Sintoma>
    {
        public void Configure(EntityTypeBuilder<Sintoma> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Descricao)
                .IsRequired()
                .HasColumnType("varchar(500)");

            builder.ToTable("Sintomas");
        }
    }
}
