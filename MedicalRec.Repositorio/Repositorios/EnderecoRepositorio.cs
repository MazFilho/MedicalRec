using MedicalRec.Dominio.Contratos;
using MedicalRec.Dominio.Entidades;
using MedicalRec.Repositorio.Contexto;

namespace MedicalRec.Repositorio.Repositorios
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IEnderecoRepositorio
    {
        public EnderecoRepositorio(MedicalRecContexto medicalRecContexto) : base(medicalRecContexto)
        {
        }
    }
}
