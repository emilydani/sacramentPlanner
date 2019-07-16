﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SacramentPlanner.Models;

namespace SacramentMeetingPlanner.Migrations
{
    [DbContext(typeof(SacramentContext))]
    partial class SacramentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SacramentPlanner.Models.SacramentPlan", b =>
                {
                    b.Property<int>("SacramentPlanID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClosingHymn")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("ClosingPrayer")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("Conducting")
                        .IsRequired()
                        .HasMaxLength(60);

                    b.Property<DateTime>("Date");

                    b.Property<int>("NumberSpeakers");

                    b.Property<string>("OpeningHymn")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<string>("SacramentHymn")
                        .IsRequired()
                        .HasMaxLength(30);

                    b.HasKey("SacramentPlanID");

                    b.ToTable("SacramentPlan");
                });

            modelBuilder.Entity("SacramentPlanner.Models.Speaker", b =>
                {
                    b.Property<int>("SpeakerID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80);

                    b.Property<int>("SacramentPlanID");

                    b.Property<string>("Topic")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("SpeakerID");

                    b.ToTable("Speaker");
                });
#pragma warning restore 612, 618
        }
    }
}
