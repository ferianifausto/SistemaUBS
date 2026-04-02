using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

using Microsoft.EntityFrameworkCore;
using SistemaUBS.Infrastructure.Config;

public class PacienteRepository : IPacienteRepository
{
    private readonly AppDbContext _context;

    public PacienteRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Paciente?> ObterPorUsuarioIdAsync(int usuarioId)
    {
        return await _context.Pacientes
            .FirstOrDefaultAsync(p => p.UsuarioId == usuarioId);
    }
}