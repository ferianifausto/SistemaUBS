using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Application.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

public class ExameRepository : IExameRepository
{
    public async Task<List<Exame>> ListarAsync()
    {
        var lista = new List<Exame>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, PacienteId, MedicoId, Data, Resultado
                      FROM Exames";

        using var cmd = new SqlCommand(query, conn);
        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            var exame = new Exame
            {
                Id = reader.GetInt32(0),
                PacienteId = reader.GetInt32(1),
                MedicoId = reader.GetInt32(2),
                Data = reader.GetDateTime(3),
                Resultado = reader.IsDBNull(4) ? null : reader.GetString(4)
            };

            lista.Add(exame);
        }

        return lista;
    }

    public async Task InserirAsync(Exame exame)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"INSERT INTO Exames 
                      (PacienteId, MedicoId, Data, Resultado)
                      VALUES (@PacienteId, @MedicoId, @Data, @Resultado)";

        using var cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@PacienteId", exame.PacienteId);
        cmd.Parameters.AddWithValue("@MedicoId", exame.MedicoId);
        cmd.Parameters.AddWithValue("@Data", exame.Data);
        cmd.Parameters.AddWithValue("@Resultado",
            (object?)exame.Resultado ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<Exame?> ObterPorIdAsync(int id)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, PacienteId, MedicoId, Data, Resultado
                      FROM Exames
                      WHERE Id = @Id";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        using var reader = await cmd.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Exame
            {
                Id = reader.GetInt32(0),
                PacienteId = reader.GetInt32(1),
                MedicoId = reader.GetInt32(2),
                Data = reader.GetDateTime(3),
                Resultado = reader.IsDBNull(4) ? null : reader.GetString(4)
            };
        }

        return null;
    }

    public async Task<List<Exame>> ObterPorPacienteIdAsync(int pacienteId)
    {
        var lista = new List<Exame>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, PacienteId, MedicoId, Data, Resultado
                  FROM Exames
                  WHERE PacienteId = @PacienteId";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@PacienteId", pacienteId);

        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(new Exame
            {
                Id = reader.GetInt32(0),
                PacienteId = reader.GetInt32(1),
                MedicoId = reader.GetInt32(2),
                Data = reader.GetDateTime(3),
                Resultado = reader.IsDBNull(4) ? null : reader.GetString(4)
            });
        }

        return lista;
    }

    public async Task AtualizarAsync(Exame exame)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"UPDATE Exames
                      SET PacienteId = @PacienteId,
                          MedicoId = @MedicoId,
                          Data = @Data,
                          Resultado = @Resultado
                      WHERE Id = @Id";

        using var cmd = new SqlCommand(query, conn);

        cmd.Parameters.AddWithValue("@Id", exame.Id);
        cmd.Parameters.AddWithValue("@PacienteId", exame.PacienteId);
        cmd.Parameters.AddWithValue("@MedicoId", exame.MedicoId);
        cmd.Parameters.AddWithValue("@Data", exame.Data);
        cmd.Parameters.AddWithValue("@Resultado",
            (object?)exame.Resultado ?? DBNull.Value);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task RemoverAsync(int id)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = "DELETE FROM Exames WHERE Id = @Id";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        await cmd.ExecuteNonQueryAsync();
    }
}