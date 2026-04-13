using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    public async Task Inserir(string? nomeExame, int pacienteId, int medicoId, DateTime data, string? resultado, string? descricao)
    {
        var exame = new Exame
        {
            NomeExame = nomeExame,
            PacienteId = pacienteId,
            MedicoId = medicoId,
            Data = data,
            Resultado = resultado,
            Descricao = descricao
        };

        await _exameRepo.InserirAsync(exame);
    }

    public async Task Atualizar(int id, string? nomeExame, int pacienteId, int medicoId, DateTime data, string? resultado, string? descricao)
    {
        var exame = new Exame
        {
            Id = id,
            NomeExame = nomeExame,
            PacienteId = pacienteId,
            MedicoId = medicoId,
            Data = data,
            Resultado = resultado,
            Descricao = descricao
        };

        await _exameRepo.AtualizarAsync(exame);
    }
}