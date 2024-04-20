using System;
using System.Collections.Generic;
using DBFirst_lehabinh.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace DBFirst_lehabinh.Repository;

public partial class SinhVienDBFirstDbContext : DbContext
{
    public SinhVienDBFirstDbContext()
    {
    }

    public SinhVienDBFirstDbContext(DbContextOptions<SinhVienDBFirstDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Khoa> Khoas { get; set; }

    public virtual DbSet<Lop> Lops { get; set; }

    public virtual DbSet<SinhVien> SinhViens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=DESKTOP-HNPPA00\\SQLEXPRESS;Initial Catalog=SinhVienDBFirst;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Khoa>(entity =>
        {
            entity.HasKey(e => e.KhoaId).HasName("PK__Khoa__42EDDFF4D02C5CD3");

            entity.Property(e => e.KhoaId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Lop>(entity =>
        {
            entity.HasKey(e => e.LopId).HasName("PK__Lop__40585D2B953CEA6B");

            entity.Property(e => e.LopId).ValueGeneratedNever();

            entity.HasOne(d => d.Khoa).WithMany(p => p.Lops).HasConstraintName("FK__Lop__KhoaId__398D8EEE");
        });

        modelBuilder.Entity<SinhVien>(entity =>
        {
            entity.HasKey(e => e.SinhVienId).HasName("PK__SinhVien__F3CF814EF35F1624");

            entity.Property(e => e.SinhVienId).ValueGeneratedNever();

            entity.HasOne(d => d.Lop).WithMany(p => p.SinhViens).HasConstraintName("FK__SinhVien__LopId__3C69FB99");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
