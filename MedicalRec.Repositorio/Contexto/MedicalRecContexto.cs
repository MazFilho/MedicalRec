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

            modelBuilder.Entity<Especialidade>()
               .HasData(
                    new Especialidade() { Id = 1, Nome = "Alergologia" },
                    new Especialidade() { Id = 2, Nome = "Angiologia" },
                    new Especialidade() { Id = 3, Nome = "Buco Maxilo" },
                    new Especialidade() { Id = 4, Nome = "Cardiologia Clínica" },
                    new Especialidade() { Id = 5, Nome = "Cardiologia Infantil" },
                    new Especialidade() { Id = 6, Nome = "Cirurgia Cabeça e Pescoço" },
                    new Especialidade() { Id = 7, Nome = "Cirurgia Cardíaca" },
                    new Especialidade() { Id = 8, Nome = "Cirurgia de Tórax" }
                    );




            base.OnModelCreating(modelBuilder);
        }
    }
}
