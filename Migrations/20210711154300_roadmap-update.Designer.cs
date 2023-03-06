﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xZoneAPI.Data;

namespace xZoneAPI.Migrations
{
    [DbContext(typeof(ApplicationDBContext))]
    [Migration("20210711154300_roadmap-update")]
    partial class roadmapupdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("xZoneAPI.Models.Accounts.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("xZoneAPI.Models.ProjectModel.Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OwnerID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OwnerID");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("xZoneAPI.Models.ProjectTaskModel.ProjectTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("CompleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Remainder")
                        .HasColumnType("datetime2");

                    b.Property<int>("SectionID")
                        .HasColumnType("int");

                    b.Property<int?>("parentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SectionID");

                    b.ToTable("ProjectTasks");
                });

            modelBuilder.Entity("xZoneAPI.Models.RoadmapModel.Roadmap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfLikes")
                        .HasColumnType("int");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("PublishDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("OwnerID");

                    b.HasIndex("ProjectId");

                    b.ToTable("Roadmaps");
                });

            modelBuilder.Entity("xZoneAPI.Models.SectionModel.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ParentProjectID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ParentProjectID");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("xZoneAPI.Models.TaskModel.AppTask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime?>("CompleteDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Priority")
                        .HasColumnType("int");

                    b.Property<DateTime?>("Remainder")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int?>("parentID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("xZoneAPI.Models.ProjectModel.Project", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerID");

                    b.Navigation("Owner");
                });

            modelBuilder.Entity("xZoneAPI.Models.ProjectTaskModel.ProjectTask", b =>
                {
                    b.HasOne("xZoneAPI.Models.SectionModel.Section", "ParentSection")
                        .WithMany("ProjectTasks")
                        .HasForeignKey("SectionID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentSection");
                });

            modelBuilder.Entity("xZoneAPI.Models.RoadmapModel.Roadmap", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.ProjectModel.Project", "Project")
                        .WithMany()
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Owner");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("xZoneAPI.Models.SectionModel.Section", b =>
                {
                    b.HasOne("xZoneAPI.Models.ProjectModel.Project", "ParentProject")
                        .WithMany("Sections")
                        .HasForeignKey("ParentProjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParentProject");
                });

            modelBuilder.Entity("xZoneAPI.Models.TaskModel.AppTask", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("xZoneAPI.Models.ProjectModel.Project", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("xZoneAPI.Models.SectionModel.Section", b =>
                {
                    b.Navigation("ProjectTasks");
                });
#pragma warning restore 612, 618
        }
    }
}
