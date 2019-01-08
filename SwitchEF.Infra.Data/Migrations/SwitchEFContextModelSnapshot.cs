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

            modelBuilder.Entity("SwitchEF.Domain.Entities.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("PhotoUrl")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("Id");

                    b.ToTable("Groups");
                });

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

                    b.ToTable("Identifications");
                });

            modelBuilder.Entity("SwitchEF.Domain.Entities.Posting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("GroupId");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(400);

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UserId");

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

            modelBuilder.Entity("SwitchEF.Domain.Entities.UserGroup", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("GroupId");

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("DateCreated");

                    b.HasKey("UserId", "GroupId");

                    b.HasIndex("GroupId");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("SwitchEF.Domain.Entities.Identification", b =>
                {
                    b.HasOne("SwitchEF.Domain.Entities.User", "User")
                        .WithOne("Identification")
                        .HasForeignKey("SwitchEF.Domain.Entities.Identification", "UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwitchEF.Domain.Entities.Posting", b =>
                {
                    b.HasOne("SwitchEF.Domain.Entities.Group", "Group")
                        .WithMany("Postings")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwitchEF.Domain.Entities.User", "User")
                        .WithMany("Postings")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SwitchEF.Domain.Entities.UserGroup", b =>
                {
                    b.HasOne("SwitchEF.Domain.Entities.Group", "Group")
                        .WithMany("UserGroups")
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SwitchEF.Domain.Entities.User", "User")
                        .WithMany("UserGroups")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
