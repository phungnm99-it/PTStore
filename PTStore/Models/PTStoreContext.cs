using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PTStore.Models
{
    public partial class PTStoreContext : DbContext
    {
        public PTStoreContext()
        {
        }

        public PTStoreContext(DbContextOptions<PTStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
        public virtual DbSet<DienThoai> DienThoais { get; set; }
        public virtual DbSet<DonHang> DonHangs { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<ThongSoKyThuat> ThongSoKyThuats { get; set; }
        public virtual DbSet<ThuongHieu> ThuongHieus { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserRole> UserRoles { get; set; }

        public virtual DbSet<Subcriber> Subcribers { get; set; }
        public virtual DbSet<GopY> GopY { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-9J29I14;Database=PTStore;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GopY>(entity =>
            {
                entity.ToTable("GopY");

                entity.Property(e => e.Email).IsUnicode(false);
                entity.Property(e => e.SoDienThoai).IsUnicode(false);
                //entity.Property(e => e.ChuDe).IsUnicode(true);
                //entity.Property(e => e.NoiDung).IsUnicode(true);

            });

            modelBuilder.Entity<Subcriber>(entity =>
            {
                entity.ToTable("Subcriber");

                entity.Property(e => e.Email).IsUnicode(false);
                entity.Property(e => e.TrangThai).IsUnicode(false);

            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.MatKhau).IsUnicode(false);

                entity.Property(e => e.TenDangNhap).IsUnicode(false);

                entity.Property(e => e.TrangThai).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Account__UserId__33D4B598");
            });

            modelBuilder.Entity<ChiTietDonHang>(entity =>
            {
                entity.HasKey(e => new { e.DonHangId, e.DienThoaiId })
                    .HasName("PK__ChiTietD__5230C8708940C081");

                entity.ToTable("ChiTietDonHang");

                entity.HasOne(d => d.DienThoai)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.DienThoaiId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietDo__DienT__35BCFE0A");

                entity.HasOne(d => d.DonHang)
                    .WithMany(p => p.ChiTietDonHangs)
                    .HasForeignKey(d => d.DonHangId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ChiTietDo__DonHa__34C8D9D1");
            });

            modelBuilder.Entity<DienThoai>(entity =>
            {
                entity.ToTable("DienThoai");

                entity.Property(e => e.HinhAnh).IsUnicode(false);

                entity.Property(e => e.TinhTrang).IsUnicode(false);

                entity.HasOne(d => d.ThongSoKyThuat)
                    .WithMany(p => p.DienThoais)
                    .HasForeignKey(d => d.ThongSoKyThuatId)
                    .HasConstraintName("FK__DienThoai__Thong__37A5467C");

                entity.HasOne(d => d.ThuongHieu)
                    .WithMany(p => p.DienThoais)
                    .HasForeignKey(d => d.ThuongHieuId)
                    .HasConstraintName("FK__DienThoai__Thuon__36B12243");
            });

            modelBuilder.Entity<DonHang>(entity =>
            {
                entity.ToTable("DonHang");

                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.HinhThucThanhToan).IsUnicode(false);

                entity.Property(e => e.MaDonHang).IsUnicode(false);

                entity.Property(e => e.NgayDatHang).HasColumnType("datetime");

                entity.Property(e => e.NgayDuKienGiao).HasColumnType("datetime");

                entity.Property(e => e.SoDienThoai).IsUnicode(false);

                entity.Property(e => e.TrangTrai).IsUnicode(false);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DonHangs)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__DonHang__UserId__38996AB5");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleName).IsUnicode(false);
            });

            modelBuilder.Entity<ThongSoKyThuat>(entity =>
            {
                entity.ToTable("ThongSoKyThuat");

                entity.Property(e => e.Cpu).HasColumnName("CPU");

                entity.Property(e => e.NgayRaMat).HasColumnType("datetime");

                entity.Property(e => e.Ram).HasColumnName("RAM");

                entity.HasOne(d => d.DienThoai)
                    .WithMany(p => p.ThongSoKyThuats)
                    .HasForeignKey(d => d.DienThoaiId)
                    .HasConstraintName("FK__ThongSoKy__DienT__398D8EEE");
            });

            modelBuilder.Entity<ThuongHieu>(entity =>
            {
                entity.ToTable("ThuongHieu");

                entity.Property(e => e.TenThuongHieu).IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email).IsUnicode(false);

                entity.Property(e => e.NgaySinh).HasColumnType("date");

                entity.Property(e => e.SoDienThoai).IsUnicode(false);

                entity.HasOne(d => d.Account)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AccountId)
                    .HasConstraintName("FK__Users__AccountId__3C69FB99");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.RoleId })
                    .HasName("PK__UserRole__AF2760AD84AD78A3");

                entity.ToTable("UserRole");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRole__RoleId__3B75D760");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__UserRole__UserId__3A81B327");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
