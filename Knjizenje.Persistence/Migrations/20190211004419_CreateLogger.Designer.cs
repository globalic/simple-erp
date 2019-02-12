﻿// <auto-generated />
using Knjizenje.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Knjizenje.Persistence.Migrations
{
    [DbContext(typeof(KnjizenjeContext))]
    [Migration("20190211004419_CreateLogger")]
    partial class CreateLogger
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Knjizenje.Domain.Entities.FinNalogAggregate.TipNaloga", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("tip_naloga");
                });

            modelBuilder.Entity("Knjizenje.Domain.Entities.Konto.Konto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<string>("Sifra");

                    b.HasKey("Id");

                    b.ToTable("konto");
                });
#pragma warning restore 612, 618
        }
    }
}
