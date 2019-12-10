using System.Linq;
using FarmaMed.DomainModel.MedicamentoAggregate;
using FarmaMed.Infra.Mappings;
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

            optionsBuilder.EnableSensitiveDataLogging(true);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new MedicamentoMapping());
            modelBuilder.ApplyConfiguration(new SintomaMapping());
            modelBuilder.ApplyConfiguration(new MedicamentoSintomaMapping());
            
            base.OnModelCreating(modelBuilder);
        }
    }
}
