﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SwitchEF.Infra.Data.Context;

namespace SwitchEF.Infra.Data.Migrations
{
    [DbContext(typeof(SwitchEFContext))]
    partial class SwitchEFContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SwitchEF.Domain.Entities.Identification", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Number");

                    b.Property<int>("TypeDocument");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Identification");
                });

            modelBuilder.Entity("SwitchEF.Domain.Entities.Posting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.ToTable("Postings");
                });

            modelBuilder.Entity("SwitchEF.Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Birthdate");

                    b.Property<int>("Gender");

                    b.Property<string>("Lastname")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<int>("MaritalStatus");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("SwitchEF.Domain.Entities.Identification", b =>
                {
                    b.HasOne("SwitchEF.Domain.Entities.User", "User")
                        .WithOne("Identification")
                        .HasForeignKey("SwitchEF.Domain.Entities.Identification", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
