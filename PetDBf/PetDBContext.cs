using Microsoft.EntityFrameworkCore;
using PetDB.Models;


namespace PetDB
{
    public class PetDBContext : DbContext
    {
        public DbSet<PetType> PetTypes => Set<PetType>();
        public DbSet<Gender> Genders => Set<Gender>();
        public DbSet<Pet> Pets => Set<Pet>();
        public DbSet<Client> Clients => Set<Client>();
        public DbSet<AdoptedPet> AdoptedPets => Set<AdoptedPet>();
        public PetDBContext()
        {
            //public PetDBContext() => Database.EnsureCreated();
            Database.EnsureCreated();
        }
        public PetDBContext(bool deleteDB = true)
        {
            //public PetDBContext() => Database.EnsureCreated();
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=appdb1;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdoptedPet>()
                .HasIndex(a => a.PetId)
                .IsUnique();

            modelBuilder.Entity<AdoptedPet>()
                .HasOne(a => a.Pet)
                .WithOne()
                .HasForeignKey<AdoptedPet>(a => a.PetId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
