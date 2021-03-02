using MedicalRec.Dominio.Contratos;
using MedicalRec.Dominio.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;

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

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_medicoRepositorio.ObterTodos());
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Medico medico)
        {
            try
            {
                _medicoRepositorio.Adicionar(medico);
                return Created("api/medico", medico);
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }



    }
}
