﻿// <auto-generated />
using System;
using Game.Infra.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Game.Infra.Migrations
{
    [DbContext(typeof(GameContext))]
    partial class GameContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.12");

            modelBuilder.Entity("Dominio.Entidades.EntidadeGame", b =>
                {
                    b.Property<int>("EntidadeGameId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<Guid>("EntidadeGameGuid")
                        .HasColumnType("char(36)");

                    b.Property<int>("ano")
                        .HasColumnType("int");

                    b.Property<double>("nota")
                        .HasColumnType("double");

                    b.Property<string>("titulo")
                        .HasColumnType("longtext");

                    b.HasKey("EntidadeGameId");

                    b.HasIndex("EntidadeGameGuid")
                        .IsUnique()
                        .HasDatabaseName("IDX_GUID");

                    b.ToTable("Game");

                    b.HasData(
                        new
                        {
                            EntidadeGameId = 1,
                            EntidadeGameGuid = new Guid("c3247c57-d917-4cc5-a69c-90a19ceb5777"),
                            ano = 1998,
                            nota = 99.799999999999997,
                            titulo = "The Legend of Zelda: Ocarina of Time(N64)"
                        },
                        new
                        {
                            EntidadeGameId = 2,
                            EntidadeGameGuid = new Guid("6f01e281-04eb-4cb4-a32f-cc486b6c26b6"),
                            ano = 2000,
                            nota = 98.900000000000006,
                            titulo = "Tony Hawk's Pro Skater 2 (PS)"
                        },
                        new
                        {
                            EntidadeGameId = 3,
                            EntidadeGameGuid = new Guid("425108e6-b061-4434-a370-9f67d5324b22"),
                            ano = 2008,
                            nota = 98.900000000000006,
                            titulo = "Grand Theft Auto IV (PS3)"
                        },
                        new
                        {
                            EntidadeGameId = 4,
                            EntidadeGameGuid = new Guid("51175125-eef4-40ee-9f81-29e751cf6b08"),
                            ano = 2008,
                            nota = 98.900000000000006,
                            titulo = "Grand Theft Auto IV (X360)"
                        },
                        new
                        {
                            EntidadeGameId = 5,
                            EntidadeGameGuid = new Guid("e2a64cc4-a0b6-4aee-8604-fdf0f910f2dc"),
                            ano = 1999,
                            nota = 98.900000000000006,
                            titulo = "SoulCalibur (DC)"
                        },
                        new
                        {
                            EntidadeGameId = 6,
                            EntidadeGameGuid = new Guid("dea160f7-ec16-41ce-bb44-775da9c01ba7"),
                            ano = 2007,
                            nota = 97.900000000000006,
                            titulo = "Super Mario Galaxy (WII)"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}