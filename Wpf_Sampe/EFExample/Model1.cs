namespace EFExample
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=ExamleModel")
        {
        }

        public virtual DbSet<ADDRESS> ADDRESS { get; set; }
        public virtual DbSet<PERSON> PERSON { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ADDRESS>()
                .Property(e => e.STREET)
                .IsUnicode(false);

            modelBuilder.Entity<ADDRESS>()
                .Property(e => e.HOUSENUMBER)
                .IsUnicode(false);

            modelBuilder.Entity<ADDRESS>()
                .Property(e => e.ZIP)
                .IsUnicode(false);

            modelBuilder.Entity<ADDRESS>()
                .Property(e => e.CITY)
                .IsUnicode(false);

            modelBuilder.Entity<ADDRESS>()
                .HasMany(e => e.PERSON)
                .WithOptional(e => e.ADDRESS)
                .HasForeignKey(e => e.ID_ADDRESS);

            modelBuilder.Entity<PERSON>()
                .Property(e => e.VORNAME)
                .IsUnicode(false);

            modelBuilder.Entity<PERSON>()
                .Property(e => e.NACHNAME)
                .IsUnicode(false);
        }
    }
}
