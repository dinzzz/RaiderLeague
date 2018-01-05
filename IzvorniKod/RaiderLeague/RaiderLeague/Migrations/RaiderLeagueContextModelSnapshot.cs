﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using RaiderLeague.Models;
using System;

namespace RaiderLeague.Migrations
{
    [DbContext(typeof(RaiderLeagueContext))]
    partial class RaiderLeagueContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RaiderLeague.Models.BattleLog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("log");

                    b.HasKey("ID");

                    b.ToTable("BattleLog");
                });

            modelBuilder.Entity("RaiderLeague.Models.Boss", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("bossName");

                    b.Property<int>("damage");

                    b.Property<int>("health");

                    b.HasKey("ID");

                    b.ToTable("Boss");
                });

            modelBuilder.Entity("RaiderLeague.Models.ErrorViewModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("RequestId");

                    b.HasKey("ID");

                    b.ToTable("ErrorViewModel");
                });

            modelBuilder.Entity("RaiderLeague.Models.Operation", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("OperationName");

                    b.HasKey("ID");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("RaiderLeague.Models.RegisteredUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<int>("Klasa");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("ID");

                    b.ToTable("RegisteredUser");
                });

            modelBuilder.Entity("RaiderLeague.Models.Result", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.HasKey("ID");

                    b.ToTable("Result");
                });
#pragma warning restore 612, 618
        }
    }
}
