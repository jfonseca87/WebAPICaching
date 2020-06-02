namespace WebAPICachingNet.Models
{
    using System.Data.Entity;

    public partial class CachingContext : DbContext
    {
        public CachingContext()
            : base("name=CachingContext")
        {
        }

        public virtual DbSet<TestTable1> TestTable1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TestTable1>()
                .Property(e => e.Field1)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable1>()
                .Property(e => e.Field2)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable1>()
                .Property(e => e.Field3)
                .IsUnicode(false);

            modelBuilder.Entity<TestTable1>()
                .Property(e => e.Field4)
                .IsUnicode(false);
        }
    }
}
