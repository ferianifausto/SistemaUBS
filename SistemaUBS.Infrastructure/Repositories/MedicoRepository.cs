using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Application.Interfaces;
using SistemaUBS.Infrastructure;
namespace SistemaUBS.Infrastructure.Repositories;

public class MedicoRepository : IMedicoRepository
{
    public async Task<List<Medico>> ListarAsync()
    {
        var lista = new List<Medico>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = "SELECT Id, Nome, UsuarioId, Especialidade, CRM FROM Medicos";

        using var cmd = new SqlCommand(query, conn);
        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(new Medico
            {
                Id = reader.GetInt32(0),
                Nome = reader.GetString(1),
                UsuarioId = reader.GetInt32(2),
                Especialidade = reader.GetString(3),
                CRM = reader.GetString(4)
            });
        }

        return lista;
    }

    public async Task<Medico?> ObterPorUsuarioIdAsync(int usuarioId)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, Nome, UsuarioId, Especialidade, CRM
                      FROM Medicos
                      WHERE UsuarioId = @UsuarioId";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

        using var reader = await cmd.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Medico
            {
                Id = reader.GetInt32(0),
                Nome = reader.GetString(1),
                UsuarioId = reader.GetInt32(2),
                Especialidade = reader.GetString(3), 
                CRM = reader.GetString(4)
                
            };
        }

        return null;
    }

    public async Task InserirAsync(Medico medico)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"INSERT INTO Medicos (Nome, UsuarioId, Especialidade, CRM)
                      VALUES (@Nome, @UsuarioId, @Especialidade, @CRM)";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Nome", medico.Nome);
        cmd.Parameters.AddWithValue("@UsuarioId", medico.UsuarioId);
        cmd.Parameters.AddWithValue("@Especialidade", medico.Especialidade);
        cmd.Parameters.AddWithValue("@CRM", medico.CRM);

        await cmd.ExecuteNonQueryAsync();
    }
}