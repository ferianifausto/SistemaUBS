using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

using Microsoft.EntityFrameworkCore;
using SistemaUBS.Infrastructure.Config;

public class ConsultaRepository : IConsultaRepository
{
    private readonly AppDbContext _context;

    public ConsultaRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<List<Consulta>> ObterPorPacienteIdAsync(int pacienteId)
    {
        return await _context.Consultas
            .Where(c => c.PacienteId == pacienteId)
            .ToListAsync();
    }

    public async Task<List<Consulta>> ObterPorMedicoIdAsync(int medicoId)
    {
        return await _context.Consultas
            .Where(c => c.MedicoId == medicoId)
            .ToListAsync();
    }

    public async Task<Consulta> AdicionarAsync(Consulta consulta)
    {
        _context.Consultas.Add(consulta);
        await _context.SaveChangesAsync();
        return consulta;
    }
}