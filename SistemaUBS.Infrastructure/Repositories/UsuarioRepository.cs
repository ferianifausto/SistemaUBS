using Microsoft.Data.SqlClient;
using SistemaUBS.Application.Interfaces;
using SistemaUBS.Domain.Entities;
using SistemaUBS.Infrastructure;

namespace SistemaUBS.Infrastructure.Repositories;

public class UsuarioRepository : IUsuarioRepository
{
    public async Task<Usuario?> ObterPorLoginAsync(string login)
    {
        const string sql = @"
            SELECT Id, Login, SenhaHash, Tipo, DataCadastro, Ativo
            FROM Usuarios
            WHERE Login = @Login";

        using var connection = DbConnectionFactory.Create();
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@Login", login.ToLower().Trim());

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        if (await reader.ReadAsync())
            return MapearUsuario(reader);

        return null;
    }

    public async Task InserirAsync(Usuario usuario)
    {
        const string sql = @"
            INSERT INTO Usuarios (Login, SenhaHash, Tipo, DataCadastro, Ativo)
            VALUES (@Login, @SenhaHash, @Tipo, @DataCadastro, @Ativo)";

        using var connection = DbConnectionFactory.Create();
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@Login", usuario.Login.ToLower().Trim());
        command.Parameters.AddWithValue("@SenhaHash", usuario.SenhaHash);
        command.Parameters.AddWithValue("@Tipo", usuario.Tipo);
        command.Parameters.AddWithValue("@DataCadastro", usuario.DataCadastro);
        command.Parameters.AddWithValue("@Ativo", usuario.Ativo);

        await connection.OpenAsync();
        await command.ExecuteNonQueryAsync();
    }

    public async Task<bool> LoginExisteAsync(string login)
    {
        const string sql = "SELECT COUNT(*) FROM Usuarios WHERE Login = @Login";

        using var connection = DbConnectionFactory.Create();
        using var command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@Login", login.ToLower().Trim());

        await connection.OpenAsync();

        var count = Convert.ToInt32(await command.ExecuteScalarAsync());
        return count > 0;
    }

    public async Task<List<Usuario>> ListarAsync()
    {
        var lista = new List<Usuario>();

        const string sql = @"
            SELECT Id, Login, SenhaHash, Tipo, DataCadastro, Ativo
            FROM Usuarios";

        using var connection = DbConnectionFactory.Create();
        using var command = new SqlCommand(sql, connection);

        await connection.OpenAsync();
        using var reader = await command.ExecuteReaderAsync();

        while (await reader.ReadAsync())
        {
            lista.Add(MapearUsuario(reader));
        }

        return lista;
    }

    private static Usuario MapearUsuario(SqlDataReader reader)
    {
        return new Usuario
        {
            Id = reader.GetInt32(reader.GetOrdinal("Id")),
            Login = reader.GetString(reader.GetOrdinal("Login")),
            SenhaHash = reader.GetString(reader.GetOrdinal("SenhaHash")),
            Tipo = reader.GetString(reader.GetOrdinal("Tipo")),
            DataCadastro = reader.GetDateTime(reader.GetOrdinal("DataCadastro")),
            Ativo = reader.GetBoolean(reader.GetOrdinal("Ativo"))
        };
    }
}