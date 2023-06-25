﻿// <auto-generated />
using System;
using LeagueTableApp.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LeagueTableApp.DAL.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("LeagueTableApp.DAL.Entities.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Description = "It's a league for testing, for example test changeing values or deleting.",
                            IsDeleted = false,
                            Name = "TestLeague1"
                        },
                        new
                        {
                            Id = 102,
                            Description = "It's a league for testing, for example test changeing values or deleting.",
                            IsDeleted = false,
                            Name = "TestLeague2"
                        });
                });

            modelBuilder.Entity("LeagueTableApp.DAL.Entities.Match", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ForeignTeamId")
                        .HasColumnType("int");

                    b.Property<double>("ForeignTeamScore")
                        .HasColumnType("float");

                    b.Property<int?>("HomeTeamId")
                        .HasColumnType("int");

                    b.Property<double>("HomeTeamScore")
                        .HasColumnType("float");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnded")
                        .HasColumnType("bit");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("rowversion");

                    b.HasKey("Id");

                    b.HasIndex("ForeignTeamId");

                    b.HasIndex("HomeTeamId");

                    b.HasIndex("IsEnded");

                    b.HasIndex("LeagueId");

                    b.ToTable("Matches");

                    b.HasData(
                        new
                        {
                            Id = 1001,
                            ForeignTeamId = 102,
                            ForeignTeamScore = 1.0,
                            HomeTeamId = 101,
                            HomeTeamScore = 2.0,
                            IsDeleted = false,
                            IsEnded = true,
                            LeagueId = 101
                        },
                        new
                        {
                            Id = 1002,
                            ForeignTeamId = 101,
                            ForeignTeamScore = 0.0,
                            HomeTeamId = 102,
                            HomeTeamScore = 0.0,
                            IsDeleted = false,
                            IsEnded = false,
                            LeagueId = 101
                        },
                        new
                        {
                            Id = 1003,
                            ForeignTeamId = 101,
                            ForeignTeamScore = 1.0,
                            HomeTeamId = 103,
                            HomeTeamScore = 0.0,
                            IsDeleted = false,
                            IsEnded = true,
                            LeagueId = 101
                        },
                        new
                        {
                            Id = 1004,
                            ForeignTeamId = 103,
                            ForeignTeamScore = 0.0,
                            HomeTeamId = 101,
                            HomeTeamScore = 0.0,
                            IsDeleted = false,
                            IsEnded = false,
                            LeagueId = 101
                        },
                        new
                        {
                            Id = 1005,
                            ForeignTeamId = 103,
                            ForeignTeamScore = 0.0,
                            HomeTeamId = 102,
                            HomeTeamScore = 0.0,
                            IsDeleted = false,
                            IsEnded = false,
                            LeagueId = 101
                        },
                        new
                        {
                            Id = 1006,
                            ForeignTeamId = 102,
                            ForeignTeamScore = 2.0,
                            HomeTeamId = 103,
                            HomeTeamScore = 2.0,
                            IsDeleted = false,
                            IsEnded = true,
                            LeagueId = 101
                        });
                });

            modelBuilder.Entity("LeagueTableApp.DAL.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Captain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Coach")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Players")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("LeagueId", "Name");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 101,
                            Captain = "Player2",
                            Coach = "Test",
                            IsDeleted = false,
                            LeagueId = 101,
                            Name = "TestTeam1",
                            Players = "Player1, Player2, Player3"
                        },
                        new
                        {
                            Id = 102,
                            Captain = "A",
                            Coach = "Guardiola",
                            IsDeleted = false,
                            LeagueId = 101,
                            Name = "TestTeam2",
                            Players = "A, B, C, D"
                        },
                        new
                        {
                            Id = 103,
                            Captain = "Y",
                            Coach = "Rosssi",
                            IsDeleted = false,
                            LeagueId = 101,
                            Name = "TestTeam3",
                            Players = "X, Y, Z"
                        },
                        new
                        {
                            Id = 104,
                            Captain = "jatekos3",
                            Coach = "BelaBacsi",
                            IsDeleted = false,
                            LeagueId = 102,
                            Name = "TestTeamForDelete",
                            Players = "jatekos1, jatekos2, jatekos3"
                        },
                        new
                        {
                            Id = 105,
                            Captain = "Aladár",
                            Coach = "Csercsaszov",
                            IsDeleted = false,
                            LeagueId = 102,
                            Name = "TestTeamForUpdate",
                            Players = "Aladár, Béla, Csanád, Dániel"
                        });
                });

            modelBuilder.Entity("LeagueTableApp.DAL.Entities.Match", b =>
                {
                    b.HasOne("LeagueTableApp.DAL.Entities.Team", "ForeignTeam")
                        .WithMany()
                        .HasForeignKey("ForeignTeamId");

                    b.HasOne("LeagueTableApp.DAL.Entities.Team", "HomeTeam")
                        .WithMany()
                        .HasForeignKey("HomeTeamId");

                    b.HasOne("LeagueTableApp.DAL.Entities.League", "League")
                        .WithMany("Matches")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ForeignTeam");

                    b.Navigation("HomeTeam");

                    b.Navigation("League");
                });

            modelBuilder.Entity("LeagueTableApp.DAL.Entities.Team", b =>
                {
                    b.HasOne("LeagueTableApp.DAL.Entities.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("LeagueTableApp.DAL.Entities.League", b =>
                {
                    b.Navigation("Matches");

                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
