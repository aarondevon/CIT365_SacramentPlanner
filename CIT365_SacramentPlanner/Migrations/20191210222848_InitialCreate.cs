﻿using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CIT365_SacramentPlanner.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meeting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    MeetingDate = table.Column<DateTime>(nullable: false),
                    Conductor = table.Column<string>(maxLength: 100, nullable: false),
                    OpeningHymnNumber = table.Column<int>(nullable: false),
                    SacramentHymnNumber = table.Column<int>(nullable: false),
                    RestHymnNumber = table.Column<int>(nullable: false),
                    ClosingHymn = table.Column<string>(nullable: false),
                    OpeningPrayer = table.Column<string>(maxLength: 100, nullable: false),
                    ClosingPrayer = table.Column<string>(maxLength: 100, nullable: false),
                    SpeakerOne = table.Column<string>(maxLength: 100, nullable: true),
                    SpeakerTwo = table.Column<string>(maxLength: 100, nullable: true),
                    SpeakerThree = table.Column<string>(maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meeting", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meeting");
        }
    }
}
