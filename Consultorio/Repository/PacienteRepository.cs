using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Consultorio.Context;
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

        public ICollection<Paciente> GetPacientes(bool fullData = false)
        {
            var pacientes = fullData ? this.context.Pacientes.Include(x => x.Consultas).ToList() : this.context.Pacientes.ToList();

            return pacientes;
        }

        public Paciente GetPacienteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}