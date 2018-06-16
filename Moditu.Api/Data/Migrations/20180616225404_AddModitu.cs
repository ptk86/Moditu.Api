using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Moditu.Api.Data.Migrations
{
    public partial class AddModitu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ModituId",
                table: "Questions",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Moditus",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moditus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_ModituId",
                table: "Questions",
                column: "ModituId");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Moditus_ModituId",
                table: "Questions",
                column: "ModituId",
                principalTable: "Moditus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Moditus_ModituId",
                table: "Questions");

            migrationBuilder.DropTable(
                name: "Moditus");

            migrationBuilder.DropIndex(
                name: "IX_Questions_ModituId",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "ModituId",
                table: "Questions");
        }
    }
}
