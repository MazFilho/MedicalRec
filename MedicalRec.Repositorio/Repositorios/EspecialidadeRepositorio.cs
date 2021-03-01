using MedicalRec.Dominio.Contratos;
using MedicalRec.Dominio.Entidades;
using MedicalRec.Repositorio.Contexto;

namespace MedicalRec.Repositorio.Repositorios
{
    public class EspecialidadeRepositorio : BaseRepositorio<Especialidade>, IEspecialidadeRepositorio
    {
        public EspecialidadeRepositorio(MedicalRecContexto medicalRecContexto) : base(medicalRecContexto)
        {
        }
    }
}
