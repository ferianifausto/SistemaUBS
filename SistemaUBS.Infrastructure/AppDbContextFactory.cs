using Microsoft.Data.SqlClient;

namespace SistemaUBS.Infrastructure;

public static class DbConnectionFactory
{
    private static string connectionString =
        "Server=SMP0581301W10-1;Database=SistemaUBS;Trusted_Connection=True;TrustServerCertificate=True;";

    public static SqlConnection Create()
    {
        return new SqlConnection(connectionString);
    }
}