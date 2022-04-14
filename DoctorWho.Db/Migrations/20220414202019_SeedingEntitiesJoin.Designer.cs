﻿// <auto-generated />
using System;
using DoctorWho.Db;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DoctorWho.Db.Migrations
{
    [DbContext(typeof(DoctorWhoCoreDbContext))]
    [Migration("20220414202019_SeedingEntitiesJoin")]
    partial class SeedingEntitiesJoin
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthorId"), 1L, 1);

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("tblAuthor", (string)null);

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorName = "Aisha Marmash"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorName = "Sara Sawafta"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorName = "Asad Jamal"
                        },
                        new
                        {
                            AuthorId = 4,
                            AuthorName = "Rawan Ahmad"
                        },
                        new
                        {
                            AuthorId = 5,
                            AuthorName = "Qamar Ashour"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Property<int>("CompanionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanionId"), 1L, 1);

                    b.Property<string>("CompanionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WhoPlayed")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanionId");

                    b.ToTable("tblCompanion", (string)null);

                    b.HasData(
                        new
                        {
                            CompanionId = 1,
                            CompanionName = "Ameera Ameer",
                            WhoPlayed = "Ameera Surakji"
                        },
                        new
                        {
                            CompanionId = 2,
                            CompanionName = "khalid Ali",
                            WhoPlayed = "khalid Toma"
                        },
                        new
                        {
                            CompanionId = 3,
                            CompanionName = "Aya Khalid",
                            WhoPlayed = "Aya Jamal"
                        },
                        new
                        {
                            CompanionId = 4,
                            CompanionName = "Samar Samer",
                            WhoPlayed = "Samar Rsas"
                        },
                        new
                        {
                            CompanionId = 5,
                            CompanionName = "Duaa Aqel",
                            WhoPlayed = "Dalal Aqel"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Property<int>("DoctorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DoctorId"), 1L, 1);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DoctorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DoctorNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FirstEpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("LastEpisodeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DoctorId");

                    b.ToTable("tblDoctor", (string)null);

                    b.HasData(
                        new
                        {
                            DoctorId = 1,
                            BirthDate = new DateTime(1985, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Anjad Shaar",
                            DoctorNumber = "First Doctor",
                            FirstEpisodeDate = new DateTime(2005, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2008, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 2,
                            BirthDate = new DateTime(1986, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Ranen Halabi",
                            DoctorNumber = "Second Doctor",
                            FirstEpisodeDate = new DateTime(2002, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LastEpisodeDate = new DateTime(2009, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 3,
                            BirthDate = new DateTime(1987, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Shahd Shaar",
                            DoctorNumber = "Third Doctor",
                            FirstEpisodeDate = new DateTime(2012, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            DoctorId = 4,
                            BirthDate = new DateTime(1988, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Lina Khanna",
                            DoctorNumber = "Fourth Doctor"
                        },
                        new
                        {
                            DoctorId = 5,
                            BirthDate = new DateTime(1989, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DoctorName = "Majd Nabulsi",
                            DoctorNumber = "Fifth Doctor"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Property<int>("EnemyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EnemyId"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnemyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EnemyId");

                    b.ToTable("tblEnemy", (string)null);

                    b.HasData(
                        new
                        {
                            EnemyId = 1,
                            Description = "Tuberculosis (TB) is caused by bacteria (Mycobacterium tuberculosis) that most often affect the lungs. Tuberculosis is curable and preventable.",
                            EnemyName = "Tuberculosis"
                        },
                        new
                        {
                            EnemyId = 2,
                            Description = "Plague is an infectious disease caused by the bacteria Yersinia pestis, a zoonotic bacteria, usually found in small mammals and their fleas. It is transmitted between animals through fleas.",
                            EnemyName = "Plague"
                        },
                        new
                        {
                            EnemyId = 3,
                            Description = "Smallpox is an ancient disease caused by the variola virus. Early symptoms include high fever and fatigue. The virus then produces a characteristic rash, particularly on the face, arms and legs. The resulting spots become filled with clear fluid and later, pus, and then form a crust, which eventually dries up and falls off. Smallpox was fatal in up to 30% of cases",
                            EnemyName = "Smallpox"
                        },
                        new
                        {
                            EnemyId = 4,
                            Description = "A viral infection causing nerve injury which leads to partial or full paralysis. Many of the infected people do not show any symptoms.",
                            EnemyName = "Poliomyelitis"
                        },
                        new
                        {
                            EnemyId = 5,
                            Description = "A bacterial infection which spreads through contaminated food and water.",
                            EnemyName = "Cholera"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Property<int>("EpisodeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EpisodeId"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("DoctorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EpisodeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("EpisodeNumber")
                        .HasColumnType("int");

                    b.Property<string>("EpisodeType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SeriesNumber")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EpisodeId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("DoctorId");

                    b.ToTable("tblEpisode", (string)null);

                    b.HasCheckConstraint("CK_tblEpisode_EpisodeType_Enum", "[EpisodeType] IN (N'Trailer', N'Bonus', N'Full')");

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            AuthorId = 1,
                            DoctorId = 2,
                            EpisodeDate = new DateTime(2009, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Full",
                            SeriesNumber = 1,
                            Title = "Welcome"
                        },
                        new
                        {
                            EpisodeId = 2,
                            AuthorId = 5,
                            DoctorId = 1,
                            EpisodeDate = new DateTime(2009, 5, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Trailer",
                            SeriesNumber = 1,
                            Title = "Test"
                        },
                        new
                        {
                            EpisodeId = 3,
                            AuthorId = 1,
                            DoctorId = 0,
                            EpisodeDate = new DateTime(2005, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 3,
                            EpisodeType = "Bonus",
                            SeriesNumber = 1,
                            Title = "Be Better"
                        },
                        new
                        {
                            EpisodeId = 4,
                            AuthorId = 5,
                            DoctorId = 3,
                            EpisodeDate = new DateTime(2006, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 1,
                            EpisodeType = "Full",
                            SeriesNumber = 2,
                            Title = "Warnning"
                        },
                        new
                        {
                            EpisodeId = 5,
                            AuthorId = 2,
                            DoctorId = 0,
                            EpisodeDate = new DateTime(2022, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EpisodeNumber = 2,
                            EpisodeType = "Bonus",
                            SeriesNumber = 2,
                            Title = "Warnning"
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<int>("CompanionId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeCompanionId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeId", "CompanionId");

                    b.HasIndex("CompanionId");

                    b.ToTable("tblEpisodeCompanion", (string)null);

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            CompanionId = 1,
                            EpisodeCompanionId = 1
                        },
                        new
                        {
                            EpisodeId = 1,
                            CompanionId = 3,
                            EpisodeCompanionId = 2
                        },
                        new
                        {
                            EpisodeId = 2,
                            CompanionId = 4,
                            EpisodeCompanionId = 3
                        },
                        new
                        {
                            EpisodeId = 3,
                            CompanionId = 1,
                            EpisodeCompanionId = 4
                        },
                        new
                        {
                            EpisodeId = 4,
                            CompanionId = 4,
                            EpisodeCompanionId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.Property<int>("EpisodeId")
                        .HasColumnType("int");

                    b.Property<int>("EnemyId")
                        .HasColumnType("int");

                    b.Property<int>("EpisodeEnemyId")
                        .HasColumnType("int");

                    b.HasKey("EpisodeId", "EnemyId");

                    b.HasIndex("EnemyId");

                    b.ToTable("tblEpisodeEnemy", (string)null);

                    b.HasData(
                        new
                        {
                            EpisodeId = 1,
                            EnemyId = 4,
                            EpisodeEnemyId = 1
                        },
                        new
                        {
                            EpisodeId = 2,
                            EnemyId = 4,
                            EpisodeEnemyId = 2
                        },
                        new
                        {
                            EpisodeId = 2,
                            EnemyId = 1,
                            EpisodeEnemyId = 3
                        },
                        new
                        {
                            EpisodeId = 3,
                            EnemyId = 1,
                            EpisodeEnemyId = 4
                        },
                        new
                        {
                            EpisodeId = 4,
                            EnemyId = 3,
                            EpisodeEnemyId = 5
                        });
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.HasOne("DoctorWho.Db.Author", "Author")
                        .WithMany("Episodes")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Doctor", "Doctor")
                        .WithMany("Episodes")
                        .HasForeignKey("DoctorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Doctor");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeCompanion", b =>
                {
                    b.HasOne("DoctorWho.Db.Companion", "Companion")
                        .WithMany("EpisodesCompanions")
                        .HasForeignKey("CompanionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodesCompanions")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Companion");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.EpisodeEnemy", b =>
                {
                    b.HasOne("DoctorWho.Db.Enemy", "Enemy")
                        .WithMany("EpisodesEnemies")
                        .HasForeignKey("EnemyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DoctorWho.Db.Episode", "Episode")
                        .WithMany("EpisodesEnemies")
                        .HasForeignKey("EpisodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Enemy");

                    b.Navigation("Episode");
                });

            modelBuilder.Entity("DoctorWho.Db.Author", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Companion", b =>
                {
                    b.Navigation("EpisodesCompanions");
                });

            modelBuilder.Entity("DoctorWho.Db.Doctor", b =>
                {
                    b.Navigation("Episodes");
                });

            modelBuilder.Entity("DoctorWho.Db.Enemy", b =>
                {
                    b.Navigation("EpisodesEnemies");
                });

            modelBuilder.Entity("DoctorWho.Db.Episode", b =>
                {
                    b.Navigation("EpisodesCompanions");

                    b.Navigation("EpisodesEnemies");
                });
#pragma warning restore 612, 618
        }
    }
}
