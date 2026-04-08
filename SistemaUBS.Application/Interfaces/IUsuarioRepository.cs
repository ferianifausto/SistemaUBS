using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Application.Interfaces;


public interface IUsuarioRepository
{
    Task<Usuario?> ObterPorLoginAsync(string login);
    Task InserirAsync(Usuario usuario);

    Task<List<Usuario>> ListarAsync();
}