using System.Collections.Generic;
using Consultorio.Models.Entities;

namespace Consultorio.Repository.Interfaces
{
    public interface IPacienteRepository : IBaseRepository
    {
        ICollection<Paciente> GetPacientes(bool fullData = false);
        Paciente GetPacienteById(int id);
    }
}