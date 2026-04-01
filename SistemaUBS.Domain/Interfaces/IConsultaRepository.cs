using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Domain.Interfaces;

public interface IConsultaRepository
{
    Task<List<Consulta>> ObterPorPacienteIdAsync(int pacienteId);
    Task<List<Consulta>> ObterPorMedicoIdAsync(int medicoId);
    Task<Consulta> AdicionarAsync(Consulta consulta);
}