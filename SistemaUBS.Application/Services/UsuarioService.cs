using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Services;

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

        if (string.IsNullOrWhiteSpace(login))
            erros.Add("Login obrigatório");

        if (string.IsNullOrWhiteSpace(senha))
            erros.Add("Senha obrigatória");

        if (erros.Any())
            return (null, erros);

        var usuario = await _usuarioRepository.ObterPorLoginAsync(login);

        if (usuario == null)
        {
            erros.Add("Usuário não encontrado");
            return (null, erros);
        }

        if (!usuario.ValidarSenha(senha))
        {
            erros.Add("Senha inválida");
            return (null, erros);
        }

        return (usuario, erros);
    }

    public async Task CadastrarAsync(Usuario usuario)
    {
        var erros = new List<string>();

        if (string.IsNullOrWhiteSpace(usuario.Login))
            erros.Add("Login obrigatório");

        if (string.IsNullOrWhiteSpace(usuario.SenhaHash))
            erros.Add("Senha obrigatória");

        if (string.IsNullOrWhiteSpace(usuario.Tipo))
            erros.Add("Tipo obrigatório");

        var existente = await _usuarioRepository.ObterPorLoginAsync(usuario.Login);

        if (existente != null)
            erros.Add("Usuário já cadastrado com esse login");

        if (erros.Any())
            throw new Exception(string.Join("\n", erros));

        await _usuarioRepository.InserirAsync(usuario);
    }

    public async Task<List<Usuario>> ListarAsync()
    {
        return await _usuarioRepository.ListarAsync();
    }
}