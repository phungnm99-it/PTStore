﻿//// <auto-generated />
//using System;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Infrastructure;
//using Microsoft.EntityFrameworkCore.Metadata;
//using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
//using PTStore.Models;

//namespace PTStore.Migrations
//{
//    [DbContext(typeof(PTStoreContext))]
//    partial class PTStoreContextModelSnapshot : ModelSnapshot
//    {
//        protected override void BuildModel(ModelBuilder modelBuilder)
//        {
//#pragma warning disable 612, 618
//            modelBuilder
//                .UseIdentityColumns()
//                .HasAnnotation("Relational:MaxIdentifierLength", 128)
//                .HasAnnotation("ProductVersion", "5.0.0");

//            modelBuilder.Entity("PTStore.Models.Account", b =>
//                {
//                    b.Property<int>("AccountId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<string>("MatKhau")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("TenDangNhap")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("TrangThai")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<int?>("UserId")
//                        .HasColumnType("int");

//                    b.HasKey("AccountId");

//                    b.HasIndex("UserId");

//                    b.ToTable("Account");
//                });

//            modelBuilder.Entity("PTStore.Models.ChiTietDonHang", b =>
//                {
//                    b.Property<int>("DonHangId")
//                        .HasColumnType("int");

//                    b.Property<int>("DienThoaiId")
//                        .HasColumnType("int");

//                    b.Property<double?>("Gia")
//                        .HasColumnType("float");

//                    b.Property<int?>("SoLuong")
//                        .HasColumnType("int");

//                    b.HasKey("DonHangId", "DienThoaiId")
//                        .HasName("PK__ChiTietD__5230C8708940C081");

//                    b.HasIndex("DienThoaiId");

//                    b.ToTable("ChiTietDonHang");
//                });

//            modelBuilder.Entity("PTStore.Models.DienThoai", b =>
//                {
//                    b.Property<int>("DienThoaiId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<double?>("Gia")
//                        .HasColumnType("float");

//                    b.Property<double?>("GiaGoc")
//                        .HasColumnType("float");

//                    b.Property<string>("HinhAnh")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("Name")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<int?>("SoLuong")
//                        .HasColumnType("int");

//                    b.Property<int?>("ThongSoKyThuatId")
//                        .HasColumnType("int");

//                    b.Property<int?>("ThuongHieuId")
//                        .HasColumnType("int");

//                    b.Property<string>("TinhTrang")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.HasKey("DienThoaiId");

//                    b.HasIndex("ThongSoKyThuatId");

//                    b.HasIndex("ThuongHieuId");

//                    b.ToTable("DienThoai");
//                });

//            modelBuilder.Entity("PTStore.Models.DonHang", b =>
//                {
//                    b.Property<int>("DonHangId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<string>("DiaChi")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Email")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("HinhThucThanhToan")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("MaDonHang")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<DateTime?>("NgayDatHang")
//                        .HasColumnType("datetime");

//                    b.Property<DateTime?>("NgayDuKienGiao")
//                        .HasColumnType("datetime");

//                    b.Property<string>("SoDienThoai")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("TenNguoiNhan")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("TrangTrai")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<int?>("UserId")
//                        .HasColumnType("int");

//                    b.HasKey("DonHangId");

//                    b.HasIndex("UserId");

//                    b.ToTable("DonHang");
//                });

//            modelBuilder.Entity("PTStore.Models.GopY", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<string>("ChuDe")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Email")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("NoiDung")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("SoDienThoai")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("GopY");
//                });

//            modelBuilder.Entity("PTStore.Models.Role", b =>
//                {
//                    b.Property<int>("RoleId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<string>("RoleName")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.HasKey("RoleId");

//                    b.ToTable("Role");
//                });

//            modelBuilder.Entity("PTStore.Models.Subcriber", b =>
//                {
//                    b.Property<int>("Id")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<string>("Email")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("TrangThai")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.HasKey("Id");

//                    b.ToTable("Subcriber");
//                });

//            modelBuilder.Entity("PTStore.Models.ThongSoKyThuat", b =>
//                {
//                    b.Property<int>("ThongSoKyThuatId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<string>("BoNhoTrong")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("CameraSau")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("CameraTruoc")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Cpu")
//                        .HasColumnType("nvarchar(max)")
//                        .HasColumnName("CPU");

//                    b.Property<int?>("DienThoaiId")
//                        .HasColumnType("int");

//                    b.Property<string>("DungLuongPin")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("HeDieuHanh")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("ManHinh")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<DateTime?>("NgayRaMat")
//                        .HasColumnType("datetime");

//                    b.Property<string>("Ram")
//                        .HasColumnType("nvarchar(max)")
//                        .HasColumnName("RAM");

//                    b.Property<string>("TheSim")
//                        .HasColumnType("nvarchar(max)");

//                    b.HasKey("ThongSoKyThuatId");

//                    b.HasIndex("DienThoaiId");

//                    b.ToTable("ThongSoKyThuat");
//                });

//            modelBuilder.Entity("PTStore.Models.ThuongHieu", b =>
//                {
//                    b.Property<int>("ThuongHieuId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<string>("TenThuongHieu")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.HasKey("ThuongHieuId");

//                    b.ToTable("ThuongHieu");
//                });

//            modelBuilder.Entity("PTStore.Models.User", b =>
//                {
//                    b.Property<int>("UserId")
//                        .ValueGeneratedOnAdd()
//                        .HasColumnType("int")
//                        .UseIdentityColumn();

//                    b.Property<int?>("AccountId")
//                        .HasColumnType("int");

//                    b.Property<string>("DiaChi")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("Email")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.Property<string>("GioiTinh")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<string>("HoVaTen")
//                        .HasColumnType("nvarchar(max)");

