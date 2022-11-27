using Cfr.Pizzas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cfr.Pizzas.Infra.Context
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseSqlServer("Server = 127.0.0.1, 1433; Database = pizzas; User Id = sa; Password = Senha123!; Encrypt = False;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}
