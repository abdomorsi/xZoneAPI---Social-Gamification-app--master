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
    [Migration("20210723211222_AddedZoneTaskAndAccountZoneTask2")]
    partial class AddedZoneTaskAndAccountZoneTask2
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

                    b.Property<int>("Rank")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("bio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.AccountBadge", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("BadgeID")
                        .HasColumnType("int");

                    b.HasKey("AccountID", "BadgeID");

                    b.HasIndex("BadgeID");

                    b.ToTable("AccountBadges");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.AccountSkill", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("SkillID")
                        .HasColumnType("int");

                    b.HasKey("AccountID", "SkillID");

                    b.HasIndex("SkillID");

                    b.ToTable("AccountSkills");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.AccountZoneTask", b =>
                {
                    b.Property<int>("AccountID")
                        .HasColumnType("int");

                    b.Property<int>("ZoneTaskID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CompleteDate")
                        .HasColumnType("datetime2");

                    b.HasKey("AccountID", "ZoneTaskID");

                    b.ToTable("AccountZoneTasks");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.Friend", b =>
                {
                    b.Property<int>("FirstId")
                        .HasColumnType("int");

                    b.Property<int>("SecondId")
                        .HasColumnType("int");

                    b.HasKey("FirstId", "SecondId");

                    b.HasIndex("SecondId");

                    b.ToTable("Friends");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.FriendRequest", b =>
                {
                    b.Property<int>("SenderId")
                        .HasColumnType("int");

                    b.Property<int>("ReceiverId")
                        .HasColumnType("int");

                    b.HasKey("SenderId", "ReceiverId");

                    b.HasIndex("ReceiverId");

                    b.ToTable("FriendRequests");
                });

            modelBuilder.Entity("xZoneAPI.Models.Badges.Badge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Badges");
                });

            modelBuilder.Entity("xZoneAPI.Models.Posts.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("WriterId")
                        .HasColumnType("int");

                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.Property<string>("content")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("WriterId");

                    b.HasIndex("ZoneId");

                    b.ToTable("Posts");
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

            modelBuilder.Entity("xZoneAPI.Models.Ranks.Rank", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ranks");
                });

            modelBuilder.Entity("xZoneAPI.Models.RoadmapModel.Roadmap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
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

            modelBuilder.Entity("xZoneAPI.Models.Skills.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Skills");
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

                    b.ToTable("ZoneTasks");
                });

            modelBuilder.Entity("xZoneAPI.Models.Zones.Zone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JoinCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumOfMembers")
                        .HasColumnType("int");

                    b.Property<int>("Privacy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("xZoneAPI.Models.Zones.ZoneMember", b =>
                {
                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("NumOfCompletedTasks")
                        .HasColumnType("int");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.HasKey("ZoneId", "AccountId");

                    b.HasIndex("AccountId");

                    b.ToTable("ZoneMembers");
                });

            modelBuilder.Entity("xZoneAPI.Models.Zones.ZoneSkill", b =>
                {
                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.Property<int>("SkillId")
                        .HasColumnType("int");

                    b.HasKey("ZoneId", "SkillId");

                    b.HasIndex("SkillId");

                    b.ToTable("ZoneSkills");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.AccountBadge", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Account")
                        .WithMany("Badges")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.Badges.Badge", "Badge")
                        .WithMany("AccountBadges")
                        .HasForeignKey("BadgeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Badge");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.AccountSkill", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Account")
                        .WithMany("Skills")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.Skills.Skill", "Skill")
                        .WithMany("AccountsSkill")
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.AccountZoneTask", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Account")
                        .WithMany("ZoneTasks")
                        .HasForeignKey("AccountID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.Friend", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "First")
                        .WithMany("Friends")
                        .HasForeignKey("FirstId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Second")
                        .WithMany()
                        .HasForeignKey("SecondId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("First");

                    b.Navigation("Second");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.FriendRequest", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Receiver")
                        .WithMany()
                        .HasForeignKey("ReceiverId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Sender")
                        .WithMany("FriendRequests")
                        .HasForeignKey("SenderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Receiver");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("xZoneAPI.Models.Posts.Post", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Writer")
                        .WithMany()
                        .HasForeignKey("WriterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.Zones.Zone", "Zone")
                        .WithMany("Posts")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Writer");

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("xZoneAPI.Models.ProjectModel.Project", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Owner")
                        .WithMany("Projects")
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
                        .WithMany("Roadmaps")
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
                        .WithMany("Tasks")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("xZoneAPI.Models.Zones.ZoneMember", b =>
                {
                    b.HasOne("xZoneAPI.Models.Accounts.Account", "Account")
                        .WithMany("Zones")
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.Zones.Zone", "Zone")
                        .WithMany("ZoneMembers")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Account");

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("xZoneAPI.Models.Zones.ZoneSkill", b =>
                {
                    b.HasOne("xZoneAPI.Models.Skills.Skill", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("xZoneAPI.Models.Zones.Zone", "Zone")
                        .WithMany("ZoneSkills")
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Skill");

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("xZoneAPI.Models.Accounts.Account", b =>
                {
                    b.Navigation("Badges");

                    b.Navigation("FriendRequests");

                    b.Navigation("Friends");

                    b.Navigation("Projects");

                    b.Navigation("Roadmaps");

                    b.Navigation("Skills");

                    b.Navigation("Tasks");

                    b.Navigation("Zones");

                    b.Navigation("ZoneTasks");
                });

            modelBuilder.Entity("xZoneAPI.Models.Badges.Badge", b =>
                {
                    b.Navigation("AccountBadges");
                });

            modelBuilder.Entity("xZoneAPI.Models.ProjectModel.Project", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("xZoneAPI.Models.SectionModel.Section", b =>
                {
                    b.Navigation("ProjectTasks");
                });

            modelBuilder.Entity("xZoneAPI.Models.Skills.Skill", b =>
                {
                    b.Navigation("AccountsSkill");
                });

            modelBuilder.Entity("xZoneAPI.Models.Zones.Zone", b =>
                {
                    b.Navigation("Posts");

                    b.Navigation("ZoneMembers");

                    b.Navigation("ZoneSkills");
                });
#pragma warning restore 612, 618
        }
    }
}
