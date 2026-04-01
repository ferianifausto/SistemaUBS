namespace SistemaUBS.UI;

using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SistemaUBS.Infrastructure.Config;
using System;
using System.Threading.Tasks;



internal class Program
{
  
    static async Task Main()
    {
        Console.WriteLine("Sistema Iniciado");

        var options = new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer("Server=SMP0581301W10-1;Database=UBS;Trusted_Connection=True;TrustServerCertificate=True;")
    .Options;
        var connectionString = DbContext.ConnectionString;

        using var connection = new SqlConnection(connectionString);

        try
        {
            await connection.OpenAsync();
            Console.WriteLine("Conectou com sucesso 🔥");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao conectar:");
            Console.WriteLine(ex.Message);
        }
    }
}