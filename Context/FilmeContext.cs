using csharp_api.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace csharp_api.Context
{
    public class FilmeContext : DbContext
    {
        readonly NpgsqlConnectionStringBuilder cs = new()
        {
            Host = "localhost",
            Database = "alura",
            Username = "postgres",
            Password = "P@ssw0rd",
            Pooling = false
        };
        
        public DbSet<Filme> Filmes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseNpgsql(cs.ConnectionString);
    }
}