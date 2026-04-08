using SistemaUBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Application.Interfaces;


public interface IMedicoRepository
{
    Task<Medico?> ObterPorUsuarioIdAsync(int usuarioId);
    Task InserirAsync(Medico medico);
    Task<List<Medico>> ListarAsync();
}