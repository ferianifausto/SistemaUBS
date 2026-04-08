using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Interfaces;

public interface IConsultaRepository
{
    Task<List<Consulta>> ListarAsync();
    Task<List<Consulta>> ObterPorPacienteIdAsync(int pacienteId);
    Task<Consulta?> ObterPorIdAsync(int id);
    Task InserirAsync(Consulta consulta);
    Task AtualizarAsync(Consulta consulta);
    Task RemoverAsync(int id);
    Task<List<Consulta>> ObterPorMedicoIdAsync(int medicoId);
}