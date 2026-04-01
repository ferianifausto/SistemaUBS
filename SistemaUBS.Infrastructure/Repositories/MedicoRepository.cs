using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

public class MedicoRepository : IMedicoRepository
{
    private readonly string _connectionString;

    public MedicoRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<Medico?> ObterPorUsuarioIdAsync(int usuarioId)
    {
        const string sql = "SELECT Id, Nome, Especialidade, UsuarioId FROM Medicos WHERE UsuarioId = @UsuarioId";

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@UsuarioId", usuarioId);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Medico(
                reader.GetString(1),
                reader.GetString(2),
                reader.GetInt32(3)
            );
        }

        return null;
    }
}
