﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StudentAdministrationERP.Data;

namespace StudentAdministrationERP.Migrations
{
    [DbContext(typeof(StudentAdministrationERPDbContext))]
    [Migration("20221117193450_AddeddAssesmentTable")]
    partial class AddeddAssesmentTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("StudentAdministrationERP.Models.Assessment", b =>
                {
                    b.Property<Guid>("Assessment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Assessment_Mark")
                        .HasColumnType("float");

                    b.Property<string>("Assessment_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Degree_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<Guid>("Module_Id")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Assessment_Id");

                    b.HasIndex("Degree_Id");

                    b.HasIndex("Module_Id");

                    b.ToTable("Assessment");
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Degree", b =>
                {
                    b.Property<string>("Degree_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NoOfYears")
                        .HasColumnType("int");

                    b.HasKey("Degree_Id");

                    b.ToTable("Degree");
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Enrolment", b =>
                {
                    b.Property<Guid>("Enrolment_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Module_Code")
                        .HasColumnType("int");

                    b.Property<string>("Student_Id")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Enrolment_Id");

                    b.HasIndex("Student_Id");

                    b.ToTable("Enrolment");
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Module", b =>
                {
                    b.Property<Guid>("Module_Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Degree_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Module_Code")
                        .HasColumnType("int");

                    b.Property<string>("Module_Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isCompulsory")
                        .HasColumnType("bit");

                    b.HasKey("Module_Id");

                    b.HasIndex("Degree_Id");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Student", b =>
                {
                    b.Property<string>("Student_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Degree_Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isEnrolled")
                        .HasColumnType("bit");

                    b.HasKey("Student_Id");

                    b.HasIndex("Degree_Id");

                    b.ToTable("Student");
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Assessment", b =>
                {
                    b.HasOne("StudentAdministrationERP.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("Degree_Id");

                    b.HasOne("StudentAdministrationERP.Models.Module", "Module")
                        .WithMany()
                        .HasForeignKey("Module_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Enrolment", b =>
                {
                    b.HasOne("StudentAdministrationERP.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("Student_Id");
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Module", b =>
                {
                    b.HasOne("StudentAdministrationERP.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("Degree_Id");
                });

            modelBuilder.Entity("StudentAdministrationERP.Models.Student", b =>
                {
                    b.HasOne("StudentAdministrationERP.Models.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("Degree_Id");
                });
#pragma warning restore 612, 618
        }
    }
}
