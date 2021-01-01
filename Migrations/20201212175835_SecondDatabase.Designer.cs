﻿// <auto-generated />
using DataLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Khabar.Migrations
{
    [DbContext(typeof(KhabarContext))]
    [Migration("20201212175835_SecondDatabase")]
    partial class SecondDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domains.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CatTitle")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.HasKey("ID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Domains.News", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryID");

                    b.Property<string>("FullText");

                    b.Property<string>("Image");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("UserID");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("News");
                });

            modelBuilder.Entity("Domains.User", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email");

                    b.Property<string>("FullName");

                    b.Property<int>("Mobile");

                    b.Property<int>("NationalCode");

                    b.Property<string>("PassWord");

                    b.Property<string>("UserName");

                    b.Property<int>("UserTypeID");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domains.News", b =>
                {
                    b.HasOne("Domains.Category", "Category")
                        .WithMany("Newses")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Domains.User", "User")
                        .WithMany("News")
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
