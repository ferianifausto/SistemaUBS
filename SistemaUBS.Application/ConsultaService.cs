using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Application;

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
}
