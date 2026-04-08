using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Interfaces;


public interface IExameRepository
{
    Task<List<Exame>> ListarAsync();
    Task InserirAsync(Exame exame);
    Task<Exame?> ObterPorIdAsync(int id);
    Task AtualizarAsync(Exame exame);
    Task RemoverAsync(int id);
    Task<List<Exame>> ObterPorPacienteIdAsync(int pacienteId);

}