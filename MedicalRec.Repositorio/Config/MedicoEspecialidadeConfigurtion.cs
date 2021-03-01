using MedicalRec.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MedicalRec.Repositorio.Config
{
    public class MedicoEspecialidadeConfigurtion : IEntityTypeConfiguration<MedicoEspecialidade>
    {
        public void Configure(EntityTypeBuilder<MedicoEspecialidade> builder)
        {
            builder.HasKey(me => new { me.MedicoId, me.EspecialidadeId });
                     

        }
    }
}
