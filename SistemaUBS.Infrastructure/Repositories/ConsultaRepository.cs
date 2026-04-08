using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Application.Interfaces;
using SistemaUBS.Infrastructure;

public class ConsultaRepository : IConsultaRepository
{
    public async Task<List<Consulta>> ListarAsync()
    {
        var lista = new List<Consulta>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, PacienteId, MedicoId, Data, Diagnostico
                      FROM Consultas";

        using var cmd = new SqlCommand(query, conn);
        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(new Consulta
            {
                Id = reader.GetInt32(0),
                PacienteId = reader.GetInt32(1),
                MedicoId = reader.GetInt32(2),
                Data = reader.GetDateTime(3),
                Diagnostico = reader.IsDBNull(4) ? null : reader.GetString(4)

            });
        }

        return lista;
    }

    public async Task<Consulta?> ObterPorIdAsync(int id)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, PacienteId, MedicoId, Data, Diagnostico
                      FROM Consultas
                      WHERE Id = @Id";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        using var reader = await cmd.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Consulta
            {
                Id = reader.GetInt32(0),
                PacienteId = reader.GetInt32(1),
                MedicoId = reader.GetInt32(2),
                Data = reader.GetDateTime(3),
                Diagnostico = reader.IsDBNull(4) ? null : reader.GetString(4)
            };
        }

        return null;
    }

    public async Task<List<Consulta>> ObterPorPacienteIdAsync(int pacienteId)
    {
        var lista = new List<Consulta>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, PacienteId, MedicoId, Data, Diagnostico
                  FROM Consultas
                  WHERE PacienteId = @PacienteId";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@PacienteId", pacienteId);

        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(new Consulta
            {
                Id = reader.GetInt32(0),
                PacienteId = reader.GetInt32(1),
                MedicoId = reader.GetInt32(2),
                Data = reader.GetDateTime(3),
                Diagnostico = reader.IsDBNull(4) ? null : reader.GetString(4)
            });
        }

        return lista;
    }

    public async Task<List<Consulta>> ObterPorMedicoIdAsync(int medicoId)
    {
        var lista = new List<Consulta>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, PacienteId, MedicoId, Data, Diagnostico
                  FROM Consultas
                  WHERE MedicoId = @MedicoId";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@MedicoId", medicoId);

        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(new Consulta
            {
                Id = reader.GetInt32(0),
                PacienteId = reader.GetInt32(1),
                MedicoId = reader.GetInt32(2),
                Data = reader.GetDateTime(3),
                Diagnostico = reader.IsDBNull(4) ? null : reader.GetString(4)
            });
        }

        return lista;
    }

    public async Task InserirAsync(Consulta consulta)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"INSERT INTO Consultas (PacienteId, MedicoId, Data)
                      VALUES (@PacienteId, @MedicoId, @Data)";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@PacienteId", consulta.PacienteId);
        cmd.Parameters.AddWithValue("@MedicoId", consulta.MedicoId);
        cmd.Parameters.AddWithValue("@Data", consulta.Data);
     

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task AtualizarAsync(Consulta consulta)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"UPDATE Consultas
                      SET PacienteId = @PacienteId,
                          MedicoId = @MedicoId,
                          Data = @Data,
                          Diagnostico = @Diagnostico
                      WHERE Id = @Id";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", consulta.Id);
        cmd.Parameters.AddWithValue("@PacienteId", consulta.PacienteId);
        cmd.Parameters.AddWithValue("@MedicoId", consulta.MedicoId);
        cmd.Parameters.AddWithValue("@Data", consulta.Data);
       

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task RemoverAsync(int id)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = "DELETE FROM Consultas WHERE Id = @Id";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Id", id);

        await cmd.ExecuteNonQueryAsync();
    }
}