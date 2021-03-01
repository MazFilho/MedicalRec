using MedicalRec.Dominio.Contratos;
using Microsoft.AspNetCore.Mvc;

namespace MedicalRec.Web.Controllers
{
    [Route("api/[controller]")]
    public class MedicoController : Controller
    {
        private readonly IMedicoRepositorio _medicoRepositorio;
        public MedicoController(IMedicoRepositorio medicoRepositorio)
        {
            _medicoRepositorio = medicoRepositorio;
        }
    }
}
