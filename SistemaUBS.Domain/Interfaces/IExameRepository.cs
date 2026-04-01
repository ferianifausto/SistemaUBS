using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Domain.Interfaces;

public interface IExameRepository
{
    Task<List<Exame>> ObterPorPacienteIdAsync(int pacienteId);
    Task<Exame> AdicionarAsync(Exame exame);
    Task AtualizarAsync(Exame exame);
}