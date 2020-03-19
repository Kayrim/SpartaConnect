using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SpartaConnect_API.Models
{
    public partial class SpartaDBContext : DbContext
    {
        public SpartaDBContext()
        {
        }

        public SpartaDBContext(DbContextOptions<SpartaDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Consultant> Consultant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=SpartaDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Consultant>(entity =>
            {
                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.Bio).HasColumnType("text");

                entity.Property(e => e.CvLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Degree)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PhotoLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Stream)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.University)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.VideoLink)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
