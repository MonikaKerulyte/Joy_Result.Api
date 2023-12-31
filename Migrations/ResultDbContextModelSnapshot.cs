﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Result.Api.Data;

#nullable disable

namespace Result.Api.Migrations
{
    [DbContext(typeof(ResultDbContext))]
    partial class ResultDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Result.Api.Model.Entity.Game", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ModeName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NrOfQuestions")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDateTime")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("Result.Api.Model.Entity.GameAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AccountId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("GameAccounts");
                });

            modelBuilder.Entity("Result.Api.Model.Entity.GameResult", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("FinishDateTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("GameAccountId")
                        .HasColumnType("int");

                    b.Property<int>("NrOfCorrectAnswers")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("GameResults");
                });
#pragma warning restore 612, 618
        }
    }
}
