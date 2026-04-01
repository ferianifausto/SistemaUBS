using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Application;

public class UsuarioService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public UsuarioService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<(Usuario? usuario, List<string> erros)> LoginAsync(string login, string senha)
    {
        var erros = new List<string>();

        // validação básica
        if (string.IsNullOrWhiteSpace(login))
            erros.Add("Login obrigatório");

        if (string.IsNullOrWhiteSpace(senha))
            erros.Add("Senha obrigatória");

        if (erros.Any())
            return (null, erros);

        // busca no banco
        var usuario = await _usuarioRepository.ObterPorLoginAsync(login);

        if (usuario == null)
        {
            erros.Add("Usuário não encontrado");
            return (null, erros);
        }

        // valida senha
        if (!usuario.ValidarSenha(senha))
        {
            erros.Add("Senha inválida");
            return (null, erros);
        }

        // sucesso
        return (usuario, erros);
    }
}