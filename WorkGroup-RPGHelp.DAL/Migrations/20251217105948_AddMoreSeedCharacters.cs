using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreSeedCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CampagnId",
                value: null);

            migrationBuilder.InsertData(
                table: "Characteres",
                columns: new[] { "Id", "BaseAttackBonus", "CampagnId", "Charisma", "Constitution", "Defence", "Dexterity", "FortitudeSave", "Initiative", "Intelligence", "Level", "Name", "PVCurrent", "PVMax", "RaceId", "ReflexeSave", "Speed", "Strength", "UserId", "WillpowerSave", "Wisdom", "XP" },
                values: new object[,]
                {
                    { 24, 1, 1, 8, 16, 16, 12, 5, 1, 8, 1, "Thokk le Briseur", 15, 15, 9, 1, 30, 18, 3, 1, 10, 1 },
                    { 25, 1, 2, 12, 12, 13, 14, 1, 2, 14, 1, "Lirael de l'Aube", 9, 9, 15, 2, 30, 8, 4, 5, 16, 1 },
                    { 26, 1, 3, 13, 12, 13, 15, 1, 2, 18, 1, "Gimble l'Inventeur", 8, 8, 7, 3, 25, 6, 1, 2, 10, 10 },
                    { 27, 1, null, 14, 14, 15, 10, 4, 1, 10, 1, "Kriv l'Écaillé", 13, 13, 6, 1, 30, 17, 2, 1, 11, 1 },
                    { 28, 1, 2, 17, 12, 14, 16, 1, 3, 13, 1, "Zariel l'Ombre", 10, 10, 8, 4, 30, 10, 3, 2, 8, 1 },
                    { 29, 1, 3, 9, 15, 14, 10, 6, 1, 8, 1, "Orog le Montagnard", 16, 16, 12, 1, 30, 19, 4, 1, 12, 50 },
                    { 30, 1, 1, 14, 12, 15, 19, 2, 4, 11, 1, "Mew-Mew la Agile", 11, 11, 10, 6, 40, 10, 1, 1, 12, 1 },
                    { 31, 1, null, 8, 13, 14, 17, 1, 3, 14, 1, "Vark l'Espion", 9, 9, 13, 5, 30, 8, 2, 3, 12, 1 },
                    { 32, 1, 2, 8, 17, 16, 12, 5, 1, 10, 1, "Sss'Kala", 14, 14, 14, 2, 30, 14, 3, 3, 13, 1 },
                    { 33, 1, 1, 11, 14, 14, 14, 4, 2, 9, 1, "Hark l'Imposant", 13, 13, 17, 3, 30, 18, 4, 1, 10, 20 },
                    { 34, 1, 2, 12, 12, 15, 18, 1, 4, 10, 1, "Meepo le Chanceux", 7, 7, 18, 5, 30, 6, 1, 1, 8, 1 },
                    { 35, 1, 3, 8, 18, 17, 10, 6, 1, 12, 1, "Xiloscient", 15, 15, 4, 1, 25, 14, 2, 3, 14, 1 },
                    { 36, 1, null, 15, 12, 12, 13, 1, 1, 19, 1, "Sylas le Savant", 10, 10, 19, 2, 30, 8, 3, 4, 14, 1 },
                    { 37, 1, 1, 8, 16, 15, 10, 5, 1, 10, 1, "Pebble", 14, 14, 20, 1, 30, 17, 4, 1, 11, 1 },
                    { 38, 1, 3, 12, 14, 13, 14, 3, 2, 17, 1, "Ignis", 11, 11, 21, 3, 30, 10, 1, 1, 10, 1 },
                    { 39, 1, 2, 18, 11, 14, 16, 1, 3, 10, 1, "Pan le Joyeux", 12, 12, 22, 4, 35, 12, 2, 2, 12, 5 },
                    { 40, 1, 1, 10, 15, 18, 8, 4, 1, 10, 1, "Shelly la Lente", 13, 13, 23, 1, 30, 15, 3, 5, 17, 1 },
                    { 41, 1, null, 12, 14, 15, 12, 4, 1, 16, 1, "Korth le Cruel", 12, 12, 16, 2, 30, 14, 4, 1, 10, 1 },
                    { 42, 1, null, 14, 13, 16, 19, 2, 4, 10, 1, "Finn le Petit", 9, 9, 5, 6, 25, 8, 1, 2, 12, 1 },
                    { 43, 1, 1, 11, 14, 13, 8, 4, 1, 10, 1, "Durn le Sage", 12, 12, 11, 1, 30, 16, 2, 6, 18, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 8,
                column: "CampagnId",
                value: 2);
        }
    }
}
