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
            throw new NotImplementedException();
        }
    }
}
