using MedicalRec.Dominio.Contratos;
using MedicalRec.Dominio.Entidades;
using MedicalRec.Repositorio.Contexto;

namespace MedicalRec.Repositorio.Repositorios
{
    public class MedicoEspecialidadeRepositorio : BaseRepositorio<MedicoEspecialidade>, IMedicoEspecialidadeRepositorio
    {
        public MedicoEspecialidadeRepositorio(MedicalRecContexto medicalRecContexto) : base(medicalRecContexto)
        {
        }
    }
}
