﻿// <auto-generated />
using System;
using CIT365_SacramentPlanner.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CIT365_SacramentPlanner.Migrations
{
    [DbContext(typeof(MeetingContext))]
    [Migration("20191216180047_RestHymnOptional")]
    partial class RestHymnOptional
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CIT365_SacramentPlanner.Models.Meeting", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClosingHymn");

                    b.Property<string>("ClosingPrayer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Conductor")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("MeetingDate");

                    b.Property<int>("OpeningHymnNumber");

                    b.Property<string>("OpeningPrayer")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int?>("RestHymnNumber");

                    b.Property<int>("SacramentHymnNumber");

                    b.Property<string>("SpeakerOne")
                        .HasMaxLength(100);

                    b.Property<string>("SpeakerThree")
                        .HasMaxLength(100);

                    b.Property<string>("SpeakerTwo")
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Meeting");
                });
#pragma warning restore 612, 618
        }
    }
}
