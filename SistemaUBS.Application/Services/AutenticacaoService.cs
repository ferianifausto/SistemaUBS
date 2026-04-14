using System.Security.Cryptography;
using System.Text;
using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Services;

public class AutenticacaoService
{
    private readonly IUsuarioRepository _usuarioRepository;

    public Usuario? UsuarioLogado { get; private set; }

    public AutenticacaoService(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    public async Task<(bool Sucesso, string Mensagem)> AutenticarAsync(string login, string senha)
    {
        if (string.IsNullOrWhiteSpace(login))
            return (false, "Informe o login.");

        if (string.IsNullOrWhiteSpace(senha))
            return (false, "Informe a senha.");

        var usuario = await _usuarioRepository.ObterPorLoginAsync(login);

        if (usuario == null)
            return (false, "Usuário não encontrado.");

        if (!usuario.Ativo)
            return (false, "Usuário inativo.");

        var hashInformado = GerarHash(senha);

        if (hashInformado != usuario.SenhaHash)
            return (false, "Senha incorreta.");

        UsuarioLogado = usuario;
        return (true, $"Bem-vindo, {usuario.Login}!");
    }

    public async Task<(bool Sucesso, string Mensagem)> RegistrarUsuarioAsync(string login, string senha, string tipo)
    {
        if (string.IsNullOrWhiteSpace(login))
            return (false, "Informe o login.");

        if (string.IsNullOrWhiteSpace(senha) || senha.Length < 4)
            return (false, "A senha deve ter pelo menos 4 caracteres.");

        if (string.IsNullOrWhiteSpace(tipo))
            return (false, "Informe o tipo de usuário.");

        var existente = await _usuarioRepository.ObterPorLoginAsync(login);
        if (existente != null)
            return (false, "Já existe um usuário com esse login.");

        var usuario = new Usuario
        {
            Login = login.Trim(),
            SenhaHash = GerarHash(senha),
            Tipo = tipo,
            Ativo = true,
            DataCadastro = DateTime.Now
        };

        await _usuarioRepository.InserirAsync(usuario);

        return (true, "Usuário registrado com sucesso!");
    }

    public void Logout()
    {
        UsuarioLogado = null;
    }

    private static string GerarHash(string senha)
    {
        var bytes = SHA256.HashData(Encoding.UTF8.GetBytes(senha));
        return Convert.ToHexString(bytes).ToLower();
    }
}