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

            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { Id = 0, Name = "TrgoFortuna", OIB = "00000000001", Mail = "trgo.fortuna@gmail.com", MobilePhone = "0910000000", Location = "Zrinjevac" },
                new Supplier { Id = 1, Name = "IGEPA Plana d.o.o.", OIB = "00000000002", Mail = "igepa.plana@gmail.com", MobilePhone = "0910000001", Location = "Ivana Brlić Mažuranić 1" },
                new Supplier { Id = 2, Name = "MojToner", OIB = "00000000003", Mail = "moj.toner@gmail.com", MobilePhone = "0910000002", Location = "Prečko 21" }
            );
            modelBuilder.Entity<Client>().HasData(
                new Client { Id = 0, Name = "Silvija Šesto", Adress = "Hebrangova 12", OIB = "0000000001", Phone = "0911010101", Email = "silvija.sesto@gmail.com" },
                new Client { Id = 1, Name = "Ognjište", Adress = "Masarikova 45", OIB = "0000000002", Phone = "09110292301", Email = "hdkdm@gmail.com" },
                new Client { Id = 2, Name = "Knjiga u centru", Adress = "Prečko 10", OIB = "0000000003", Phone = "0911393901", Email = "knjiga.u.centru@gmail.com" }
            );
            modelBuilder.Entity<Assignment>().HasData(
                new Assignment { Id = 0, Description = "Silvija Šesto, slikovnica", Format = "35x25", PaperType = "Offsetni", MachineType = "color", BookCover = "kolor", BookCoverPaperType = "Karton", BookCoverPlasticType = "Mat", BookCoverAdditional = "-", BookAdditional = "-", BindingType = "meki uvez" },
                new Assignment { Id = 1, Description = "Knjiga u centru, romani", Format = "40x30", PaperType = "Voluminozni", MachineType = "crno-bijeli", BookCover = "kolor", BookCoverPaperType = "Ljepenka", BookCoverPlasticType = "Sjaj", BookCoverAdditional = "-", BookAdditional = "-", BindingType = "meki uvez" }
            );

            modelBuilder.Entity<InputData>().HasData(
                new InputData() { Id = 0, NameOfAGood = "Papir 350gramski", SupplierId = 0, TypeOfAGood = "Papir", CountOfPeices = 2, KunaPerPeice = 300.0f },
                new InputData() { Id = 1, NameOfAGood = "Toneri crni", SupplierId = 2, TypeOfAGood = "Toner", CountOfPeices = 5, EuroPerPeice = 30.0f },
                new InputData() { Id = 2, NameOfAGood = "Papir 400gramski", SupplierId = 1, TypeOfAGood = "Paleta Papir", CountOfPeices = 1, TotalExpenceInKunas = 3055.0f }
            );
            modelBuilder.Entity<OutputData>().HasData(
                new OutputData() { Id = 0, BookName = "Tko je ubio pašteticu", ClientId = 0, BookCount = 200, Deadline = DateTime.Now, PackageCount = 20, CertifyDeliveryNote = false, Location = "Hebrangova 12", Contact = "0911010101"},
                new OutputData() { Id = 1, BookName = "Što ako?", ClientId = 2, BookCount = 200, Deadline = DateTime.Now, PackageCount = 20, CertifyDeliveryNote = false, Location = "Prečko 10", Contact = "0911393901"},
                new OutputData() { Id = 2, BookName = "Tugomila", ClientId = 1, BookCount = 200, Deadline = DateTime.Now, PackageCount = 20, CertifyDeliveryNote = false, Location = "Masarikova 45", Contact = "09110292301"}
            );
        }
    }
}