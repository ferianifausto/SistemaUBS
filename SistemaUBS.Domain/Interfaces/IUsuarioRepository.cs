using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Domain.Interfaces;

public interface IUsuarioRepository
{
    Task<Usuario?> ObterPorLoginAsync(string login);
    Task<Usuario> AdicionarAsync(Usuario usuario);
}