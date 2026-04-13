using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Services;

public class MedicoService
{
    private readonly IMedicoRepository _medicoRepo;
    private readonly IConsultaRepository _consultaRepo;
    private readonly IExameRepository _exameRepo;

    public MedicoService(
        IMedicoRepository medicoRepo,
        IConsultaRepository consultaRepo,
        IExameRepository exameRepo)
    {
        _medicoRepo = medicoRepo;
        _consultaRepo = consultaRepo;
        _exameRepo = exameRepo;
    }

    public async Task<Medico?> ObterPorUsuarioId(int usuarioId)
    {
        return await _medicoRepo.ObterPorUsuarioIdAsync(usuarioId);
    }

    public async Task<List<Consulta>> ObterConsultasPorUsuarioId(int usuarioId)
    {
        var medico = await _medicoRepo.ObterPorUsuarioIdAsync(usuarioId);

        if (medico == null)
            throw new Exception("Médico não encontrado.");

        return await _consultaRepo.ObterPorMedicoIdAsync(medico.Id);
    }

    public async Task AtualizarDiagnostico(int usuarioId, int consultaId, string diagnostico)
    {
        if (string.IsNullOrWhiteSpace(diagnostico))
            throw new Exception("Diagnóstico obrigatório.");

        var medico = await _medicoRepo.ObterPorUsuarioIdAsync(usuarioId);

        if (medico == null)
            throw new Exception("Médico não encontrado.");

        var consulta = await _consultaRepo.ObterPorIdAsync(consultaId);

        if (consulta == null)
            throw new Exception("Consulta não encontrada.");

        if (consulta.MedicoId != medico.Id)
            throw new Exception("Esta consulta não pertence a este médico.");

        consulta.Diagnostico = diagnostico;

        await _consultaRepo.AtualizarAsync(consulta);
    }

    public async Task AdicionarExame(int usuarioId, int consultaId, DateTime data, string? resultado, string? descricao)
    {
        var medico = await _medicoRepo.ObterPorUsuarioIdAsync(usuarioId);

        if (medico == null)
            throw new Exception("Médico não encontrado.");

        var consulta = await _consultaRepo.ObterPorIdAsync(consultaId);

        if (consulta == null)
            throw new Exception("Consulta não encontrada.");

        if (consulta.MedicoId != medico.Id)
            throw new Exception("Esta consulta não pertence a este médico.");

        var exame = new Exame
        {
            PacienteId = consulta.PacienteId,
            MedicoId = consulta.MedicoId,
            Data = data,
            Resultado = resultado,
            Descricao = descricao
        };

        await _exameRepo.InserirAsync(exame);
    }
}