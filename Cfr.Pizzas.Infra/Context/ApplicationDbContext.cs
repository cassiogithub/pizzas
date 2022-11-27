using Cfr.Pizzas.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Cfr.Pizzas.Infra.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Empresa> Empresa { get; set; }
        public DbSet<Pizza> Pizza{ get; set; }
        public DbSet<Ingrediente> Ingrediente { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
