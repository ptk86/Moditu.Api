﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Moditu.Api.Data;
using System;

namespace Moditu.Api.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Moditu.Api.Model.Moditu", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.HasKey("Id");

                    b.ToTable("Moditus");
                });

            modelBuilder.Entity("Moditu.Api.Model.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("IsDisDistinguished");

                    b.Property<int>("LikeCount");

                    b.Property<string>("ModituId");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("ModituId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("Moditu.Api.Model.Question", b =>
                {
                    b.HasOne("Moditu.Api.Model.Moditu")
                        .WithMany("Questions")
                        .HasForeignKey("ModituId");
                });
#pragma warning restore 612, 618
        }
    }
}
