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


        public AgendamentoController(IEmailService emailService)
        {
            this._emailService = emailService;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}