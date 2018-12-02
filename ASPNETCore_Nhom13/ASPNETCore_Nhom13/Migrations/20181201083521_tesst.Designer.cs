﻿// <auto-generated />
using System;
using ASPNETCore_Nhom13.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ASPNETCore_Nhom13.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20181201083521_tesst")]
    partial class tesst
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.3-rtm-32065")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ASPNETCore_Nhom13.Models.NguoiDung", b =>
                {
                    b.Property<int>("MaNguoiDung")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HoTen")
                        .IsRequired();

                    b.Property<string>("MatKhau")
                        .IsRequired();

                    b.HasKey("MaNguoiDung");

                    b.ToTable("NguoiDungs");
                });

            modelBuilder.Entity("ASPNETCore_Nhom13.Models.TinTuc", b =>
                {
                    b.Property<int>("MaTin")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hinh");

                    b.Property<int>("MaNguoiDung");

                    b.Property<int>("MaTheLoai");

                    b.Property<DateTime>("NgayDang");

                    b.Property<string>("NoiDung")
                        .IsRequired();

                    b.Property<string>("TieuDe")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("TrangThai");

                    b.HasKey("MaTin");

                    b.HasIndex("MaNguoiDung");

                    b.HasIndex("MaTheLoai");

                    b.ToTable("TinTucs");
                });

            modelBuilder.Entity("ASPNETCore_Nhom13.Models.TheLoai", b =>
                {
                    b.Property<int>("MaTheLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenTheLoai")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaTheLoai");

                    b.ToTable("TheLoais");
                });

            modelBuilder.Entity("ASPNETCore_Nhom13.Models.TinTuc", b =>
                {
                    b.HasOne("ASPNETCore_Nhom13.Models.NguoiDung", "NguoiDung")
                        .WithMany()
                        .HasForeignKey("MaNguoiDung")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ASPNETCore_Nhom13.Models.TheLoai", "TheLoai")
                        .WithMany()
                        .HasForeignKey("MaTheLoai")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
