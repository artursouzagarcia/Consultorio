using Consultorio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers

//https://www.youtube.com/watch?v=GC_IY47qDYs&list=PLxd1RHU8YgYkHCbZqtqWuaYHASNERx-Tn&index=7
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        public IPacienteRepository repository;
        public PacienteController(IPacienteRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            var pacientes = this.repository.GetPacientes();
            return pacientes.Count > 0 ? Ok(pacientes) : BadRequest("Paciente não encontrado!");
        }

        [HttpGet("Getfull")]
        public IActionResult GetFull()
        {
            var pacientes = this.repository.GetPacientes(true);
            return pacientes.Count > 0 ? Ok(pacientes) : BadRequest("Paciente não encontrado!");
        }
    }
}