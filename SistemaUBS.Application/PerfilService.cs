using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Application;

public class PerfilService
{
    private readonly IPacienteRepository _pacienteRepo;
    private readonly IMedicoRepository _medicoRepo;

    public PerfilService(IPacienteRepository pacienteRepo, IMedicoRepository medicoRepo)
    {
        _pacienteRepo = pacienteRepo;
        _medicoRepo = medicoRepo;
    }

    public async Task<(object? perfil, List<string> erros)> ObterPerfilAsync(Usuario usuario)
    {
        var erros = new List<string>();

        if (usuario.Tipo == "PACIENTE")
        {
            var paciente = await _pacienteRepo.ObterPorUsuarioIdAsync(usuario.Id);

            if (paciente == null)
                erros.Add("Paciente não encontrado");

            return (paciente, erros);
        }

        if (usuario.Tipo == "MEDICO")
        {
            var medico = await _medicoRepo.ObterPorUsuarioIdAsync(usuario.Id);

            if (medico == null)
                erros.Add("Médico não encontrado");

            return (medico, erros);
        }

        erros.Add("Tipo de usuário inválido");
        return (null, erros);
    }
}