using MedicalRec.Dominio.Contratos;
using MedicalRec.Dominio.Entidades;
using MedicalRec.Repositorio.Contexto;

namespace MedicalRec.Repositorio.Repositorios
{
    public class MedicoRepositorio : BaseRepositorio<Medico>, IMedicoRepositorio
    {
        public MedicoRepositorio(MedicalRecContexto medicalRecContexto) : base(medicalRecContexto)
        {

        }
    }
}
