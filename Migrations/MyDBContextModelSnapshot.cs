﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nhom10_MidTermDotNet.Models;

namespace Nhom10_MidTermDotNet.Migrations
{
    [DbContext(typeof(MyDBContext))]
    partial class MyDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Nhom10_MidTermDotNet.Models.KetQua", b =>
                {
                    b.Property<int>("MaKetQua")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Diem");

                    b.Property<int>("MaMon");

                    b.Property<int>("MaSV");

                    b.HasKey("MaKetQua");

                    b.ToTable("KetQua");
                });

            modelBuilder.Entity("Nhom10_MidTermDotNet.Models.Khoa", b =>
                {
                    b.Property<int>("MaKhoa")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenKhoa");

                    b.HasKey("MaKhoa");

                    b.ToTable("Khoa");
                });

            modelBuilder.Entity("Nhom10_MidTermDotNet.Models.MonHoc", b =>
                {
                    b.Property<int>("MaMon")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("SoTinChi");

                    b.Property<string>("TenMon");

                    b.HasKey("MaMon");

                    b.ToTable("MonHoc");
                });

            modelBuilder.Entity("Nhom10_MidTermDotNet.Models.SinhVien", b =>
                {
                    b.Property<int>("MaSV")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HoTen")
                        .HasMaxLength(100);

                    b.Property<DateTime>("NgaySinh");

                    b.HasKey("MaSV");

                    b.ToTable("SinhVien");
                });
#pragma warning restore 612, 618
        }
    }
}
