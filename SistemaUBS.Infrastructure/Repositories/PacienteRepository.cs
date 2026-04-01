using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

public class PacienteRepository : IPacienteRepository
{
    private readonly string _connectionString;

    public PacienteRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<Paciente?> ObterPorUsuarioIdAsync(int usuarioId)
    {
        const string sql = "SELECT Id, Nome, UsuarioId FROM Pacientes WHERE UsuarioId = @UsuarioId";

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@UsuarioId", usuarioId);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Paciente(
                reader.GetString(1),
                reader.GetInt32(2)
            );
        }

        return null;
    }
}
