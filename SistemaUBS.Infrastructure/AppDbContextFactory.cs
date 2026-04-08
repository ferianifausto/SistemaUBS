using Microsoft.Data.SqlClient;

namespace SistemaUBS.Infrastructure;

public static class DbConnectionFactory
{
    private static string connectionString =
        "Server=localhost\\SQLEXPRESS;Database=SistemaUBS;Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection Create()
    {
        return new SqlConnection(connectionString);
    }
}