﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MilesAway.Data;

namespace MilesAway.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220327121119_novaB")]
    partial class novaB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MilesAway.Models.Aerodrom", b =>
                {
                    b.Property<int>("AerodromID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AerodromID");

                    b.HasIndex("GradID");

                    b.ToTable("Aerodrom");
                });

            modelBuilder.Entity("MilesAway.Models.AerodromLet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AerodromID")
                        .HasColumnType("int");

                    b.Property<int?>("AerodromID_ID")
                        .HasColumnType("int");

                    b.Property<int?>("LetID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AerodromID");

                    b.HasIndex("AerodromID_ID");

                    b.HasIndex("LetID");

                    b.ToTable("AerodromLet");
                });

            modelBuilder.Entity("MilesAway.Models.AutentifikacijaToken", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("KorisnickiNalogId")
                        .HasColumnType("int");

                    b.Property<string>("ipAdresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("vrijednost")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("vrijemeEvidentiranja")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.HasIndex("KorisnickiNalogId");

                    b.ToTable("AutentifikacijaToken");
                });

            modelBuilder.Entity("MilesAway.Models.Aviokompanija", b =>
                {
                    b.Property<int>("AviokompanijaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AviokompanijaID");

                    b.ToTable("Aviokompanija");
                });

            modelBuilder.Entity("MilesAway.Models.Avion", b =>
                {
                    b.Property<int>("AvionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AviokompanijaID")
                        .HasColumnType("int");

                    b.Property<int>("BrojMaxSjedista")
                        .HasColumnType("int");

                    b.Property<string>("BrojRegistracije")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BrojSjedistaBusiness")
                        .HasColumnType("int");

                    b.Property<int>("BrojSjedistaPrveKlase")
                        .HasColumnType("int");

                    b.Property<DateTime>("DatumZadnjegServisa")
                        .HasColumnType("datetime2");

                    b.HasKey("AvionID");

                    b.HasIndex("AviokompanijaID");

                    b.ToTable("Avion");
                });

            modelBuilder.Entity("MilesAway.Models.AvionLet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AvionID")
                        .HasColumnType("int");

                    b.Property<int?>("LetID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AvionID");

                    b.HasIndex("LetID");

                    b.ToTable("AvionLet");
                });

            modelBuilder.Entity("MilesAway.Models.Drzava", b =>
                {
                    b.Property<int>("DrzavaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DrzavaID");

                    b.ToTable("Drzava");
                });

            modelBuilder.Entity("MilesAway.Models.Grad", b =>
                {
                    b.Property<int>("GradID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("DrzavaID")
                        .HasColumnType("int");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GradID");

                    b.HasIndex("DrzavaID");

                    b.ToTable("Grad");
                });

            modelBuilder.Entity("MilesAway.Models.Izvjestaj", b =>
                {
                    b.Property<int>("IzvjestajID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Datum")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenadzerID")
                        .HasColumnType("int");

                    b.Property<string>("Sadrzaj")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IzvjestajID");

                    b.HasIndex("MenadzerID");

                    b.ToTable("Izvjestaj");
                });

            modelBuilder.Entity("MilesAway.Models.Karta", b =>
                {
                    b.Property<int>("KartaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivna")
                        .HasColumnType("bit");

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<int?>("LetID")
                        .HasColumnType("int");

                    b.Property<int?>("PutanjaID")
                        .HasColumnType("int");

                    b.Property<string>("Sjediste")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipKarteID")
                        .HasColumnType("int");

                    b.HasKey("KartaID");

                    b.HasIndex("LetID");

                    b.HasIndex("PutanjaID");

                    b.HasIndex("TipKarteID");

                    b.ToTable("Karta");
                });

            modelBuilder.Entity("MilesAway.Models.Kartica", b =>
                {
                    b.Property<int>("KarticaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrojKartice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumIsteka")
                        .HasColumnType("datetime2");

                    b.Property<int?>("KupacID")
                        .HasColumnType("int");

                    b.Property<int>("VerifikacijskiKod")
                        .HasColumnType("int");

                    b.HasKey("KarticaID");

                    b.HasIndex("KupacID");

                    b.ToTable("Kartica");
                });

            modelBuilder.Entity("MilesAway.Models.Korisnik", b =>
                {
                    b.Property<int>("KorisnikID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("korisnickoIme")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("lozinka")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("slika_korisnika")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KorisnikID");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("MilesAway.Models.KupljenaKarta", b =>
                {
                    b.Property<int>("KupljenaKartaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<DateTime>("DatumKupovine")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumPolaska")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DatumPovratka")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsAktivna")
                        .HasColumnType("bit");

                    b.Property<int?>("KartaID")
                        .HasColumnType("int");

                    b.Property<int?>("KupacID")
                        .HasColumnType("int");

                    b.Property<int?>("PopustID")
                        .HasColumnType("int");

                    b.Property<bool>("PostojiPopust")
                        .HasColumnType("bit");

                    b.Property<bool>("Povratna")
                        .HasColumnType("bit");

                    b.Property<int?>("TipPrtljageID")
                        .HasColumnType("int");

                    b.Property<int?>("TipPutnikaID")
                        .HasColumnType("int");

                    b.HasKey("KupljenaKartaID");

                    b.HasIndex("KartaID");

                    b.HasIndex("KupacID");

                    b.HasIndex("PopustID");

                    b.HasIndex("TipPrtljageID");

                    b.HasIndex("TipPutnikaID");

                    b.ToTable("KupljenaKarta");
                });

            modelBuilder.Entity("MilesAway.Models.Let", b =>
                {
                    b.Property<int>("LetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumVrijemePolaska")
                        .HasColumnType("datetime2");

                    b.Property<int?>("DestinacijaGradID")
                        .HasColumnType("int");

                    b.Property<float>("JednosmijernaCijena")
                        .HasColumnType("real");

                    b.Property<int?>("PolazisteGradID")
                        .HasColumnType("int");

                    b.Property<float>("PovratnaCijena")
                        .HasColumnType("real");

                    b.Property<string>("SifraLeta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("VrijemeDolaska")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("VrijemeTrajanja")
                        .HasColumnType("time");

                    b.HasKey("LetID");

                    b.HasIndex("DestinacijaGradID");

                    b.HasIndex("PolazisteGradID");

                    b.ToTable("Let");
                });

            modelBuilder.Entity("MilesAway.Models.Obavijest", b =>
                {
                    b.Property<int>("ObavijestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatumKreiranja")
                        .HasColumnType("datetime2");

                    b.Property<int?>("MenadzerID")
                        .HasColumnType("int");

                    b.Property<string>("Naslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ObavijestKategorijeID")
                        .HasColumnType("int");

                    b.Property<string>("Opis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PodNaslov")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Slika")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("Slika_")
                        .HasColumnType("varbinary(max)");

                    b.HasKey("ObavijestID");

                    b.HasIndex("MenadzerID");

                    b.HasIndex("ObavijestKategorijeID");

                    b.ToTable("Obavijest");
                });

            modelBuilder.Entity("MilesAway.Models.ObavijestKategorije", b =>
                {
                    b.Property<int>("ObavijestKategorijeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ObavijestKategorijeID");

                    b.ToTable("ObavijestKategorije");
                });

            modelBuilder.Entity("MilesAway.Models.Pilot", b =>
                {
                    b.Property<int>("PilotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojDozvole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumRodjenja")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JMBG")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Kontakt")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Spol")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.HasKey("PilotID");

                    b.ToTable("Pilot");
                });

            modelBuilder.Entity("MilesAway.Models.PilotLet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("LetID")
                        .HasColumnType("int");

                    b.Property<int?>("PilotID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LetID");

                    b.HasIndex("PilotID");

                    b.ToTable("PilotLet");
                });

            modelBuilder.Entity("MilesAway.Models.Presjedanje", b =>
                {
                    b.Property<int>("PresjedanjeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("GradID")
                        .HasColumnType("int");

                    b.Property<int?>("LetID")
                        .HasColumnType("int");

                    b.Property<DateTime>("VrijemeDolaska")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("VrijemePolaska")
                        .HasColumnType("datetime2");

                    b.HasKey("PresjedanjeID");

                    b.HasIndex("GradID");

                    b.HasIndex("LetID");

                    b.ToTable("Presjedanje");
                });

            modelBuilder.Entity("MilesAway.Models.TipKarte", b =>
                {
                    b.Property<int>("TipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<bool>("IsAktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipID");

                    b.ToTable("TipKarte");
                });

            modelBuilder.Entity("MilesAway.Models.TipPrtljage", b =>
                {
                    b.Property<int>("TipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("CijenaDodatak")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipID");

                    b.ToTable("TipPrtljage");
                });

            modelBuilder.Entity("MilesAway.Models.TipPutnika", b =>
                {
                    b.Property<int>("TipID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Cijena")
                        .HasColumnType("real");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TipID");

                    b.ToTable("TipPutnika");
                });

            modelBuilder.Entity("MilesAway.Models.VrstaPopusta", b =>
                {
                    b.Property<int>("PopustID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Aktivan")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Popust")
                        .HasColumnType("real");

                    b.HasKey("PopustID");

                    b.ToTable("VrstaPopust");
                });

            modelBuilder.Entity("MilesAway.Models.VrstaPutanjeKarte", b =>
                {
                    b.Property<int>("PutanjaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PutanjaID");

                    b.ToTable("VrstaPutanjeKarte");
                });

            modelBuilder.Entity("MilesAway.Models.Kupac", b =>
                {
                    b.HasBaseType("MilesAway.Models.Korisnik");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Kupac");
                });

            modelBuilder.Entity("MilesAway.Models.Menadzer", b =>
                {
                    b.HasBaseType("MilesAway.Models.Korisnik");

                    b.Property<string>("Adresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BrojTelefona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DatumZaposlenja")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prezime")
                        .HasColumnType("nvarchar(max)");

                    b.ToTable("Menadzer");
                });

            modelBuilder.Entity("MilesAway.Models.Aerodrom", b =>
                {
                    b.HasOne("MilesAway.Models.Grad", "Grad")
                        .WithMany()
                        .HasForeignKey("GradID");

                    b.Navigation("Grad");
                });

            modelBuilder.Entity("MilesAway.Models.AerodromLet", b =>
                {
                    b.HasOne("MilesAway.Models.Aerodrom", "Aerodrom1")
                        .WithMany()
                        .HasForeignKey("AerodromID");

                    b.HasOne("MilesAway.Models.Aerodrom", "Aerodrom2")
                        .WithMany()
                        .HasForeignKey("AerodromID_ID");

                    b.HasOne("MilesAway.Models.Let", "Let")
                        .WithMany()
                        .HasForeignKey("LetID");

                    b.Navigation("Aerodrom1");

                    b.Navigation("Aerodrom2");

                    b.Navigation("Let");
                });

            modelBuilder.Entity("MilesAway.Models.AutentifikacijaToken", b =>
                {
                    b.HasOne("MilesAway.Models.Korisnik", "korisnickiNalog")
                        .WithMany()
                        .HasForeignKey("KorisnickiNalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("korisnickiNalog");
                });

            modelBuilder.Entity("MilesAway.Models.Avion", b =>
                {
                    b.HasOne("MilesAway.Models.Aviokompanija", "Aviokompanija")
                        .WithMany()
                        .HasForeignKey("AviokompanijaID");

                    b.Navigation("Aviokompanija");
                });

            modelBuilder.Entity("MilesAway.Models.AvionLet", b =>
                {
                    b.HasOne("MilesAway.Models.Avion", "Avion")
                        .WithMany()
                        .HasForeignKey("AvionID");

                    b.HasOne("MilesAway.Models.Let", "Let")
                        .WithMany("Avion")
                        .HasForeignKey("LetID");

                    b.Navigation("Avion");

                    b.Navigation("Let");
                });

            modelBuilder.Entity("MilesAway.Models.Grad", b =>
                {
                    b.HasOne("MilesAway.Models.Drzava", "Drzava")
                        .WithMany()
                        .HasForeignKey("DrzavaID");

                    b.Navigation("Drzava");
                });

            modelBuilder.Entity("MilesAway.Models.Izvjestaj", b =>
                {
                    b.HasOne("MilesAway.Models.Menadzer", "Menadzer")
                        .WithMany()
                        .HasForeignKey("MenadzerID");

                    b.Navigation("Menadzer");
                });

            modelBuilder.Entity("MilesAway.Models.Karta", b =>
                {
                    b.HasOne("MilesAway.Models.Let", "Let")
                        .WithMany()
                        .HasForeignKey("LetID");

                    b.HasOne("MilesAway.Models.VrstaPutanjeKarte", "Putanja")
                        .WithMany()
                        .HasForeignKey("PutanjaID");

                    b.HasOne("MilesAway.Models.TipKarte", "TipKarte")
                        .WithMany()
                        .HasForeignKey("TipKarteID");

                    b.Navigation("Let");

                    b.Navigation("Putanja");

                    b.Navigation("TipKarte");
                });

            modelBuilder.Entity("MilesAway.Models.Kartica", b =>
                {
                    b.HasOne("MilesAway.Models.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID");

                    b.Navigation("Kupac");
                });

            modelBuilder.Entity("MilesAway.Models.KupljenaKarta", b =>
                {
                    b.HasOne("MilesAway.Models.Karta", "Karta")
                        .WithMany()
                        .HasForeignKey("KartaID");

                    b.HasOne("MilesAway.Models.Kupac", "Kupac")
                        .WithMany()
                        .HasForeignKey("KupacID");

                    b.HasOne("MilesAway.Models.VrstaPopusta", "Popust")
                        .WithMany()
                        .HasForeignKey("PopustID");

                    b.HasOne("MilesAway.Models.TipPrtljage", "TipPrtljage")
                        .WithMany()
                        .HasForeignKey("TipPrtljageID");

                    b.HasOne("MilesAway.Models.TipPutnika", "TipPutnika")
                        .WithMany()
                        .HasForeignKey("TipPutnikaID");

                    b.Navigation("Karta");

                    b.Navigation("Kupac");

                    b.Navigation("Popust");

                    b.Navigation("TipPrtljage");

                    b.Navigation("TipPutnika");
                });

            modelBuilder.Entity("MilesAway.Models.Let", b =>
                {
                    b.HasOne("MilesAway.Models.Grad", "Destinacija")
                        .WithMany()
                        .HasForeignKey("DestinacijaGradID");

                    b.HasOne("MilesAway.Models.Grad", "Polaziste")
                        .WithMany()
                        .HasForeignKey("PolazisteGradID");

                    b.Navigation("Destinacija");

                    b.Navigation("Polaziste");
                });

            modelBuilder.Entity("MilesAway.Models.Obavijest", b =>
                {
                    b.HasOne("MilesAway.Models.Menadzer", "Menadzer")
                        .WithMany()
                        .HasForeignKey("MenadzerID");

                    b.HasOne("MilesAway.Models.ObavijestKategorije", "ObavijestKategorija")
                        .WithMany()
                        .HasForeignKey("ObavijestKategorijeID");

                    b.Navigation("Menadzer");

                    b.Navigation("ObavijestKategorija");
                });

            modelBuilder.Entity("MilesAway.Models.PilotLet", b =>
                {
                    b.HasOne("MilesAway.Models.Let", "Let")
                        .WithMany("Pilot")
                        .HasForeignKey("LetID");

                    b.HasOne("MilesAway.Models.Pilot", "Pilot")
                        .WithMany()
                        .HasForeignKey("PilotID");

                    b.Navigation("Let");

                    b.Navigation("Pilot");
                });

            modelBuilder.Entity("MilesAway.Models.Presjedanje", b =>
                {
                    b.HasOne("MilesAway.Models.Grad", "MjestoPresjedanja")
                        .WithMany()
                        .HasForeignKey("GradID");

                    b.HasOne("MilesAway.Models.Let", "Let")
                        .WithMany()
                        .HasForeignKey("LetID");

                    b.Navigation("Let");

                    b.Navigation("MjestoPresjedanja");
                });

            modelBuilder.Entity("MilesAway.Models.Kupac", b =>
                {
                    b.HasOne("MilesAway.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("MilesAway.Models.Kupac", "KorisnikID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MilesAway.Models.Menadzer", b =>
                {
                    b.HasOne("MilesAway.Models.Korisnik", null)
                        .WithOne()
                        .HasForeignKey("MilesAway.Models.Menadzer", "KorisnikID")
                        .OnDelete(DeleteBehavior.ClientCascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MilesAway.Models.Let", b =>
                {
                    b.Navigation("Avion");

                    b.Navigation("Pilot");
                });
#pragma warning restore 612, 618
        }
    }
}
