using MedicalRec.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;


namespace MedicalRec.Repositorio.Config
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(en => en.Id);

            builder
                .Property(en => en.Logradouro)
                .HasMaxLength(70);

            builder
                .Property(en => en.Bairro)
                .HasMaxLength(50);

            builder
                .Property(en => en.Cidade)
                .HasMaxLength(50);

            builder
                .Property(en => en.Estado)
                .HasMaxLength(20);

            builder
                .Property(en => en.CEP)
                .IsRequired()
                .HasColumnType("00000-000");

            





        }
    }
}
