using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddRacefix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BonusRacial_Name",
                table: "BonusRacial");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_BonusRacial_Name",
                table: "BonusRacial",
                column: "Name",
                unique: true);
        }
    }
}
