using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

using Microsoft.EntityFrameworkCore;
using SistemaUBS.Infrastructure.Config;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly AppDbContext _context;

    public UsuarioRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Usuario?> ObterPorLoginAsync(string login)
    {
        return await _context.Usuarios
            .FirstOrDefaultAsync(u => u.Login == login);
    }

    public async Task<Usuario> AdicionarAsync(Usuario usuario)
    {
        _context.Usuarios.Add(usuario);
        await _context.SaveChangesAsync();
        return usuario;
    }
}