using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkGroup_RPGHelp.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddSpells : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Spell",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Level = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Spell", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RaceSpell",
                columns: table => new
                {
                    RacesId = table.Column<int>(type: "int", nullable: false),
                    SpellsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RaceSpell", x => new { x.RacesId, x.SpellsId });
                    table.ForeignKey(
                        name: "FK_RaceSpell_Race_RacesId",
                        column: x => x.RacesId,
                        principalTable: "Race",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RaceSpell_Spell_SpellsId",
                        column: x => x.SpellsId,
                        principalTable: "Spell",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                table: "Spell",
                columns: new[] { "Id", "Description", "Level", "Name" },
                values: new object[,]
                {
                    { 1, "A bolt of flame shoots from your fingertips, searing your target.\r\nDamage: 1d10 fire damage (scales with level)", 0, "Firebolt" },
                    { 2, "A spear of pure shadow pierces a single enemy, ignoring armor.\r\nDamage: 2d8 necrotic damage, ignores non-magical defense.", 0, "Shadow Lance" },
                    { 3, "A shimmering barrier of force surrounds you.\r\n+5 AC until the start of your next turn.", 0, "Shielding Ward" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RaceSpell_SpellsId",
                table: "RaceSpell",
                column: "SpellsId");

            migrationBuilder.CreateIndex(
                name: "IX_Spell_Name",
                table: "Spell",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RaceSpell");

            migrationBuilder.DropTable(
                name: "Spell");

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
        }
    }
}
