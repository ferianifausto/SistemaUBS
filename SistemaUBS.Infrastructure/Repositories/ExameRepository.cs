using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

public class ExameRepository : IExameRepository
{
    private readonly string _connectionString;

    public ExameRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<List<Exame>> ObterPorPacienteIdAsync(int pacienteId)
    {
        const string sql = "SELECT Id, PacienteId, MedicoId, Descricao, Resultado, Data FROM Exames WHERE PacienteId = @PacienteId";

        var lista = new List<Exame>();

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@PacienteId", pacienteId);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            var exame = new Exame(
                reader.GetInt32(1),
                reader.GetInt32(2),
                reader.GetString(3),
                reader.GetDateTime(5)
            );

            if (!reader.IsDBNull(4))
                exame.DefinirResultado(reader.GetString(4));

            lista.Add(exame);
        }

        return lista;
    }

    public async Task<Exame> AdicionarAsync(Exame exame)
    {
        const string sql = @"INSERT INTO Exames (PacienteId, MedicoId, Descricao, Data)
                             VALUES (@PacienteId, @MedicoId, @Descricao, @Data);
                             SELECT SCOPE_IDENTITY();";

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@PacienteId", exame.PacienteId);
        command.Parameters.AddWithValue("@MedicoId", exame.MedicoId);
        command.Parameters.AddWithValue("@Descricao", exame.Descricao);
        command.Parameters.AddWithValue("@Data", exame.Data);

        await connection.OpenAsync();
        var id = await command.ExecuteScalarAsync();

        exame.GetType().GetProperty("Id")?.SetValue(exame, Convert.ToInt32(id));
        return exame;
    }

    public async Task AtualizarAsync(Exame exame)
    {
        const string sql = @"UPDATE Exames SET Resultado = @Resultado WHERE Id = @Id";

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@Id", exame.Id);
        command.Parameters.AddWithValue("@Resultado", (object?)exame.Resultado ?? DBNull.Value);

        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }
}
