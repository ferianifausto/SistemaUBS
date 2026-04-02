using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

using Microsoft.EntityFrameworkCore;
using SistemaUBS.Infrastructure.Config;

public class ExameRepository : IExameRepository
{
    private readonly AppDbContext _context;

    public ExameRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Exame>> ObterPorPacienteIdAsync(int pacienteId)
    {
        return await _context.Exames
            .Where(e => e.PacienteId == pacienteId)
            .ToListAsync();
    }

    public async Task<Exame> AdicionarAsync(Exame exame)
    {
        _context.Exames.Add(exame);
        await _context.SaveChangesAsync();
        return exame;
    }

    public async Task AtualizarAsync(Exame exame)
    {
        _context.Exames.Update(exame);
        await _context.SaveChangesAsync();
    }
}