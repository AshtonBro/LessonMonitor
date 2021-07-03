﻿// <auto-generated />
using System;
using LessonMonitor.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LessonMonitor.DataAccess.Migrations
{
    [DbContext(typeof(LessonMonitorDbContext))]
    [Migration("20210702124945_initNewConnection")]
    partial class initNewConnection
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:Collation", "Cyrillic_General_CI_AS")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Achievement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Rank")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Achievements");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.GetVisitedLesson", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("VisitedDate")
                        .HasColumnType("datetime2");

                    b.ToView("GetVisitedLessons");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Homework", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Grade")
                        .HasColumnType("int");

                    b.Property<string>("Link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Homeworks");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Lesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("TopicId")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.ToTable("Lessons");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Link", b =>
                {
                    b.Property<string>("Discord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GitHub")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Twitter")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Vk")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("VK");

                    b.Property<string>("YouTube")
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("UserId");

                    b.ToTable("Links");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Skill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Skills");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Timecode", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(600)
                        .HasColumnType("nvarchar(600)");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("Timecode1")
                        .HasColumnType("time(3)")
                        .HasColumnName("Timecode");

                    b.HasKey("Id");

                    b.HasIndex("LessonId");

                    b.ToTable("Timecodes");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Theme")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeletedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Nicknames")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.UsersAchievement", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("AchievementId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("UserId", "AchievementId")
                        .HasName("PK_UserId_AchievementId");

                    b.HasIndex("AchievementId");

                    b.ToTable("UsersAchievements");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.UsersHomework", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("HomeworkId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("UserId", "HomeworkId")
                        .HasName("PK_UserId_HomeworkId");

                    b.HasIndex("HomeworkId");

                    b.ToTable("UsersHomeworks");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.UsersLesson", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("LessonId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("UserId", "LessonId")
                        .HasName("PK_UserId_LessonId");

                    b.HasIndex("LessonId");

                    b.ToTable("UsersLessons");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Homework", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.Topic", "Topic")
                        .WithMany("Homeworks")
                        .HasForeignKey("TopicId")
                        .HasConstraintName("FK_Homeworks_Topics");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Lesson", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.Topic", "Topic")
                        .WithMany("Lessons")
                        .HasForeignKey("TopicId")
                        .HasConstraintName("FK_Lessons_Topics");

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Link", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Links_Users")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Question", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.User", "User")
                        .WithMany("Questions")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_Questions_Users")
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Timecode", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.Lesson", "Lesson")
                        .WithMany("Timecodes")
                        .HasForeignKey("LessonId")
                        .HasConstraintName("FK_Timecodes_Lessons")
                        .IsRequired();

                    b.Navigation("Lesson");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.UsersAchievement", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.Achievement", "Achievement")
                        .WithMany("UsersAchievements")
                        .HasForeignKey("AchievementId")
                        .HasConstraintName("FK_UsersAchievements_Achievements")
                        .IsRequired();

                    b.HasOne("LessonMonitor.DataAccess.Entities.User", "User")
                        .WithMany("UsersAchievements")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UsersAchievements_Users")
                        .IsRequired();

                    b.Navigation("Achievement");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.UsersHomework", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.Homework", "Homework")
                        .WithMany("UsersHomeworks")
                        .HasForeignKey("HomeworkId")
                        .HasConstraintName("FK_UsersHomeworks_Homeworks")
                        .IsRequired();

                    b.HasOne("LessonMonitor.DataAccess.Entities.User", "User")
                        .WithMany("UsersHomeworks")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_UsersHomeworks_Users")
                        .IsRequired();

                    b.Navigation("Homework");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.UsersLesson", b =>
                {
                    b.HasOne("LessonMonitor.DataAccess.Entities.Lesson", "Lesson")
                        .WithMany("UsersLessons")
                        .HasForeignKey("LessonId")
                        .HasConstraintName("FK_VisitedLessons_Lessons")
                        .IsRequired();

                    b.HasOne("LessonMonitor.DataAccess.Entities.User", "User")
                        .WithMany("UsersLessons")
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK_VisitedLessons_Users")
                        .IsRequired();

                    b.Navigation("Lesson");

                    b.Navigation("User");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Achievement", b =>
                {
                    b.Navigation("UsersAchievements");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Homework", b =>
                {
                    b.Navigation("UsersHomeworks");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Lesson", b =>
                {
                    b.Navigation("Timecodes");

                    b.Navigation("UsersLessons");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.Topic", b =>
                {
                    b.Navigation("Homeworks");

                    b.Navigation("Lessons");
                });

            modelBuilder.Entity("LessonMonitor.DataAccess.Entities.User", b =>
                {
                    b.Navigation("Questions");

                    b.Navigation("UsersAchievements");

                    b.Navigation("UsersHomeworks");

                    b.Navigation("UsersLessons");
                });
#pragma warning restore 612, 618
        }
    }
}
