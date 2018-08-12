﻿// <auto-generated />
using System;
using Kodinet.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Kodinet.Migrations
{
    [DbContext(typeof(KodinetDbContext))]
    partial class KodinetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Kodinet.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Authors");
                });

            modelBuilder.Entity("Kodinet.Models.Book", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId");

                    b.Property<string>("Genre");

                    b.Property<decimal>("Price");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("Kodinet.Models.DrivingLicences", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("CategoryA");

                    b.Property<bool>("CategoryB");

                    b.Property<bool>("CategoryC");

                    b.Property<bool>("CategoryD");

                    b.Property<bool>("CategoryE");

                    b.Property<int>("CertificateNumber");

                    b.Property<string>("DateOfIssue");

                    b.Property<string>("DlNumber");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnName("expirationDate");

                    b.Property<Guid?>("IdNavigationId");

                    b.Property<Guid>("PeronId");

                    b.Property<string>("PlaceOfIssue");

                    b.HasKey("Id");

                    b.HasIndex("IdNavigationId");

                    b.ToTable("DrivingLicences");
                });

            modelBuilder.Entity("Kodinet.Models.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AvenueLoc");

                    b.Property<string>("BirthDate");

                    b.Property<string>("BirthPlace");

                    b.Property<string>("ChipNumber");

                    b.Property<string>("Commune");

                    b.Property<string>("Discriminator");

                    b.Property<string>("Email");

                    b.Property<string>("FingerPrintId");

                    b.Property<string>("IdNumber");

                    b.Property<string>("LastName");

                    b.Property<string>("Name");

                    b.Property<string>("Nationality");

                    b.Property<string>("NickName");

                    b.Property<string>("Number");

                    b.Property<string>("Photo");

                    b.Property<string>("Pobox");

                    b.Property<string>("Prov");

                    b.Property<string>("QuarterSect");

                    b.Property<string>("Signature");

                    b.Property<string>("TownDist");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Kodinet.Models.Workers", b =>
                {
                    b.Property<Guid>("WorkerId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("EntityId");

                    b.Property<string>("GradeId");

                    b.Property<string>("JobDescription");

                    b.Property<Guid>("PersonId");

                    b.HasKey("WorkerId");

                    b.HasIndex("PersonId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("Kodinet.Models.Book", b =>
                {
                    b.HasOne("Kodinet.Models.Author", "Author")
                        .WithMany()
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Kodinet.Models.DrivingLicences", b =>
                {
                    b.HasOne("Kodinet.Models.Person", "IdNavigation")
                        .WithMany()
                        .HasForeignKey("IdNavigationId");
                });

            modelBuilder.Entity("Kodinet.Models.Workers", b =>
                {
                    b.HasOne("Kodinet.Models.Person", "Person")
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
