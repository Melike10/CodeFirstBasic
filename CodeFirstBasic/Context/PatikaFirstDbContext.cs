using CodeFirstBasic.Entities;
using Microsoft.EntityFrameworkCore;

namespace CodeFirstBasic.Context
{
    public class PatikaFirstDbContext:DbContext
    {
        //ctor a generic bir parametre vereceğiz DbContextOptions diye bu dbcontext sınıfındaki verilerle veritabanı yapılandırılmasını ayarlayacak.
        public PatikaFirstDbContext(DbContextOptions<PatikaFirstDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Movie>(entitiy=>
            {
                entitiy.ToTable("Movies");
                entitiy.HasKey(e=>e.Id);
                entitiy.Property(e=>e.Title).IsRequired();
                entitiy.Property(e=>e.Genre).IsRequired().HasMaxLength(100);
            });

            modelBuilder.Entity<Game>(entitiy =>
            {
                entitiy.ToTable("Games");
                entitiy.HasKey(e=> e.Id);
                entitiy.Property(e=>e.Name).IsRequired().HasMaxLength(100);
                entitiy.Property(e=>e.Platform).IsRequired().HasMaxLength(50);
                entitiy.Property(e => e.Rating).HasColumnType("decimal(8,2)");
            });
        }
    }
}
