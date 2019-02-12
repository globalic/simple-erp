﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Pregledi.Persistence.Context;

namespace Pregledi.Persistence.Migrations
{
    [DbContext(typeof(PreglediContext))]
    [Migration("20190210210648_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Pregledi.Domain.Entities.KarticaKonta", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("DatumKnjizenja")
                        .HasColumnType("date");

                    b.Property<DateTime>("DatumNaloga")
                        .HasColumnType("date");

                    b.Property<decimal>("Duguje");

                    b.Property<long>("IdKonto");

                    b.Property<Guid>("IdNaloga");

                    b.Property<string>("Konto")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Opis");

                    b.Property<decimal>("Potrazuje");

                    b.Property<decimal>("Saldo");

                    b.Property<decimal>("SaldoKumulativno");

                    b.Property<string>("TipNaloga");

                    b.Property<long>("Version")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.ToTable("kartica_konta");
                });

            modelBuilder.Entity("Pregledi.Domain.Entities.Konto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Naziv");

                    b.Property<string>("Sifra");

                    b.HasKey("Id");

                    b.ToTable("konto");
                });

            modelBuilder.Entity("Pregledi.Domain.Entities.NalogForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<long>("IdTip");

                    b.Property<string>("Opis");

                    b.Property<long>("Version")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.ToTable("nalog_form");
                });

            modelBuilder.Entity("Pregledi.Domain.Entities.NalogGlavnaKnjiga", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BrojStavki");

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<string>("Opis");

                    b.Property<string>("TipNaziv");

                    b.Property<decimal>("UkupnoDuguje");

                    b.Property<decimal>("UkupnoPotrazuje");

                    b.Property<decimal>("UkupnoSaldo");

                    b.Property<long>("Version")
                        .IsConcurrencyToken();

                    b.Property<bool>("Zakljucan");

                    b.HasKey("Id");

                    b.ToTable("nalog_glavna_knjiga");
                });

            modelBuilder.Entity("Pregledi.Domain.Entities.ProcessedEvent", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<long?>("Checkpoint");

                    b.Property<long?>("CommitPosition");

                    b.Property<DateTime>("Created");

                    b.Property<string>("OriginalStream");

                    b.Property<long?>("PreparePosition");

                    b.Property<string>("Stream")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.HasKey("Id");

                    b.ToTable("processed_event");
                });

            modelBuilder.Entity("Pregledi.Domain.Entities.StavkaForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DatumKnjizenja")
                        .HasColumnType("date");

                    b.Property<decimal>("Duguje");

                    b.Property<long>("IdKonto");

                    b.Property<Guid>("IdNaloga");

                    b.Property<string>("Konto")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.Property<string>("Opis");

                    b.Property<decimal>("Potrazuje");

                    b.Property<long>("Version")
                        .IsConcurrencyToken();

                    b.HasKey("Id");

                    b.HasIndex("IdNaloga");

                    b.ToTable("stavka_form");
                });

            modelBuilder.Entity("Pregledi.Domain.Entities.TipNaloga", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Naziv");

                    b.HasKey("Id");

                    b.ToTable("tip_naloga");
                });

            modelBuilder.Entity("Pregledi.Domain.Entities.StavkaForm", b =>
                {
                    b.HasOne("Pregledi.Domain.Entities.NalogForm")
                        .WithMany("Stavke")
                        .HasForeignKey("IdNaloga")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
