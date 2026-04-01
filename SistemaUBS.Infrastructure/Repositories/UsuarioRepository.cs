using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Domain.Interfaces;

namespace SistemaUBS.Infrastructure.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    private readonly string _connectionString;

    public UsuarioRepository(string connectionString)
    {
        _connectionString = connectionString;
    }

    public async Task<Usuario?> ObterPorLoginAsync(string login)
    {
        const string sql = "SELECT Id, Login, Senha, Tipo FROM Usuarios WHERE Login = @Login";

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@Login", login);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Usuario(
                reader.GetString(1),
                reader.GetString(2),
                reader.GetString(3)
            );
        }

        return null;
    }

    public async Task<Usuario> AdicionarAsync(Usuario usuario)
    {
        const string sql = @"INSERT INTO Usuarios (Login, Senha, Tipo)
                             VALUES (@Login, @Senha, @Tipo);
                             SELECT SCOPE_IDENTITY();";

        using var connection = new SqlConnection(_connectionString);
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@Login", usuario.Login);
        command.Parameters.AddWithValue("@Senha", usuario.SenhaHash);
        command.Parameters.AddWithValue("@Tipo", usuario.Tipo);

        await connection.OpenAsync();
        var id = await command.ExecuteScalarAsync();

        usuario.GetType().GetProperty("Id")?.SetValue(usuario, Convert.ToInt32(id));
        return usuario;
    }
}