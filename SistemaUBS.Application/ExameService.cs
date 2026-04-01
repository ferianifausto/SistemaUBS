using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Application;

public class ExameService
{
    private readonly IExameRepository _exameRepo;

    public ExameService(IExameRepository exameRepo)
    {
        _exameRepo = exameRepo;
    }

    public async Task<List<Exame>> ObterPorPaciente(int pacienteId)
    {
        return await _exameRepo.ObterPorPacienteIdAsync(pacienteId);
    }

    public async Task<Exame> Adicionar(Exame exame)
    {
        return await _exameRepo.AdicionarAsync(exame);
    }

    public async Task AtualizarResultado(Exame exame)
    {
        await _exameRepo.AtualizarAsync(exame);
    }
}
