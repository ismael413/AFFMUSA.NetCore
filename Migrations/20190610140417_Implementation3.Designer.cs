﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MultiAplicacion.Models;

namespace AFFMUSA.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190610140417_Implementation3")]
    partial class Implementation3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AFFMUSA.Models.Client", b =>
                {
                    b.Property<int>("ClientID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AllowBilling");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Company_Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Contact_Name")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<int>("CountryID");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<int>("Ext");

                    b.Property<string>("Fax");

                    b.Property<string>("Job_Title")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("Notes")
                        .IsRequired();

                    b.Property<string>("Phone");

                    b.Property<int>("ZipCode");

                    b.HasKey("ClientID");

                    b.HasIndex("CountryID");

                    b.ToTable("Clients");

                    b.HasData(
                        new
                        {
                            ClientID = 1,
                            AllowBilling = false,
                            City = "Texas",
                            Company_Name = "HR Company",
                            Contact_Name = "Julio",
                            CountryID = 0,
                            Email = "julio@hrcompany.com",
                            Ext = 123,
                            Fax = "7487583758",
                            Job_Title = "Encargado de Suministros",
                            Notes = "good worker",
                            Phone = "890-878-8979",
                            ZipCode = 54000
                        });
                });

            modelBuilder.Entity("AFFMUSA.Models.Country", b =>
                {
                    b.Property<int>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CountryName")
                        .IsRequired();

                    b.HasKey("CountryID");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            CountryID = 1,
                            CountryName = "United States"
                        });
                });

            modelBuilder.Entity("AFFMUSA.Models.Client", b =>
                {
                    b.HasOne("AFFMUSA.Models.Country", "Country")
                        .WithMany("Clients")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
