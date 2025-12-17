using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedCharacters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Initiative",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseAttackBonus", "XP" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "WillpowerSave", "XP" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Characteres",
                columns: new[] { "Id", "BaseAttackBonus", "CampagnId", "Charisma", "Constitution", "Defence", "Dexterity", "FortitudeSave", "Initiative", "Intelligence", "Level", "Name", "PVCurrent", "PVMax", "RaceId", "ReflexeSave", "Speed", "Strength", "UserId", "WillpowerSave", "Wisdom", "XP" },
                values: new object[,]
                {
                    { 4, 1, 1, 13, 12, 12, 12, 1, 1, 14, 1, "Valerius le Sage", 9, 9, 15, 1, 30, 8, 3, 5, 18, 1 },
                    { 5, 1, 1, 15, 14, 16, 12, 4, 1, 7, 1, "Zog l'Éclatant", 13, 13, 6, 1, 30, 18, 4, 2, 10, 1 },
                    { 6, 1, 2, 14, 10, 13, 16, 1, 3, 18, 1, "Lirael de la Rose", 8, 8, 1, 3, 30, 7, 2, 4, 12, 1 },
                    { 7, 2, 2, 7, 18, 15, 13, 6, 1, 8, 2, "Thokk le Briseur", 15, 15, 9, 1, 30, 17, 3, 1, 9, 1200 },
                    { 8, 1, 2, 13, 12, 14, 19, 1, 4, 11, 1, "Faelar Vent-Léger", 11, 11, 10, 5, 40, 10, 4, 2, 14, 500 },
                    { 9, 2, 2, 8, 17, 18, 11, 5, 1, 9, 2, "Grimm de Pierre", 18, 22, 4, 1, 20, 15, 2, 3, 13, 1500 },
                    { 10, 1, 3, 16, 13, 15, 18, 2, 4, 12, 1, "Sly l'Ombre", 9, 9, 5, 6, 25, 9, 1, 1, 10, 1 },
                    { 11, 1, 3, 12, 14, 12, 14, 2, 2, 17, 1, "Mala la Rouge", 10, 10, 21, 2, 30, 10, 2, 4, 11, 1 },
                    { 12, 1, 3, 9, 15, 17, 8, 4, 1, 10, 1, "Korg l'Ancien", 14, 14, 23, 1, 20, 14, 3, 5, 16, 1 },
                    { 13, 1, 3, 18, 12, 13, 15, 1, 2, 13, 1, "Vesper", 12, 12, 8, 3, 30, 11, 4, 4, 10, 1 },
                    { 14, 1, 3, 10, 16, 16, 12, 5, 1, 8, 1, "Orik du Pic", 16, 16, 12, 1, 30, 19, 1, 1, 11, 1 },
                    { 15, 1, 3, 11, 12, 12, 14, 1, 2, 19, 1, "Nalia l'Astucieuse", 8, 8, 7, 2, 25, 8, 2, 3, 13, 1 },
                    { 16, 1, 3, 8, 11, 14, 17, 1, 3, 14, 1, "Skree", 9, 9, 13, 5, 30, 10, 3, 2, 15, 1 },
                    { 17, 2, 3, 9, 15, 15, 14, 4, 2, 7, 2, "Borg l'Étourdi", 18, 18, 17, 3, 30, 18, 4, 1, 8, 1100 },
                    { 18, 1, 3, 17, 12, 14, 12, 3, 1, 11, 1, "Sarya la Pure", 10, 10, 15, 1, 30, 12, 1, 5, 15, 200 },
                    { 19, 1, 3, 15, 13, 12, 14, 1, 2, 18, 1, "Xil", 11, 11, 19, 2, 30, 11, 2, 4, 12, 1 },
                    { 20, 3, 3, 10, 18, 19, 10, 7, 1, 10, 3, "Durgan le Hardi", 28, 28, 4, 2, 20, 16, 3, 4, 12, 3000 },
                    { 21, 1, 3, 12, 14, 14, 11, 4, 1, 10, 1, "Luth l'Errant", 13, 13, 11, 1, 30, 15, 4, 5, 17, 1 },
                    { 22, 1, 3, 12, 10, 15, 18, 1, 4, 10, 1, "Meepo", 7, 7, 18, 4, 30, 7, 1, 1, 8, 50 },
                    { 23, 2, 3, 14, 13, 16, 20, 2, 5, 11, 2, "Zyrk l'Agile", 12, 12, 10, 6, 40, 12, 2, 2, 11, 1350 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 1,
                column: "Initiative",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BaseAttackBonus", "XP" },
                values: new object[] { 0, 0 });

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "WillpowerSave", "XP" },
                values: new object[] { 0, 0 });
        }
    }
}
