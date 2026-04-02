using Microsoft.EntityFrameworkCore;
using SistemaUBS.Domain.Entities;

namespace SistemaUBS.Infrastructure.Config;

//public static class DbConfig
//{
//public static string ConnectionString = "Server=SMP0581301W10-1;Database=UBS;Trusted_Connection=True;TrustServerCertificate=True;";
//}

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Paciente> Pacientes { get; set; }
    public DbSet<Medico> Medicos { get; set; }
 
    public DbSet<Consulta> Consultas { get; set; }

    public DbSet<Exame> Exames { get; set; }

    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { 
    }
}