using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Kodinet.Models
{
    public partial class KodinetDbContext : DbContext
    {
        public KodinetDbContext()
        {
        }

        public KodinetDbContext(DbContextOptions<KodinetDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<DrivingLicences> DrivingLicences { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }
        public virtual DbSet<Author> Authors { get; set; }
        public virtual DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string cn = @"Data Source=.;Initial Catalog=KodinetDb2;Integrated Security=True";
            optionsBuilder.UseSqlServer(cn);

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DrivingLicences>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();
               

                entity.Property(e => e.ExpirationDate).HasColumnName("expirationDate");


               
            });

            
        }
    }
}
