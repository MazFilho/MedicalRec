using MedicalRec.Dominio.Entidades;
using MedicalRec.Repositorio.Config;
using Microsoft.EntityFrameworkCore;

namespace MedicalRec.Repositorio.Contexto
{
    public class MedicalRecContexto : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<MedicoEspecialidade> MedicoEspecialidades { get; set; }

        public MedicalRecContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de mapeamento
            modelBuilder.ApplyConfiguration(new MedicoConfiguration());
            modelBuilder.ApplyConfiguration(new EspecialidadeConfigurtion());
            modelBuilder.ApplyConfiguration(new EnderecoConfiguration());
            modelBuilder.ApplyConfiguration(new MedicoEspecialidadeConfigurtion());

            base.OnModelCreating(modelBuilder);
        }
    }
}
