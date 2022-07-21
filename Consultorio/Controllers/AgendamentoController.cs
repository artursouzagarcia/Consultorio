using Consultorio.Models.Entities;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;

namespace Consultorio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        List<Agendamento> agendamentos = new List<Agendamento>();

        public AgendamentoController()
        {
            agendamentos.Add(new Agendamento
            {
                Id = 1,
                NomePaciente = "Artur",
                Horario = new System.DateTime()
            });
            agendamentos.Add(new Agendamento
            {
                Id = 2,
                NomePaciente = "Lucas",
                Horario = new System.DateTime()
            });

            agendamentos.Add(new Agendamento
            {
                Id = 3,
                NomePaciente = "Rafael",
                Horario = new System.DateTime()
            });
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok(agendamentos);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var agedamentoSelecionado = agendamentos.Find(agendamento => agendamento.Id == id);

            if (agedamentoSelecionado == null)
                return NotFound($"Não foi possivel encontrar agendamento com id {id}");

            return Ok(agedamentoSelecionado);
        }

        [HttpPost]
        public IActionResult Post()
        {
            var pacienteAgendado = true;

        }

    }
}