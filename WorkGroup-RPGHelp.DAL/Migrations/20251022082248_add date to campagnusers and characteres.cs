using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class adddatetocampagnusersandcharacteres : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdGM",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdGM",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdGM",
                value: 1);

            migrationBuilder.InsertData(
                table: "CampagnUsers",
                columns: new[] { "CampagnsId", "UsersId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 2, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CampagnId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CampagnId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CampagnId",
                value: 2);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CampagnUsers",
                keyColumns: new[] { "CampagnsId", "UsersId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "CampagnUsers",
                keyColumns: new[] { "CampagnsId", "UsersId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "CampagnUsers",
                keyColumns: new[] { "CampagnsId", "UsersId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 1,
                column: "IdGM",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 2,
                column: "IdGM",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Campagn",
                keyColumn: "Id",
                keyValue: 3,
                column: "IdGM",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 1,
                column: "CampagnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 2,
                column: "CampagnId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Characteres",
                keyColumn: "Id",
                keyValue: 3,
                column: "CampagnId",
                value: null);
        }
    }
}
