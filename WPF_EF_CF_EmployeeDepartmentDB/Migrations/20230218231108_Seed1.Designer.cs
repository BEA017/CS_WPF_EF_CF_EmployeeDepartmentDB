﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WPF_EF_CF_EmployeeDepartmentDB;

#nullable disable

namespace WPF_EF_CF_EmployeeDepartmentDB.Migrations
{
    [DbContext(typeof(MyDataContext))]
    [Migration("20230218231108_Seed1")]
    partial class Seed1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("WPF_EF_CF_EmployeeDepartmentDB.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HeadId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12)
                        .HasColumnType("nvarchar(12)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("WPF_EF_CF_EmployeeDepartmentDB.Models.DepartmentsEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId", "DepartmentId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentsEmployees");
                });

            modelBuilder.Entity("WPF_EF_CF_EmployeeDepartmentDB.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Age")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("WPF_EF_CF_EmployeeDepartmentDB.Models.DepartmentsEmployee", b =>
                {
                    b.HasOne("WPF_EF_CF_EmployeeDepartmentDB.Models.Department", "Departments")
                        .WithMany("DepartmentsEmployees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WPF_EF_CF_EmployeeDepartmentDB.Models.Employee", "Employees")
                        .WithMany("DepartmentsEmployees")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departments");

                    b.Navigation("Employees");
                });

            modelBuilder.Entity("WPF_EF_CF_EmployeeDepartmentDB.Models.Department", b =>
                {
                    b.Navigation("DepartmentsEmployees");
                });

            modelBuilder.Entity("WPF_EF_CF_EmployeeDepartmentDB.Models.Employee", b =>
                {
                    b.Navigation("DepartmentsEmployees");
                });
#pragma warning restore 612, 618
        }
    }
}