//                    b.Property<DateTime?>("NgaySinh")
//                        .HasColumnType("date");

//                    b.Property<string>("SoDienThoai")
//                        .IsUnicode(false)
//                        .HasColumnType("varchar(max)");

//                    b.HasKey("UserId");

//                    b.HasIndex("AccountId");

//                    b.ToTable("Users");
//                });

//            modelBuilder.Entity("PTStore.Models.UserRole", b =>
//                {
//                    b.Property<int>("UserId")
//                        .HasColumnType("int");

//                    b.Property<int>("RoleId")
//                        .HasColumnType("int");

//                    b.HasKey("UserId", "RoleId")
//                        .HasName("PK__UserRole__AF2760AD84AD78A3");

//                    b.HasIndex("RoleId");

//                    b.ToTable("UserRole");
//                });

//            modelBuilder.Entity("PTStore.Models.Account", b =>
//                {
//                    b.HasOne("PTStore.Models.User", "User")
//                        .WithMany("Accounts")
//                        .HasForeignKey("UserId")
//                        .HasConstraintName("FK__Account__UserId__33D4B598");

//                    b.Navigation("User");
//                });

//            modelBuilder.Entity("PTStore.Models.ChiTietDonHang", b =>
//                {
//                    b.HasOne("PTStore.Models.DienThoai", "DienThoai")
//                        .WithMany("ChiTietDonHangs")
//                        .HasForeignKey("DienThoaiId")
//                        .HasConstraintName("FK__ChiTietDo__DienT__35BCFE0A")
//                        .IsRequired();

//                    b.HasOne("PTStore.Models.DonHang", "DonHang")
//                        .WithMany("ChiTietDonHangs")
//                        .HasForeignKey("DonHangId")
//                        .HasConstraintName("FK__ChiTietDo__DonHa__34C8D9D1")
//                        .IsRequired();

//                    b.Navigation("DienThoai");

//                    b.Navigation("DonHang");
//                });

//            modelBuilder.Entity("PTStore.Models.DienThoai", b =>
//                {
//                    b.HasOne("PTStore.Models.ThongSoKyThuat", "ThongSoKyThuat")
//                        .WithMany("DienThoais")
//                        .HasForeignKey("ThongSoKyThuatId")
//                        .HasConstraintName("FK__DienThoai__Thong__37A5467C");

//                    b.HasOne("PTStore.Models.ThuongHieu", "ThuongHieu")
//                        .WithMany("DienThoais")
//                        .HasForeignKey("ThuongHieuId")
//                        .HasConstraintName("FK__DienThoai__Thuon__36B12243");

//                    b.Navigation("ThongSoKyThuat");

//                    b.Navigation("ThuongHieu");
//                });

//            modelBuilder.Entity("PTStore.Models.DonHang", b =>
//                {
//                    b.HasOne("PTStore.Models.User", "User")
//                        .WithMany("DonHangs")
//                        .HasForeignKey("UserId")
//                        .HasConstraintName("FK__DonHang__UserId__38996AB5");

//                    b.Navigation("User");
//                });

//            modelBuilder.Entity("PTStore.Models.ThongSoKyThuat", b =>
//                {
//                    b.HasOne("PTStore.Models.DienThoai", "DienThoai")
//                        .WithMany("ThongSoKyThuats")
//                        .HasForeignKey("DienThoaiId")
//                        .HasConstraintName("FK__ThongSoKy__DienT__398D8EEE");

//                    b.Navigation("DienThoai");
//                });

//            modelBuilder.Entity("PTStore.Models.User", b =>
//                {
//                    b.HasOne("PTStore.Models.Account", "Account")
//                        .WithMany("Users")
//                        .HasForeignKey("AccountId")
//                        .HasConstraintName("FK__Users__AccountId__3C69FB99");

//                    b.Navigation("Account");
//                });

//            modelBuilder.Entity("PTStore.Models.UserRole", b =>
//                {
//                    b.HasOne("PTStore.Models.Role", "Role")
//                        .WithMany("UserRoles")
//                        .HasForeignKey("RoleId")
//                        .HasConstraintName("FK__UserRole__RoleId__3B75D760")
//                        .IsRequired();

//                    b.HasOne("PTStore.Models.User", "User")
//                        .WithMany("UserRoles")
//                        .HasForeignKey("UserId")
//                        .HasConstraintName("FK__UserRole__UserId__3A81B327")
//                        .IsRequired();

//                    b.Navigation("Role");

//                    b.Navigation("User");
//                });

//            modelBuilder.Entity("PTStore.Models.Account", b =>
//                {
//                    b.Navigation("Users");
//                });

//            modelBuilder.Entity("PTStore.Models.DienThoai", b =>
//                {
//                    b.Navigation("ChiTietDonHangs");

//                    b.Navigation("ThongSoKyThuats");
//                });

//            modelBuilder.Entity("PTStore.Models.DonHang", b =>
//                {
//                    b.Navigation("ChiTietDonHangs");
//                });

//            modelBuilder.Entity("PTStore.Models.Role", b =>
//                {
//                    b.Navigation("UserRoles");
//                });

//            modelBuilder.Entity("PTStore.Models.ThongSoKyThuat", b =>
//                {
//                    b.Navigation("DienThoais");
//                });

//            modelBuilder.Entity("PTStore.Models.ThuongHieu", b =>
//                {
//                    b.Navigation("DienThoais");
//                });

//            modelBuilder.Entity("PTStore.Models.User", b =>
//                {
//                    b.Navigation("Accounts");

//                    b.Navigation("DonHangs");

//                    b.Navigation("UserRoles");
//                });
//#pragma warning restore 612, 618
//        }
//    }
//}
