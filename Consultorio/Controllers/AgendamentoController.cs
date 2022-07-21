using Consultorio.Models.Entities;
using Consultorio.Services;
using System.Collections.Generic;

using Microsoft.AspNetCore.Mvc;
using System;

namespace Consultorio.Controllers

    //https://www.youtube.com/watch?v=GC_IY47qDYs&list=PLxd1RHU8YgYkHCbZqtqWuaYHASNERx-Tn&index=7
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgendamentoController : ControllerBase
    {
        private readonly IEmailService _emailService;
        List<Agendamento> agendamentos = new List<Agendamento>();

        public AgendamentoController(IEmailService emailService)
        {
            this._emailService = emailService;

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
            try
            {
                bool pacienteAgendado = true;


                if (pacienteAgendado)
                {
                    _emailService.EnviarEmail("artur@medx.med.br");
                }

                return Ok();

            }catch(Exception e)
            {
                return BadRequest(e.Message);
            }
        }

    }
}