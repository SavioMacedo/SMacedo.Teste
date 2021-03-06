using Microsoft.EntityFrameworkCore;
using SMacedo.Teste.Domain.Contracts;
using SMacedo.Teste.Domain.Entities;
using SMacedo.Teste.Infra.SQLServerClient.Configurations;
using System.Diagnostics.CodeAnalysis;

namespace SMacedo.Teste.Infra.SQLServerClient.SqlClient
{
    [ExcludeFromCodeCoverage]
    public class LeadsContext: DbContext, ILeadsContext
    {
        public LeadsContext(DbContextOptions<LeadsContext> options) : base(options) { }

        public DbSet<Lead> Leads { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new LeadsEntityTypeConfiguration());
        }
    }
}
