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
        Console.WriteLine("Sistema iniciado");

        var options = new DbContextOptionsBuilder<AppDbContext>()
            .UseSqlServer("Server=SMP0581301W10-1;Database=UBS;Trusted_Connection=True;TrustServerCertificate=True;")
            .Options;

        var context = new AppDbContext(options);

        try
        {
            // Testa conexão via EF
            var conectado = await context.Database.CanConnectAsync();

            if (conectado)
                Console.WriteLine("Conectou com sucesso 🔥");
            else
                Console.WriteLine("Não conseguiu conectar");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao conectar:");
            Console.WriteLine(ex.Message);
        }
    }
}