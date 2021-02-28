using MedicalRec.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace MedicalRec.Repositorio.Config
{
    public class MedicoConfiguration : IEntityTypeConfiguration<Medico>
    {
        public void Configure(EntityTypeBuilder<Medico> builder)
        {
            builder.HasKey(m => m.Id);
            
            builder
                .Property(m => m.Nome)
                .IsRequired()
                .HasMaxLength(120);

            builder
                .Property(m => m.CRM)
                .IsRequired()
                .HasMaxLength(9)
                .HasColumnType("00.000.00");

            builder
                .Property(m => m.TelFixo)
                .HasMaxLength(20);

            builder
                .Property(m => m.TelCel)
                .HasMaxLength(20);

            //Outra Table
            //builder
            //    .Property(m => m.EnderecoId);

            //ICollection <Especialidades>
            //builder
            //    .Property(m => m.Especialidades);
                
        }
    }
}
