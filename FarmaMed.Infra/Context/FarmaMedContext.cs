using System.Linq;
using FarmaMed.DomainModel.MedicamentoAggregate;
using FarmaMed.Infra.Properties;
using Microsoft.EntityFrameworkCore;

namespace FarmaMed.Infra.Context
{
    public class FarmaMedContext : DbContext
    {
        private static bool _Created = false;
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Sintoma> Sintomas { get; set; }

        public FarmaMedContext(DbContextOptions options) : base(options)
        {
            if (!_Created)
            {
                _Created = true;
                Database.EnsureCreated();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //optionsBuilder.EnableDetailedErrors(true);
            optionsBuilder.EnableSensitiveDataLogging(true);
            //optionsBuilder.UseSqlServer(Resources.DbConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetProperties()
            //     .Where(p => p.ClrType == typeof(string))))
            //    property.SetColumnType("varchar(100)");

            //modelBuilder.ApplyConfigurationsFromAssembly(typeof(FarmaMedContext).Assembly);

            //foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);

        }
    }
}
