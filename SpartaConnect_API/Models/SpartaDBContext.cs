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

        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Consultant> Consultant { get; set; }
        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<Trainer> Trainer { get; set; }
        public virtual DbSet<TrainerCourses> TrainerCourses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Initial Catalog=SpartaDB;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Consultant>(entity =>
            {
                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.Bio).HasColumnType("text");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

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

                entity.Property(e => e.Photo)
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

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.Consultant)
                    .HasForeignKey(d => d.CourseId)
                    .HasConstraintName("FK__Consultan__Cours__2A4B4B5E");
            });

            modelBuilder.Entity<Course>(entity =>
            {
                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.CatgeoryId).HasColumnName("CatgeoryID");

                entity.Property(e => e.CourseDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CourseName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LengthOfCourse)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.Catgeory)
                    .WithMany(p => p.Course)
                    .HasForeignKey(d => d.CatgeoryId)
                    .HasConstraintName("FK__Course__Catgeory__276EDEB3");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ConsultantId).HasColumnName("ConsultantID");

                entity.Property(e => e.ProjectDescription)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Consultant)
                    .WithMany(p => p.Project)
                    .HasForeignKey(d => d.ConsultantId)
                    .HasConstraintName("FK__Project__Consult__2D27B809");
            });

            modelBuilder.Entity<Trainer>(entity =>
            {
                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.Property(e => e.Bio)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Photo)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainerCourses>(entity =>
            {
                entity.HasKey(e => new { e.CourseId, e.TrainerId })
                    .HasName("PK__TrainerC__1A4BD03EFC2E8CF4");

                entity.Property(e => e.CourseId).HasColumnName("CourseID");

                entity.Property(e => e.TrainerId).HasColumnName("TrainerID");

                entity.HasOne(d => d.Course)
                    .WithMany(p => p.TrainerCourses)
                    .HasForeignKey(d => d.CourseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TrainerCo__Cours__30F848ED");

                entity.HasOne(d => d.Trainer)
                    .WithMany(p => p.TrainerCourses)
                    .HasForeignKey(d => d.TrainerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__TrainerCo__Train__300424B4");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
