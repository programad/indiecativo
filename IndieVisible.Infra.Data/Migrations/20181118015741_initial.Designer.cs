﻿// <auto-generated />
using System;
using IndieVisible.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace IndieVisible.Infra.Data.Migrations
{
    [DbContext(typeof(IndieVisibleContext))]
    [Migration("20181118015741_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("IndieVisible.Domain.Models.Game", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("CoverImageUrl");

                    b.Property<string>("Description");

                    b.Property<int>("Engine");

                    b.Property<string>("FacebookUrl");

                    b.Property<string>("GameDevNetUrl");

                    b.Property<string>("GameJoltUrl");

                    b.Property<int>("Genre");

                    b.Property<string>("IndieDbUrl");

                    b.Property<string>("InstagramUrl");

                    b.Property<string>("ItchIoUrl");

                    b.Property<int>("Language");

                    b.Property<string>("Platforms");

                    b.Property<DateTime?>("ReleaseDate");

                    b.Property<int>("Status");

                    b.Property<string>("ThumbnailUrl");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("TwitterUrl");

                    b.Property<string>("UnityConnectUrl");

                    b.Property<string>("Url");

                    b.Property<string>("WebsiteUrl");

                    b.HasKey("Id");

                    b.ToTable("Games");
                });

            modelBuilder.Entity("IndieVisible.Domain.Models.UserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Bio");

                    b.Property<string>("CoverImageUrl");

                    b.Property<string>("GameDevNetUrl");

                    b.Property<string>("GameJoltUrl");

                    b.Property<string>("IndieDbUrl");

                    b.Property<string>("ItchIoUrl");

                    b.Property<string>("Location");

                    b.Property<string>("Motto");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("StudioName");

                    b.Property<int>("Type");

                    b.Property<string>("UnityConnectUrl");

                    b.Property<Guid>("UserId");

                    b.HasKey("Id");

                    b.ToTable("Profiles");
                });
#pragma warning restore 612, 618
        }
    }
}
