using Microsoft.EntityFrameworkCore;
using CoreBusiness;

namespace Plugins.Data.SQL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<InputData> InputDatas { get; set; }
        public DbSet<OutputData> OutputDatas { get; set; }
        public DbSet<WorkOrder> WorkOrders { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<InputData>()
                .HasOne<Supplier>(c => c.Supplier)
                .WithOne(d => d.InputData)
                .HasForeignKey<InputData>(e => e.SupplierId);

            modelBuilder.Entity<OutputData>()
                .HasOne<Client>(c => c.Client)
                .WithOne(d => d.OutputData)
                .HasForeignKey<OutputData>(e => e.ClientId);

            modelBuilder.Entity<WorkOrder>()
                .HasOne<Client>(c => c.Client)
                .WithOne(d => d.WorkOrder)
                .HasForeignKey<WorkOrder>(e => e.ClientId);

            modelBuilder.Entity<WorkOrder>()
                .HasOne<Assignment>(c => c.Assignment)
                .WithOne(d => d.WorkOrder)
                .HasForeignKey<WorkOrder>(e => e.AssignmentId);
        }
    }
}