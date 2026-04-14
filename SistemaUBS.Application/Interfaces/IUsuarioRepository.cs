using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario?> ObterPorLoginAsync(string login);
    Task InserirAsync(Usuario usuario);
    Task<bool> LoginExisteAsync(string login);
    Task<List<Usuario>> ListarAsync();
}