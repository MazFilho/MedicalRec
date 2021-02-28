using MedicalRec.Dominio.Entidades;
using MedicalRec.Repositorio.Repositorios;

namespace MedicalRec.Repositorio
{
    public class Client
    {
        public Client()
        {
            var medicoRepositorio = new MedicoRepositorio();
            var medico = new Medico();
            medicoRepositorio.Adicionar(medico);
        }
    }
}
