﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using ShopOnline.Data;
using ShopOnline.Models;
using System;

namespace ShopOnline.Migrations
{
    [DbContext(typeof(ShopOnlineDbContext))]
    partial class ShopOnlineDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ShopOnline.Models.Books", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BookAuthor")
                        .IsRequired();

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<int>("Type");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("ShopOnline.Models.LipColor", b =>
                {
                    b.Property<int>("Cprodid")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CShade");

                    b.Property<string>("Cprodname")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.HasKey("Cprodid");

                    b.ToTable("LipColor");
                });
#pragma warning restore 612, 618
        }
    }
}