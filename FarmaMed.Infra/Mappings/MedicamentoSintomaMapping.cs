using FarmaMed.DomainModel.MedicamentoAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace FarmaMed.Infra.Mappings
{
    public class MedicamentoSintomaMapping : IEntityTypeConfiguration<MedicamentoSintoma>
    {
        public void Configure(EntityTypeBuilder<MedicamentoSintoma> builder)
        {
            builder.HasKey(ms => new { ms.MedicamentoId, ms.SintomaId });

            builder.HasOne(m => m.Medicamento)
                .WithMany(m => m.MedicamentoSintomas)
                .HasForeignKey(m => m.MedicamentoId);

            builder.HasOne(s => s.Sintoma)
             .WithMany(s => s.MedicamentoSintomas)
             .HasForeignKey(s => s.SintomaId);

            builder.ToTable("MedicamentosSintomas");
        }
    }
}
