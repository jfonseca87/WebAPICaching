using Microsoft.EntityFrameworkCore;

namespace WebAPICaching.Models
{
    public partial class TestContext : DbContext
    {
        public TestContext()
        {
        }

        public TestContext(DbContextOptions<TestContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Comments> Comments { get; set; }
        public virtual DbSet<People> People { get; set; }
        public virtual DbSet<TestTable1> TestTable1 { get; set; }
        public virtual DbSet<TestTable2> TestTable2 { get; set; }
        public virtual DbSet<TestTable3> TestTable3 { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comments>(entity =>
            {
                entity.Property(e => e.Comment)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonNavigation)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.IdPerson)
                    .HasConstraintName("FK__Comments__IdPers__5EBF139D");
            });

            modelBuilder.Entity<People>(entity =>
            {
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastNames)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Names)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestTable1>(entity =>
            {
                entity.Property(e => e.Field1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TestTable2>(entity =>
            {
                entity.Property(e => e.Field1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTestTable1Navigation)
                    .WithMany(p => p.TestTable2)
                    .HasForeignKey(d => d.IdTestTable1)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_TestTable2_TestTable1");
            });

            modelBuilder.Entity<TestTable3>(entity =>
            {
                entity.Property(e => e.Field1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Field4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTestTable2Navigation)
                    .WithMany(p => p.TestTable3)
                    .HasForeignKey(d => d.IdTestTable2)
                    .HasConstraintName("FK_TestTable2_TestTable3");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
