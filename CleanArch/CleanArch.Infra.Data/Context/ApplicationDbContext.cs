using CleanArch.Domain.Entities;
using CleanArch.Infra.Data.EntityConfigurarion;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Context
{
    /// <summary>Contexto do EF Core: Identity + DbSet de Product. Configuração aplicada via ProductConfiguration.</summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ProductConfiguration());
        }
    }
}
