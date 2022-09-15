using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EmployeeDALirary.Models
{
    public partial class dbRecruitContext : DbContext
    {
        public dbRecruitContext()
        {
        }

        public dbRecruitContext(DbContextOptions<dbRecruitContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblProfile> TblProfiles { get; set; } = null!;
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DISYS-HXGS3H2\\SQLEXPRESS;Integrated security=true;Initial Catalog=dbRecruitSep2022");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblProfile>(entity =>
            {
                entity.ToTable("tblProfile");

                entity.Property(e => e.Age).HasDefaultValueSql("((18))");

                entity.Property(e => e.CurrentCtc).HasColumnName("CurrentCTC");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Qualification)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("username");

               
            });

            

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
