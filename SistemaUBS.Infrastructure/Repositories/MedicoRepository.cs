using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

using Microsoft.EntityFrameworkCore;
using SistemaUBS.Infrastructure.Config;

public class MedicoRepository : IMedicoRepository
{
    private readonly AppDbContext _context;

    public MedicoRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Medico?> ObterPorUsuarioIdAsync(int usuarioId)
    {
        return await _context.Medicos
            .FirstOrDefaultAsync(m => m.UsuarioId == usuarioId);
    }
}