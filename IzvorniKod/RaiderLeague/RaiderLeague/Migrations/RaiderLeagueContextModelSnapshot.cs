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
                    b.Property<int>("ID");

                    b.Property<int?>("bossID");

                    b.Property<int?>("klasa");

                    b.Property<string>("log");

                    b.Property<int?>("operationID");

                    b.Property<int?>("role");

                    b.Property<int?>("userID");

                    b.HasKey("ID");

                    b.HasIndex("bossID");

                    b.HasIndex("operationID");

                    b.HasIndex("userID");

                    b.ToTable("BattleLog");
                });

            modelBuilder.Entity("RaiderLeague.Models.Boss", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BossName");

                    b.Property<int>("Damage");

                    b.Property<int?>("Difficulty");

                    b.Property<int>("Health");

                    b.Property<int?>("OperationID");

                    b.HasKey("ID");

                    b.HasIndex("OperationID");

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

                    b.Property<int?>("difficulty");

                    b.HasKey("ID");

                    b.ToTable("Operation");
                });

            modelBuilder.Entity("RaiderLeague.Models.RegisteredUser", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessLevel");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Klasa");

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<string>("Username")
                        .IsRequired();

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

            modelBuilder.Entity("RaiderLeague.Models.BattleLog", b =>
                {
                    b.HasOne("RaiderLeague.Models.Result", "Result")
                        .WithOne("BattleLog")
                        .HasForeignKey("RaiderLeague.Models.BattleLog", "ID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("RaiderLeague.Models.Boss", "boss")
                        .WithMany("BattleLog")
                        .HasForeignKey("bossID");

                    b.HasOne("RaiderLeague.Models.Operation", "operation")
                        .WithMany("dnevnici")
                        .HasForeignKey("operationID");

                    b.HasOne("RaiderLeague.Models.RegisteredUser", "user")
                        .WithMany()
                        .HasForeignKey("userID");
                });

            modelBuilder.Entity("RaiderLeague.Models.Boss", b =>
                {
                    b.HasOne("RaiderLeague.Models.Operation", "Operation")
                        .WithMany("bosses")
                        .HasForeignKey("OperationID");
                });
#pragma warning restore 612, 618
        }
    }
}
