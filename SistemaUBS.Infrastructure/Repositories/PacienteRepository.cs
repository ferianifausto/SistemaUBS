namespace SistemaUBS.Infrastructure.Repositories;

using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Application.Interfaces;

public class PacienteRepository : IPacienteRepository
{
    public async Task<List<Paciente>> ListarAsync()
    {
        var lista = new List<Paciente>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = "SELECT Id, Nome, UsuarioId FROM Pacientes";

        using var cmd = new SqlCommand(query, conn);
        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(new Paciente
            {
                Id = reader.GetInt32(0),
                Nome = reader.GetString(1),
                UsuarioId = reader.GetInt32(2)
            });
        }

        return lista;
    }

    public async Task<Paciente?> ObterPorUsuarioIdAsync(int usuarioId)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, Nome, UsuarioId 
                      FROM Pacientes 
                      WHERE UsuarioId = @UsuarioId";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@UsuarioId", usuarioId);

        using var reader = await cmd.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Paciente
            {
                Id = reader.GetInt32(0),
                Nome = reader.GetString(1),
                UsuarioId = reader.GetInt32(2)
            };
        }

        return null;
    }

    public async Task InserirAsync(Paciente paciente)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"INSERT INTO Pacientes (Nome, UsuarioId)
                      VALUES (@Nome, @UsuarioId)";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Nome", paciente.Nome);
        cmd.Parameters.AddWithValue("@UsuarioId", paciente.UsuarioId);

        await cmd.ExecuteNonQueryAsync();
    }
}