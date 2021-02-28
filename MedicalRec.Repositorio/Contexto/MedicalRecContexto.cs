using MedicalRec.Dominio.Entidades;
using Microsoft.EntityFrameworkCore;

namespace MedicalRec.Repositorio.Contexto
{
    public class MedicalRecContexto : DbContext
    {
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Especialidade> Especialidades { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public MedicalRecContexto(DbContextOptions options) : base(options)
        {

        }

    }
}
