using Microsoft.Data.SqlClient;
using SistemaUBS.Domain.Constants;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Application.Interfaces;
using SistemaUBS.Infrastructure;

public class UsuarioRepository : IUsuarioRepository
{
    public async Task<Usuario?> ObterPorLoginAsync(string login)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, Login, SenhaHash, Tipo
                      FROM Usuarios
                      WHERE Login = @Login";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Login", login);

        using var reader = await cmd.ExecuteReaderAsync();

        if (await reader.ReadAsync())
        {
            return new Usuario
            {
                Id = reader.GetInt32(0),
                Login = reader.GetString(1),
                SenhaHash = reader.GetString(2),
                Tipo = reader.GetString(3)
            };
        }

        return null;
    }

    public async Task InserirAsync(Usuario usuario)
    {
        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"INSERT INTO Usuarios (Login, SenhaHash, Tipo)
                      VALUES (@Login, @SenhaHash, @Tipo)";

        using var cmd = new SqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@Login", usuario.Login);
        cmd.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
        cmd.Parameters.AddWithValue("@Tipo", usuario.Tipo);

        await cmd.ExecuteNonQueryAsync();
    }

    public async Task<List<Usuario>> ListarAsync()
    {
        var lista = new List<Usuario>();

        using var conn = DbConnectionFactory.Create();
        await conn.OpenAsync();

        var query = @"SELECT Id, Login, Senha, Tipo
                  FROM Usuarios";

        using var cmd = new SqlCommand(query, conn);
        using var reader = await cmd.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(new Usuario(
                reader.GetString(1), // Login
                reader.GetString(2), // Senha
                reader.GetString(3)  // Tipo
            )
            {
                Id = reader.GetInt32(0)
            });
        }

        return lista;
    }
}