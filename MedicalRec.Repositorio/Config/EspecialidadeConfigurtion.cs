using MedicalRec.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace MedicalRec.Repositorio.Config
{
    public class EspecialidadeConfigurtion : IEntityTypeConfiguration<Especialidade>
    {
        public void Configure(EntityTypeBuilder<Especialidade> builder)
        {
            builder.HasKey(e => e.Id);

            builder
                .Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(70);
                
        }
    }
}
