﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class initcampagn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Campagn",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campagn", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Campagn",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ma première Campagne" },
                    { 2, "True Story" },
                    { 3, "Dragon First" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campagn_Name",
                table: "Campagn",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Campagn");
        }
    }
}
