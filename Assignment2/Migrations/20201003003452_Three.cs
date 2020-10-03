using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Assignment1.Migrations
{
    public partial class Three : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coach",
                table: "MemberEnrol");

            migrationBuilder.AddColumn<int>(
                name: "ScheduleId",
                table: "MemberEnrol",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Coaches",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fname = table.Column<string>(nullable: true),
                    Lname = table.Column<string>(nullable: true),
                    Age = table.Column<string>(nullable: true),
                    BriefIntro = table.Column<string>(nullable: true),
                    Availablity = table.Column<TimeSpan>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Coaches", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Coaches");

            migrationBuilder.DropColumn(
                name: "ScheduleId",
                table: "MemberEnrol");

            migrationBuilder.AddColumn<string>(
                name: "Coach",
                table: "MemberEnrol",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
