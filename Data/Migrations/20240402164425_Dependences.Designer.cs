﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mng.Data;

#nullable disable

namespace Mng.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240402164425_Dependences")]
    partial class Dependences
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Mng.Core.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EmployeeRolesId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsMale")
                        .HasColumnType("bit");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<string>("TZ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeRolesId");

                    b.ToTable("employees");
                });

            modelBuilder.Entity("Mng.Core.Entities.EmployeeRoles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.HasKey("Id");

                    b.ToTable("EmployeeRoles");
                });

            modelBuilder.Entity("Mng.Core.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("EmployeeRolesId")
                        .HasColumnType("int");

                    b.Property<bool>("IsManagement")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartRole")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeRolesId");

                    b.ToTable("roles");
                });

            modelBuilder.Entity("Mng.Core.Employee", b =>
                {
                    b.HasOne("Mng.Core.Entities.EmployeeRoles", "EmployeeRoles")
                        .WithMany("Employees")
                        .HasForeignKey("EmployeeRolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeRoles");
                });

            modelBuilder.Entity("Mng.Core.Role", b =>
                {
                    b.HasOne("Mng.Core.Entities.EmployeeRoles", "EmployeeRoles")
                        .WithMany("Roles")
                        .HasForeignKey("EmployeeRolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EmployeeRoles");
                });

            modelBuilder.Entity("Mng.Core.Entities.EmployeeRoles", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
