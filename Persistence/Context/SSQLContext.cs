using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence.Context.EntityConfiguration;

namespace Persistence.Context;

public class SSQLContext : DbContext
{
    protected readonly IConfiguration configuration;
    public SSQLContext(IConfiguration configuration)
    {
        this.configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(configuration.GetConnectionString("ContextSSQL"));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        TransactionEntityConfiguration.Configuration(modelBuilder);
    }

    public DbSet<TransactionEntity> Transaction { get; set; }
}
