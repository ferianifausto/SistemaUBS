using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Services;

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

    public async Task Inserir(int pacienteId, int medicoId, DateTime data, string? resultado)
    {
        var exame = new Exame
        {
            PacienteId = pacienteId,
            MedicoId = medicoId,
            Data = data,
            Resultado = resultado
        };

        await _exameRepo.InserirAsync(exame);
    }

    public async Task AtualizarResultado(Exame exame)
    {
        await _exameRepo.AtualizarAsync(exame);
    }
}