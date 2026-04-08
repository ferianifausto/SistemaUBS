using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Services;

public class ConsultaService
{
    private readonly IConsultaRepository _consultaRepo;

    public ConsultaService(IConsultaRepository consultaRepo)
    {
        _consultaRepo = consultaRepo;
    }

    public async Task<List<Consulta>> ObterPorPaciente(int pacienteId)
    {
        return await _consultaRepo.ObterPorPacienteIdAsync(pacienteId);
    }

    public async Task<List<Consulta>> ObterPorMedico(int medicoId)
    {
        return await _consultaRepo.ObterPorMedicoIdAsync(medicoId);
    }

    public async Task Inserir(int pacienteId, int medicoId, DateTime data)
    {
        var consulta = new Consulta
        {
            PacienteId = pacienteId,
            MedicoId = medicoId,
            Data = data
        };

        await _consultaRepo.InserirAsync(consulta);
    }

    public async Task<Consulta?> ObterPorId(int id)
    {
        return await _consultaRepo.ObterPorIdAsync(id);
    }

    public async Task AtualizarDiagnostico(int consultaId, string diagnostico)
    {
        var consulta = await _consultaRepo.ObterPorIdAsync(consultaId);

        if (consulta == null)
            throw new Exception("Consulta não encontrada.");

        consulta.Diagnostico = diagnostico;

        await _consultaRepo.AtualizarAsync(consulta);
    }

    public async Task Remover(int id)
    {
        await _consultaRepo.RemoverAsync(id);
    }
}