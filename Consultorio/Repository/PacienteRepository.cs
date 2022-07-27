using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio.Context;
using Consultorio.Models.Dtos;
using Consultorio.Models.Entities;
using Consultorio.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Consultorio.Repository
{
    public class PacienteRepository : BaseRepository, IPacienteRepository
    {
        private readonly ConsultorioContext context;

        public PacienteRepository(ConsultorioContext context) : base(context)
        {
            this.context = context;
        }

        public async Task<ICollection<PacienteDto>> GetPacientesAsync()
        {

            return await this.context.Pacientes.Select(x => new PacienteDto { Id = x.Id, Nome = x.Nome }).ToListAsync();
        }

        public async Task<Paciente> GetPacienteByIdAsync(int id)
        {
            return await this.context.Pacientes
                        .Include(x => x.Consultas)
                        .Where(x => x.Id == id)
                        .FirstOrDefaultAsync();
        }
    }
}