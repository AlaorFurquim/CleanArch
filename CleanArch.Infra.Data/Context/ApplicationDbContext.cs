using CleanArch.Domain.Entities;
using CleanArch.Infra.Data.EntitiesConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArch.Infra.Data.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Corre a aplicação para encontrar os arquivos que possuem configurações pré estabelecidas, nesse caso, os arquivos na pasta EntitiesConfiguratiom
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

            // Forma de fazer individualmente
            //modelBuilder.ApplyConfiguration(new CategoryConfiguration);
        }
    }
}
