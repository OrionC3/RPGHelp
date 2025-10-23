using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdRace",
                table: "Characteres",
                newName: "RaceId");

            migrationBuilder.CreateIndex(
                name: "IX_Characteres_RaceId",
                table: "Characteres",
                column: "RaceId");

            migrationBuilder.AddForeignKey(
                name: "FK_Characteres_Race_RaceId",
                table: "Characteres",
                column: "RaceId",
                principalTable: "Race",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Characteres_Race_RaceId",
                table: "Characteres");

            migrationBuilder.DropIndex(
                name: "IX_Characteres_RaceId",
                table: "Characteres");

            migrationBuilder.RenameColumn(
                name: "RaceId",
                table: "Characteres",
                newName: "IdRace");
        }
    }
}
