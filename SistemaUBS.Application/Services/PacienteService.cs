using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Services;

public class PacienteService
{
    private readonly IPacienteRepository _pacienteRepo;
    private readonly IConsultaRepository _consultaRepo;
    private readonly IExameRepository _exameRepo;

    public PacienteService(
        IPacienteRepository pacienteRepo,
        IConsultaRepository consultaRepo,
        IExameRepository exameRepo)
    {
        _pacienteRepo = pacienteRepo;
        _consultaRepo = consultaRepo;
        _exameRepo = exameRepo;
    }

    public async Task<Paciente?> ObterPorUsuarioId(int usuarioId)
    {
        return await _pacienteRepo.ObterPorUsuarioIdAsync(usuarioId);
    }

    public async Task<List<Consulta>> ObterConsultasPorUsuarioId(int usuarioId)
    {
        var paciente = await _pacienteRepo.ObterPorUsuarioIdAsync(usuarioId);

        if (paciente == null)
            throw new Exception("Paciente não encontrado.");

        return await _consultaRepo.ObterPorPacienteIdAsync(paciente.Id);
    }

    public async Task AgendarConsulta(int usuarioId, int medicoId, DateTime data)
    {
        var paciente = await _pacienteRepo.ObterPorUsuarioIdAsync(usuarioId);

        if (paciente == null)
            throw new Exception("Paciente não encontrado.");

        if (medicoId <= 0)
            throw new Exception("Médico inválido.");

        if (data == default)
            throw new Exception("Data inválida.");

        var consulta = new Consulta
        {
            PacienteId = paciente.Id,
            MedicoId = medicoId,
            Data = data
        };

        await _consultaRepo.InserirAsync(consulta);
    }

    public async Task<List<Exame>> ObterExamesPorUsuarioId(int usuarioId)
    {
        var paciente = await _pacienteRepo.ObterPorUsuarioIdAsync(usuarioId);

        if (paciente == null)
            throw new Exception("Paciente não encontrado.");

        return await _exameRepo.ObterPorPacienteIdAsync(paciente.Id);
    }
}