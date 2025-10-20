using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initcampagn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name2",
                table: "BonusRacial",
                newName: "MalusName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "BonusRacial",
                newName: "BonusName");

            migrationBuilder.RenameColumn(
                name: "Malus",
                table: "BonusRacial",
                newName: "MalusValue");

            migrationBuilder.RenameColumn(
                name: "Bonus",
                table: "BonusRacial",
                newName: "BonusValue");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Campagn",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IdGM",
                table: "Campagn",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsFinish",
                table: "Campagn",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "IdGM", "IsFinish" },
                values: new object[] { "Chapter 4 finished", 0, false });

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "IdGM", "IsFinish" },
                values: new object[] { "Chapter 2 started", 0, false });

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "IdGM", "IsFinish" },
                values: new object[] { null, 0, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Campagn");

            migrationBuilder.DropColumn(
                name: "IdGM",
                table: "Campagn");

            migrationBuilder.DropColumn(
                name: "IsFinish",
                table: "Campagn");

            migrationBuilder.RenameColumn(
                name: "MalusValue",
                table: "BonusRacial",
                newName: "Malus");

            migrationBuilder.RenameColumn(
                name: "MalusName",
                table: "BonusRacial",
                newName: "Name2");

            migrationBuilder.RenameColumn(
                name: "BonusValue",
                table: "BonusRacial",
                newName: "Bonus");

            migrationBuilder.RenameColumn(
                name: "BonusName",
                table: "BonusRacial",
                newName: "Name");
        }
    }
}
