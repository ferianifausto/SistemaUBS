using SistemaUBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Domain.Interfaces
{
    public interface IMedicoRepository
    {
        Task<Medico?> ObterPorUsuarioIdAsync(int usuarioId);
    }
}
