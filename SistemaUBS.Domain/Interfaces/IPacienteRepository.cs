using SistemaUBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Domain.Interfaces
{
    public interface IPacienteRepository
    {
        Task<Paciente?> ObterPorUsuarioIdAsync(int usuarioId);
    }
}
