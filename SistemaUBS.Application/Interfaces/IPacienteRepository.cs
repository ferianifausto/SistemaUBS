using SistemaUBS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaUBS.Application.Interfaces;


public interface IPacienteRepository
{
    Task<Paciente?> ObterPorUsuarioIdAsync(int usuarioId);
    Task InserirAsync(Paciente paciente);
    Task<List<Paciente>> ListarAsync();
}