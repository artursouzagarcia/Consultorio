using System.Collections.Generic;
using System.Threading.Tasks;
using Consultorio.Models.Dtos;
using Consultorio.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers

//https://www.youtube.com/watch?v=GC_IY47qDYs&list=PLxd1RHU8YgYkHCbZqtqWuaYHASNERx-Tn&index=7
{
    [ApiController]
    [Route("api/[controller]")]
    public class PacienteController : ControllerBase
    {
        public IPacienteRepository pacienteRepository;
        public PacienteController(IPacienteRepository repository)
        {
            this.pacienteRepository = repository;
        }

        [HttpGet("")]
        public async Task<IActionResult> Get()
        {
            var pacientes = await this.pacienteRepository.GetPacientesAsync();
            return pacientes.Count > 0 ? Ok(pacientes) : BadRequest("Paciente não encontrado!");
        }

        [HttpGet("GetById")]
        public async Task<IActionResult> GetById(int id)
        {
            var paciente = await this.pacienteRepository.GetPacienteByIdAsync(id);
            return Ok(paciente);
        }
    }
}